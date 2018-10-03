using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;

using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Emgu.CV.Features2D.Features2DToolbox;

namespace LegoMusic
{
    public partial class Form1 : Form
    {
        VideoCapture frameGrabber;
        Mat frame;

        SimpleBlobDetector simpleBlobDetector;

        MidiOut midiOut;

        Dictionary<string, int[]> scales;
        int[] scale;

        int transpose = 0;
        int octave = 0;
        int beatDuration = 16;
        int volume = 127;
        int instrument = 96;

        Sequencer sequencer;

        static int imageWidth = 640;//1280;//960;// 640;
        static int imageHeight = 480;//720;//480;
        static int gridSize = 16;
        int columnWidth;
        int rowHeight;

        public Form1()
        {
            InitializeComponent();

            gridSize = GetIntAppSetting("gridsize", 16);
            imageWidth = GetIntAppSetting("imagewidth", 640);
            imageHeight = GetIntAppSetting("imageheight", 480);

            columnWidth = imageWidth / gridSize;
            rowHeight = imageHeight / gridSize;

            scales = new Dictionary<string, int[]>
            {
                { "Ionian",     new int[] { 60, 62, 64, 65, 67, 69, 71, 72, 74, 76, 77, 79, 81, 83, 84, 86 } },
                { "Dorian",     new int[] { 60, 62, 63, 65, 67, 69, 70, 72, 74, 75, 77, 79, 81, 82, 84, 86 } },
                { "Phrygian",   new int[] { 60, 61, 63, 65, 67, 68, 70, 72, 73, 75, 77, 79, 80, 83, 84, 85 } },
                { "Lydian",     new int[] { 60, 62, 64, 66, 67, 69, 71, 72, 74, 76, 78, 79, 81, 83, 84, 86 } },
                { "Mixolydian", new int[] { 60, 62, 64, 65, 67, 69, 70, 72, 74, 76, 77, 79, 81, 82, 84, 86 } },
                { "Aeolian",    new int[] { 60, 62, 63, 65, 67, 68, 70, 72, 74, 75, 77, 79, 80, 82, 84, 86 } },
                { "Locrian",    new int[] { 60, 61, 63, 65, 66, 68, 70, 72, 73, 75, 77, 78, 80, 82, 84, 85 } },
                { "Chromatic",  new int[] { 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 } },
                { "Okinawa",    new int[] { 60, 64, 65, 67, 71, 72, 76, 77, 79, 83, 84, 88, 89, 91, 95, 96 } }
            };

            var parms = new SimpleBlobDetectorParams()
            {
                FilterByCircularity = false,
                FilterByArea = true,
                MinArea = GetIntAppSetting("minblobarea", 500),
                MaxArea = GetIntAppSetting("maxblobarea", 2000),
                FilterByColor = false,
                FilterByConvexity = false,
            };

            simpleBlobDetector = new SimpleBlobDetector(parms);

            frame = new Mat();

            midiOut = new MidiOut(GetIntAppSetting("mididevice"));

            frameGrabber = new VideoCapture(GetIntAppSetting("cameraindex"));

            frameGrabber.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, imageWidth);
            frameGrabber.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, imageHeight);

            frameGrabber.ImageGrabbed += FrameGrabber_ImageGrabbed;

            sequencer = new Sequencer(midiOut);

            nudInstrument.Value = instrument;

            cbScale.Items.AddRange(scales.Keys.ToArray());
            cbScale.SelectedIndex = 0;
            scale = scales[(string)cbScale.Items[0]];

            cbBeatDuration.SelectedIndex = 2;

