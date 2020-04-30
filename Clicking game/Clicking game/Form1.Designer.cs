namespace Clicking_game
{
    partial class KlikkeSpill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlikkeSpill));
            this.GameButton = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hiScore = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.rb60 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Back = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stat60 = new System.Windows.Forms.Label();
            this.stat30 = new System.Windows.Forms.Label();
            this.stat15 = new System.Windows.Forms.Label();
            this.kps = new System.Windows.Forms.GroupBox();
            this.Kpss60 = new System.Windows.Forms.Label();
            this.Kpss30 = new System.Windows.Forms.Label();
            this.Kpss15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.thisScore = new System.Windows.Forms.Label();
            this.thisKPS = new System.Windows.Forms.Label();
            this.resetStats = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Label();
            this.timeleftcounter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveName = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.kps.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameButton
            // 
            this.GameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameButton.Image = global::Clicking_game.Properties.Resources._679040___click_target_heat_map_hot_;
            this.GameButton.Location = new System.Drawing.Point(114, 28);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(530, 177);
            this.GameButton.TabIndex = 0;
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Visible = false;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(321, 99);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(89, 34);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start Game";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(114, 258);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(530, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(12, 233);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 3;
            this.restart.Text = "Restart:";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score: ";
            // 
            // hiScore
            // 
            this.hiScore.AutoSize = true;
            this.hiScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hiScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hiScore.Location = new System.Drawing.Point(0, 16);
            this.hiScore.Name = "hiScore";
            this.hiScore.Size = new System.Drawing.Size(42, 15);
            this.hiScore.TabIndex = 5;
            this.hiScore.Text = "Best:   ";
            this.hiScore.Click += new System.EventHandler(this.hiScore_Click);
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.Location = new System.Drawing.Point(319, 111);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(91, 13);
            this.record.TabIndex = 16;
            this.record.Text = "NEW RECORD!!!";
            this.record.Visible = false;
            // 
            // rb60
            // 
            this.rb60.AutoSize = true;
            this.rb60.Location = new System.Drawing.Point(6, 19);
            this.rb60.Name = "rb60";
            this.rb60.Size = new System.Drawing.Size(59, 17);
            this.rb60.TabIndex = 17;
            this.rb60.Text = "60 Sec";
            this.rb60.UseVisualStyleBackColor = true;
            this.rb60.CheckedChanged += new System.EventHandler(this.rb60_CheckedChanged);
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Location = new System.Drawing.Point(6, 42);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(59, 17);
            this.rb30.TabIndex = 18;
            this.rb30.Text = "30 Sec";
            this.rb30.UseVisualStyleBackColor = true;
            this.rb30.CheckedChanged += new System.EventHandler(this.rb30_CheckedChanged);
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Location = new System.Drawing.Point(6, 65);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(59, 17);
            this.rb15.TabIndex = 19;
            this.rb15.Text = "15 Sec";
            this.rb15.UseVisualStyleBackColor = true;
            this.rb15.CheckedChanged += new System.EventHandler(this.rb15_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb60);
            this.groupBox1.Controls.Add(this.rb15);
            this.groupBox1.Controls.Add(this.rb30);
            this.groupBox1.Location = new System.Drawing.Point(114, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 177);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Back);
            this.groupBox2.Controls.Add(this.stats);
            this.groupBox2.Controls.Add(this.hiScore);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 177);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scores:";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(0, 83);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back:";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // stats
            // 
            this.stats.Location = new System.Drawing.Point(0, 82);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(75, 23);
            this.stats.TabIndex = 21;
            this.stats.Text = "Statistics:";
            this.stats.UseVisualStyleBackColor = true;
            this.stats.Click += new System.EventHandler(this.stats_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stat60);
            this.groupBox3.Controls.Add(this.stat30);
            this.groupBox3.Controls.Add(this.stat15);
            this.groupBox3.Location = new System.Drawing.Point(238, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 103);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats:";
            this.groupBox3.Visible = false;
            // 
            // stat60
            // 
            this.stat60.AutoSize = true;
            this.stat60.Location = new System.Drawing.Point(3, 65);
            this.stat60.Name = "stat60";
            this.stat60.Size = new System.Drawing.Size(144, 13);
            this.stat60.TabIndex = 2;
            this.stat60.Text = "60s........................................";
            // 
            // stat30
            // 
            this.stat30.AutoSize = true;
            this.stat30.Location = new System.Drawing.Point(3, 40);
            this.stat30.Name = "stat30";
            this.stat30.Size = new System.Drawing.Size(144, 13);
            this.stat30.TabIndex = 1;
            this.stat30.Text = "30s........................................";
            // 
            // stat15
            // 
            this.stat15.AutoSize = true;
            this.stat15.Location = new System.Drawing.Point(3, 16);
            this.stat15.Name = "stat15";
            this.stat15.Size = new System.Drawing.Size(144, 13);
            this.stat15.TabIndex = 0;
            this.stat15.Text = "15s........................................";
            // 
            // kps
            // 
            this.kps.Controls.Add(this.Kpss60);
            this.kps.Controls.Add(this.Kpss30);
            this.kps.Controls.Add(this.Kpss15);
            this.kps.Location = new System.Drawing.Point(444, 47);
            this.kps.Name = "kps";
            this.kps.Size = new System.Drawing.Size(200, 103);
            this.kps.TabIndex = 22;
            this.kps.TabStop = false;
            this.kps.Text = "KPS:";
            this.kps.Visible = false;
            // 
            // Kpss60
            // 
            this.Kpss60.AutoSize = true;
            this.Kpss60.Location = new System.Drawing.Point(3, 65);
            this.Kpss60.Name = "Kpss60";
            this.Kpss60.Size = new System.Drawing.Size(157, 13);
            this.Kpss60.TabIndex = 2;
            this.Kpss60.Text = "Kps60........................................";
            // 
            // Kpss30
            // 
            this.Kpss30.AutoSize = true;
            this.Kpss30.Location = new System.Drawing.Point(3, 40);
            this.Kpss30.Name = "Kpss30";
            this.Kpss30.Size = new System.Drawing.Size(157, 13);
            this.Kpss30.TabIndex = 1;
            this.Kpss30.Text = "Kps30........................................";
            // 
            // Kpss15
            // 
            this.Kpss15.AutoSize = true;
            this.Kpss15.Location = new System.Drawing.Point(3, 16);
            this.Kpss15.Name = "Kpss15";
            this.Kpss15.Size = new System.Drawing.Size(157, 13);
            this.Kpss15.TabIndex = 0;
            this.Kpss15.Text = "Kps15........................................";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Namelabel);
            this.groupBox4.Controls.Add(this.thisScore);
            this.groupBox4.Controls.Add(this.thisKPS);
            this.groupBox4.Location = new System.Drawing.Point(444, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stats:";
            this.groupBox4.Visible = false;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(7, 16);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(41, 13);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name: ";
            // 
            // thisScore
            // 
            this.thisScore.AutoSize = true;
            this.thisScore.Location = new System.Drawing.Point(6, 36);
            this.thisScore.Name = "thisScore";
            this.thisScore.Size = new System.Drawing.Size(89, 13);
            this.thisScore.TabIndex = 1;
            this.thisScore.Text = "Clicks:.................";
            // 
            // thisKPS
            // 
            this.thisKPS.AutoSize = true;
            this.thisKPS.Location = new System.Drawing.Point(6, 61);
            this.thisKPS.Name = "thisKPS";
            this.thisKPS.Size = new System.Drawing.Size(91, 13);
            this.thisKPS.TabIndex = 0;
            this.thisKPS.Text = "KPS:....................";
            // 
            // resetStats
            // 
            this.resetStats.Location = new System.Drawing.Point(533, 233);
            this.resetStats.Name = "resetStats";
            this.resetStats.Size = new System.Drawing.Size(111, 23);
            this.resetStats.TabIndex = 23;
            this.resetStats.Text = "Reset Stats!";
            this.resetStats.UseVisualStyleBackColor = true;
            this.resetStats.Visible = false;
            this.resetStats.Click += new System.EventHandler(this.resetStats_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(533, 233);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(111, 23);
            this.No.TabIndex = 24;
            this.No.Text = "NO!";
            this.No.UseVisualStyleBackColor = true;
            this.No.Visible = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(412, 233);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(115, 23);
            this.Yes.TabIndex = 25;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Visible = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(412, 217);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(115, 13);
            this.check.TabIndex = 26;
            this.check.Text = "Are you sure abot this?";
            this.check.Visible = false;
            // 
            // timeleftcounter
            // 
            this.timeleftcounter.AutoSize = true;
            this.timeleftcounter.Location = new System.Drawing.Point(343, 268);
            this.timeleftcounter.Name = "timeleftcounter";
            this.timeleftcounter.Size = new System.Drawing.Size(42, 13);
            this.timeleftcounter.TabIndex = 28;
            this.timeleftcounter.Text = "Time:...";
            this.timeleftcounter.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBox1.Location = new System.Drawing.Point(57, 2);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name:";
            // 
            // SaveName
            // 
            this.SaveName.Location = new System.Drawing.Point(163, 2);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(75, 20);
            this.SaveName.TabIndex = 31;
            this.SaveName.Text = "Save:";
            this.SaveName.UseVisualStyleBackColor = true;
            this.SaveName.Click += new System.EventHandler(this.SaveName_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // KlikkeSpill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 294);
            this.Controls.Add(this.SaveName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timeleftcounter);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.check);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.No);
            this.Controls.Add(this.resetStats);
            this.Controls.Add(this.kps);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.record);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.GameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlikkeSpill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Clicking Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.kps.ResumeLayout(false);
            this.kps.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameButton;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hiScore;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.RadioButton rb60;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stats;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label stat60;
        private System.Windows.Forms.Label stat30;
        private System.Windows.Forms.Label stat15;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox kps;
        private System.Windows.Forms.Label Kpss60;
        private System.Windows.Forms.Label Kpss30;
        private System.Windows.Forms.Label Kpss15;
        private System.Windows.Forms.Button resetStats;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label thisScore;
        private System.Windows.Forms.Label thisKPS;
        private System.Windows.Forms.Label timeleftcounter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveName;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Timer timer2;
    }
}

