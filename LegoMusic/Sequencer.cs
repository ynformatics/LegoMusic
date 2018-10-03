

using NAudio.Midi;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LegoMusic
{
    class Sequencer
    {
        MidiOut midiOut;
        AccurateTimer timer;
        int period;

        Note[][] notes;

        public Sequencer(MidiOut midiOut)
        {
            this.midiOut = midiOut;

            NoteLength = 100;
            period = 250;
            timer = new AccurateTimer(null, new Action(Timer_Tick), Period);
        }

        public int Column { get; private set; } = 0;
        public int Instrument { get; set; }
        public int Channel { get; set; } = 1;
        public int NoteLength { get; set; }
        public int Period
        {
            set
            {
                period = value;
                timer.SetDelay(period);
            }
            get { return period; }
        }

        public void Stop()
        {
            timer.Stop();
        }
        public void Start()
        {
            timer = new AccurateTimer(null, new Action(Timer_Tick), Period);
        }

        public void Step()
        {
            Timer_Tick();
        }
        public void SetNotes(Note[][] notes)
        {
            this.notes = notes;      
        }
        private void Timer_Tick()
        {
            if (notes != null && notes[Column] != null && notes[Column].Length > 0)
            {
                var notes = this.notes[Column];
                var noteLength = NoteLength;

                Task.Run(() =>
                {
                    midiOut.Send(MidiMessage.ChangePatch(Instrument, Channel).RawData);

                    foreach (var note in notes)
                        midiOut.Send(MidiMessage.StartNote(note.Pitch, note.Volume, Channel).RawData);

                    Thread.Sleep(noteLength);

                    foreach (var note in notes)
                        midiOut.Send(MidiMessage.StopNote(note.Pitch, note.Volume, Channel).RawData);
                });
            

                
            }
            if(notes != null)
            if (++Column >= this.notes.Length)
                    Column = 0;
        }
    }

    class Note
    {
        public int Pitch;
        public int Volume;    
    }
}
