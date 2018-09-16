namespace LegoMusic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nudInstrument = new System.Windows.Forms.NumericUpDown();
            this.cbScale = new System.Windows.Forms.ComboBox();
            this.labTranspose = new System.Windows.Forms.Label();
            this.labOctave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOctave = new System.Windows.Forms.TrackBar();
            this.tbTranspose = new System.Windows.Forms.TrackBar();
            this.sbNoteLength = new System.Windows.Forms.HScrollBar();
            this.labNoteLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sbTempo = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labTempo = new System.Windows.Forms.Label();
            this.cbBeatDuration = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sbVolume = new System.Windows.Forms.HScrollBar();
            this.label8 = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.butStopStart = new System.Windows.Forms.Button();
            this.cbVertical = new System.Windows.Forms.CheckBox();
            this.cbHorizontal = new System.Windows.Forms.CheckBox();
            this.cbRotCW = new System.Windows.Forms.CheckBox();
            this.cbRotCCW = new System.Windows.Forms.CheckBox();
            this.butStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstrument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOctave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranspose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudInstrument
            // 
            this.nudInstrument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInstrument.Location = new System.Drawing.Point(741, 89);
            this.nudInstrument.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudInstrument.Name = "nudInstrument";
            this.nudInstrument.Size = new System.Drawing.Size(225, 20);
            this.nudInstrument.TabIndex = 3;
            this.nudInstrument.ValueChanged += new System.EventHandler(this.nudInstrument_ValueChanged);
            // 
            // cbScale
            // 
            this.cbScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbScale.FormattingEnabled = true;
            this.cbScale.Location = new System.Drawing.Point(741, 39);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(225, 21);
            this.cbScale.TabIndex = 4;
            this.cbScale.SelectedIndexChanged += new System.EventHandler(this.cbScale_SelectedIndexChanged);
            // 
            // labTranspose
            // 
            this.labTranspose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTranspose.AutoSize = true;
            this.labTranspose.Location = new System.Drawing.Point(953, 386);
            this.labTranspose.Name = "labTranspose";
            this.labTranspose.Size = new System.Drawing.Size(13, 13);
            this.labTranspose.TabIndex = 7;
            this.labTranspose.Text = "0";
            // 
            // labOctave
            // 
            this.labOctave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labOctave.AutoSize = true;
            this.labOctave.Location = new System.Drawing.Point(953, 470);
            this.labOctave.Name = "labOctave";
            this.labOctave.Size = new System.Drawing.Size(13, 13);
            this.labOctave.TabIndex = 8;
            this.labOctave.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transpose (semi-tone):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Octave:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(738, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Scale:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Instrument:";
            // 
            // tbOctave
            // 
            this.tbOctave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOctave.LargeChange = 1;
            this.tbOctave.Location = new System.Drawing.Point(742, 470);
            this.tbOctave.Maximum = 5;
            this.tbOctave.Minimum = -5;
            this.tbOctave.Name = "tbOctave";
            this.tbOctave.Size = new System.Drawing.Size(181, 45);
            this.tbOctave.TabIndex = 13;
            this.tbOctave.Scroll += new System.EventHandler(this.tbOctave_Scroll);
            // 
            // tbTranspose
            // 
            this.tbTranspose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTranspose.LargeChange = 1;
            this.tbTranspose.Location = new System.Drawing.Point(739, 386);
            this.tbTranspose.Maximum = 8;
            this.tbTranspose.Minimum = -8;
            this.tbTranspose.Name = "tbTranspose";
            this.tbTranspose.Size = new System.Drawing.Size(184, 45);
            this.tbTranspose.TabIndex = 14;
            this.tbTranspose.Scroll += new System.EventHandler(this.tbTranspose_Scroll);
            // 
            // sbNoteLength
            // 
            this.sbNoteLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbNoteLength.Location = new System.Drawing.Point(745, 193);
            this.sbNoteLength.Maximum = 300;
            this.sbNoteLength.Minimum = 10;
            this.sbNoteLength.Name = "sbNoteLength";
            this.sbNoteLength.Size = new System.Drawing.Size(181, 17);
            this.sbNoteLength.TabIndex = 15;
            this.sbNoteLength.Value = 100;
            this.sbNoteLength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbNoteLength_Scroll);
            // 
            // labNoteLength
            // 
            this.labNoteLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labNoteLength.AutoSize = true;
            this.labNoteLength.Location = new System.Drawing.Point(945, 197);
            this.labNoteLength.Name = "labNoteLength";
            this.labNoteLength.Size = new System.Drawing.Size(25, 13);
            this.labNoteLength.TabIndex = 16;
            this.labNoteLength.Text = "100";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Note length (ms):";
            // 
            // sbTempo
            // 
            this.sbTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbTempo.Location = new System.Drawing.Point(745, 248);
            this.sbTempo.Maximum = 250;
            this.sbTempo.Minimum = 40;
            this.sbTempo.Name = "sbTempo";
            this.sbTempo.Size = new System.Drawing.Size(178, 17);
            this.sbTempo.TabIndex = 18;
            this.sbTempo.Value = 75;
            this.sbTempo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbTempo_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(738, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tempo (BPM):";
            // 
            // labTempo
            // 
            this.labTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTempo.AutoSize = true;
            this.labTempo.Location = new System.Drawing.Point(951, 252);
            this.labTempo.Name = "labTempo";
            this.labTempo.Size = new System.Drawing.Size(19, 13);
            this.labTempo.TabIndex = 20;
            this.labTempo.Text = "75";
            // 
            // cbBeatDuration
            // 
            this.cbBeatDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBeatDuration.FormattingEnabled = true;
            this.cbBeatDuration.Items.AddRange(new object[] {
            "Quarter ",
            "Eighth ",
            "Sixteenth",
            "Thirty-second"});
            this.cbBeatDuration.Location = new System.Drawing.Point(745, 310);
            this.cbBeatDuration.Name = "cbBeatDuration";
            this.cbBeatDuration.Size = new System.Drawing.Size(221, 21);
            this.cbBeatDuration.TabIndex = 21;
            this.cbBeatDuration.SelectedIndexChanged += new System.EventHandler(this.cbBeatDuration_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Beat duration:";
            // 
            // sbVolume
            // 
            this.sbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbVolume.Location = new System.Drawing.Point(742, 141);
            this.sbVolume.Maximum = 127;
            this.sbVolume.Name = "sbVolume";
            this.sbVolume.Size = new System.Drawing.Size(229, 17);
            this.sbVolume.TabIndex = 23;
            this.sbVolume.Value = 127;
            this.sbVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVolume_Scroll);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(740, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Volume:";
            // 
            // imageBox1
            // 
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(46, 23);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(650, 478);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // butStopStart
            // 
            this.butStopStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butStopStart.Location = new System.Drawing.Point(891, 521);
            this.butStopStart.Name = "butStopStart";
            this.butStopStart.Size = new System.Drawing.Size(75, 23);
            this.butStopStart.TabIndex = 25;
            this.butStopStart.Text = "Stop";
            this.butStopStart.UseVisualStyleBackColor = true;
            this.butStopStart.Click += new System.EventHandler(this.butStopStart_Click);
            // 
            // cbVertical
            // 
            this.cbVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVertical.AutoSize = true;
            this.cbVertical.Checked = true;
            this.cbVertical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVertical.Location = new System.Drawing.Point(84, 525);
            this.cbVertical.Name = "cbVertical";
            this.cbVertical.Size = new System.Drawing.Size(80, 17);
            this.cbVertical.TabIndex = 26;
            this.cbVertical.Text = "Flip Vertical";
            this.cbVertical.UseVisualStyleBackColor = true;
            // 
            // cbHorizontal
            // 
            this.cbHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbHorizontal.AutoSize = true;
            this.cbHorizontal.Checked = true;
            this.cbHorizontal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHorizontal.Location = new System.Drawing.Point(195, 525);
            this.cbHorizontal.Name = "cbHorizontal";
            this.cbHorizontal.Size = new System.Drawing.Size(89, 17);
            this.cbHorizontal.TabIndex = 27;
            this.cbHorizontal.Text = "FlipHorizontal";
            this.cbHorizontal.UseVisualStyleBackColor = true;
            // 
            // cbRotCW
            // 
            this.cbRotCW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRotCW.AutoSize = true;
            this.cbRotCW.Enabled = false;
            this.cbRotCW.Location = new System.Drawing.Point(319, 521);
            this.cbRotCW.Name = "cbRotCW";
            this.cbRotCW.Size = new System.Drawing.Size(79, 17);
            this.cbRotCW.TabIndex = 28;
            this.cbRotCW.Text = "Rotate CW";
            this.cbRotCW.UseVisualStyleBackColor = true;
            // 
            // cbRotCCW
            // 
            this.cbRotCCW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRotCCW.AutoSize = true;
            this.cbRotCCW.Enabled = false;
            this.cbRotCCW.Location = new System.Drawing.Point(450, 521);
            this.cbRotCCW.Name = "cbRotCCW";
            this.cbRotCCW.Size = new System.Drawing.Size(86, 17);
            this.cbRotCCW.TabIndex = 29;
            this.cbRotCCW.Text = "Rotate CCW";
            this.cbRotCCW.UseVisualStyleBackColor = true;
            // 
            // butStep
            // 
            this.butStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butStep.Enabled = false;
            this.butStep.Location = new System.Drawing.Point(745, 521);
            this.butStep.Name = "butStep";
            this.butStep.Size = new System.Drawing.Size(75, 23);
            this.butStep.TabIndex = 30;
            this.butStep.Text = "Step";
            this.butStep.UseVisualStyleBackColor = true;
            this.butStep.Click += new System.EventHandler(this.butStep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 567);
            this.Controls.Add(this.butStep);
            this.Controls.Add(this.cbRotCCW);
            this.Controls.Add(this.cbRotCW);
            this.Controls.Add(this.cbHorizontal);
            this.Controls.Add(this.cbVertical);
            this.Controls.Add(this.butStopStart);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sbVolume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBeatDuration);
            this.Controls.Add(this.labTempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sbTempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labNoteLength);
            this.Controls.Add(this.sbNoteLength);
            this.Controls.Add(this.tbTranspose);
            this.Controls.Add(this.tbOctave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labOctave);
            this.Controls.Add(this.labTranspose);
            this.Controls.Add(this.cbScale);
            this.Controls.Add(this.nudInstrument);
            this.Name = "Form1";
            this.Text = "Lego Music";
            ((System.ComponentModel.ISupportInitialize)(this.nudInstrument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOctave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranspose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudInstrument;
        private System.Windows.Forms.ComboBox cbScale;
        private System.Windows.Forms.Label labTranspose;
        private System.Windows.Forms.Label labOctave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbOctave;
        private System.Windows.Forms.TrackBar tbTranspose;
        private System.Windows.Forms.HScrollBar sbNoteLength;
        private System.Windows.Forms.Label labNoteLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar sbTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labTempo;
        private System.Windows.Forms.ComboBox cbBeatDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar sbVolume;
        private System.Windows.Forms.Label label8;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button butStopStart;
        private System.Windows.Forms.CheckBox cbVertical;
        private System.Windows.Forms.CheckBox cbHorizontal;
        private System.Windows.Forms.CheckBox cbRotCW;
        private System.Windows.Forms.CheckBox cbRotCCW;
        private System.Windows.Forms.Button butStep;
    }
}