            frameGrabber.Start();
        }



        private void FrameGrabber_ImageGrabbed(object sender, EventArgs e)
        {
            frameGrabber.Retrieve(frame, 0);

            if (cbHorizontal.Checked) CvInvoke.Flip(frame, frame, FlipType.Horizontal);
            if (cbVertical.Checked) CvInvoke.Flip(frame, frame, FlipType.Vertical);
            if (cbRotCW.Checked) CvInvoke.Rotate(frame, frame, RotateFlags.Rotate90Clockwise);
            if (cbRotCCW.Checked) CvInvoke.Rotate(frame, frame, RotateFlags.Rotate90CounterClockwise);

            var blobs = simpleBlobDetector.Detect(frame);

            sequencer.SetNotes(BlobsToNotes(blobs, volume));

            int column = sequencer.Column - 1;
            if (column < 0)
                column = 15;

            DrawKeypoints(frame,
                   new VectorOfKeyPoint(blobs),
                   frame,
                   new Bgr(90, 90, 90), KeypointDrawType.Default);

            for (int x = 1; x < imageWidth; x += columnWidth)
                CvInvoke.Line(frame, new Point(x, 0), new Point(x, imageHeight), new MCvScalar(0, 0, 0), 1);

            for (int y = 1; y < imageHeight; y += rowHeight)
                CvInvoke.Line(frame, new Point(0, y), new Point(imageWidth, y), new MCvScalar(0, 0, 0), 1);

            int left = column * columnWidth;
            int right = (column + 1) * columnWidth;

            CvInvoke.Line(frame, new Point(left, 0), new Point(left, imageHeight), new MCvScalar(0, 0, 0), 2);
            CvInvoke.Line(frame, new Point(right, 0), new Point(right, imageHeight), new MCvScalar(0, 0, 0), 2);

            foreach (var blob in blobs.Where(p => p.Point.X >= left && p.Point.X < right))
                CvInvoke.Circle(frame, new Point((int)blob.Point.X, (int)blob.Point.Y), 4, new MCvScalar(0, 0, 0), -1);

            imageBox1.Image = frame;
        }

        Note[][] BlobsToNotes(MKeyPoint[] blobs, int volume)
        {
            List<Note>[] noteList = new List<Note>[gridSize];

            foreach (var blob in blobs)
            {
                var col = (int)(blob.Point.X * gridSize / imageWidth);
                var row = gridSize - 1 - (int)(blob.Point.Y * gridSize / imageHeight);

                if (noteList[col] == null)
                    noteList[col] = new List<Note>();

                noteList[col].Add(new Note() { Pitch = Clamp127(scale[row] + transpose + octave), Volume = volume });
            }

            return noteList.Select(nl => nl?.ToArray()).ToArray();
        }

        int Clamp127(int value)
        {
            return (value < 0) ? 0 : (value > 127) ? 127 : value;
        }

        private void nudInstrument_ValueChanged(object sender, EventArgs e)
        {
            instrument = (int)nudInstrument.Value;
            sequencer.Instrument = instrument;
        }

        private void cbScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            scale = scales[(string)cbScale.SelectedItem];
        }

        private void tbTranspose_Scroll(object sender, EventArgs e)
        {
            labTranspose.Text = tbTranspose.Value.ToString();
            transpose = tbTranspose.Value;
        }

        private void tbOctave_Scroll(object sender, EventArgs e)
        {
            labOctave.Text = tbOctave.Value.ToString();
            octave = tbOctave.Value * 12;
        }

        private void sbNoteLength_Scroll(object sender, ScrollEventArgs e)
        {
            labNoteLength.Text = sbNoteLength.Value.ToString();
            sequencer.NoteLength = sbNoteLength.Value;
        }

        private void sbTempo_Scroll(object sender, ScrollEventArgs e)
        {
            UpdatePeriod();
            labTempo.Text = sbTempo.Value.ToString();
        }

        private void cbBeatDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBeatDuration.SelectedIndex)
            {
                case 0:
                    beatDuration = 4; break;
                case 1:
                    beatDuration = 8; break;
                case 2:
                    beatDuration = 16; break;
                case 3:
                    beatDuration = 32; break;
            }
            UpdatePeriod();
        }

        private void UpdatePeriod()
        {
            sequencer.Period = 3840000 / (beatDuration * sbTempo.Value) / gridSize;
        }
        private void sbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            volume = sbVolume.Value;
        }

        private void butStopStart_Click(object sender, EventArgs e)
        {
            if (butStopStart.Text == "Stop")
            {
                sequencer.Stop();
                butStopStart.Text = "Start";
                butStep.Enabled = true;
            }
            else
            {
                sequencer.Start();
                butStopStart.Text = "Stop";
                butStep.Enabled = false;
            }
        }

        private void butStep_Click(object sender, EventArgs e)
        {
            sequencer.Step();
        }

        private void cbDrum_CheckedChanged(object sender, EventArgs e)
        {
            sequencer.Channel = cbDrum.Checked ? 10 : 1;

            nudInstrument.Enabled = !cbDrum.Checked;
        }

        int GetIntAppSetting(string name, int defaultValue = 0)
        {
            var setting = ConfigurationManager.AppSettings[name];
            if (setting == null)
                return defaultValue;

            return int.TryParse(setting, out int val) ? val : defaultValue;
        }
    }
}
