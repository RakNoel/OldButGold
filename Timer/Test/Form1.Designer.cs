namespace Test
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.Hitme = new System.Windows.Forms.Button();
            this.timeLeftBar = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.returner = new System.Windows.Forms.Button();
            this.Countdown = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hitme
            // 
            this.Hitme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hitme.Location = new System.Drawing.Point(12, 12);
            this.Hitme.Name = "Hitme";
            this.Hitme.Size = new System.Drawing.Size(114, 28);
            this.Hitme.TabIndex = 0;
            this.Hitme.Text = "Click to start";
            this.Hitme.UseVisualStyleBackColor = true;
            this.Hitme.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeLeftBar
            // 
            this.timeLeftBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeLeftBar.Location = new System.Drawing.Point(12, 153);
            this.timeLeftBar.MarqueeAnimationSpeed = 300;
            this.timeLeftBar.Maximum = 10800;
            this.timeLeftBar.Minimum = 15;
            this.timeLeftBar.Name = "timeLeftBar";
            this.timeLeftBar.Size = new System.Drawing.Size(401, 23);
            this.timeLeftBar.TabIndex = 15;
            this.timeLeftBar.Value = 15;
            this.timeLeftBar.Click += new System.EventHandler(this.timeLeft_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 30;
            this.trackBar1.Location = new System.Drawing.Point(5, 102);
            this.trackBar1.Maximum = 10800;
            this.trackBar1.Minimum = 60;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(417, 45);
            this.trackBar1.SmallChange = 15;
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 900;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 60;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(352, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hours   :  0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(352, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutes:  0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pause
            // 
            this.Pause.Enabled = false;
            this.Pause.Location = new System.Drawing.Point(12, 68);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(114, 28);
            this.Pause.TabIndex = 7;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Abort
            // 
            this.Abort.Enabled = false;
            this.Abort.Location = new System.Drawing.Point(132, 68);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(114, 28);
            this.Abort.TabIndex = 8;
            this.Abort.Text = "Abort!";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // returner
            // 
            this.returner.Location = new System.Drawing.Point(12, 68);
            this.returner.Name = "returner";
            this.returner.Size = new System.Drawing.Size(114, 28);
            this.returner.TabIndex = 9;
            this.returner.Text = "Return";
            this.returner.UseVisualStyleBackColor = true;
            this.returner.Visible = false;
            this.returner.Click += new System.EventHandler(this.returner_Click);
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Location = new System.Drawing.Point(162, 163);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(0, 13);
            this.Countdown.TabIndex = 10;
            this.Countdown.Click += new System.EventHandler(this.Countdown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(352, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Second:  0";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(426, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.returner);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.timeLeftBar);
            this.Controls.Add(this.Hitme);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "Test";
            this.Text = "Timer:";
            this.Load += new System.EventHandler(this.EventHandler);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hitme;
        private System.Windows.Forms.ProgressBar timeLeftBar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.Button returner;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Label label3;
    }
}

