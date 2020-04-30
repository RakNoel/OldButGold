using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace Clicking_game
{
    public partial class KlikkeSpill : Form
    {
        public KlikkeSpill()
        {
            InitializeComponent();
        }

        //Globale variabler
        int score, timeLeft, highScore, highScore60, highScore30, highScore15, GameType, pgBar;
        string readscore, readName, top15name, top30name, top60name, playerName;
        decimal kps60, kps30, kps15, kpsNow;

        private void rb60_CheckedChanged(object sender, EventArgs e)
        {
            if (rb60.Checked == true)
            {
                GameType = 60;
                readHighScore();
                highScore = highScore60;
                hiScore.Text = "Best:   " + highScore;
                progressBar1.Maximum = 3600;
            }
        }

        private void rb30_CheckedChanged(object sender, EventArgs e)
        {
            if (rb30.Checked == true)
            {
                GameType = 30;
                readHighScore();
                highScore = highScore30;
                hiScore.Text = "Best:   " + highScore;
                progressBar1.Maximum = 1800;
            }
        }

        private void rb15_CheckedChanged(object sender, EventArgs e)
        {
            if (rb15.Checked == true)
            {
                GameType = 15;
                readHighScore();
                highScore = highScore15;
                hiScore.Text = "Best:   " + highScore;
                progressBar1.Maximum = 900;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            stats.Visible = false;
            GameButton.Visible = true;
            groupBox1.Visible = false;
            progressBar1.Visible = true;
            timeleftcounter.Visible = true;
            progressBar1.Value = 0;
            pgBar = 0;

            if (playerName == "N/A")
            {
                textBox1.Text = "AAA";
            }
            else
            {
                textBox1.Enabled = false;
            }

            score = 0;

            if (GameType == 0)
            {
                readHighScore();
                GameType = 15;
                readHighScore();
                highScore = highScore15;
                hiScore.Text = "Best:   " + highScore;
                progressBar1.Maximum = 900;
            }

            timeLeft = GameType;

            hiScore.Text = "Best:   " + highScore;

            timer1.Start();
            timer2.Start();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                score = score + 1;
                label1.Text = "Score: " + score;
                if (score > highScore) { hiScore.Text = "Best:    " + score; }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pgBar < 900)
            {
                pgBar = pgBar + 1;
                progressBar1.Value = pgBar;
            }
            else if (pgBar == 900)
            {
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeleftcounter.Text = "Time:..." + timeLeft;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                GameButton.Visible = false;
                restart.Visible = true;
                label1.Visible = true;
                label1.Text = "Score: " + score;
                groupBox1.Visible = true;
                groupBox4.Visible = true;
                progressBar1.Visible = false;
                findKps();
                timeleftcounter.Visible = false;
                pgBar = 0;

                if (GameType == 60) { highScore = highScore60; }
                else if (GameType == 30){ highScore = highScore30; }
                else { highScore = highScore15; }

                if (score > highScore)
                {
                    highScore = score;
                    hiScore.Text = "Best:   " + highScore;
                    record.Visible = true;
                    writeHigScore();
                }
            }
        }

        private void writeHigScore()
        {
            if (GameType == 60)
            {
                Clicking_game.Properties.Settings.Default.Score60 = score;
                Clicking_game.Properties.Settings.Default.Name60 = playerName;
            }
            else if (GameType == 30)
            {
                Clicking_game.Properties.Settings.Default.Score30 = score;
                Clicking_game.Properties.Settings.Default.Name30 = playerName;
            }
            else if (GameType == 15)
            {
                Clicking_game.Properties.Settings.Default.Score15 = score;
                Clicking_game.Properties.Settings.Default.Name15 = playerName;
            }

            Clicking_game.Properties.Settings.Default.Save();
        }

        private void readHighScore()
        {
                highScore60 = Clicking_game.Properties.Settings.Default.Score60;
                highScore30 = Clicking_game.Properties.Settings.Default.Score30;
                highScore15 = Clicking_game.Properties.Settings.Default.Score15;

                top60name = Clicking_game.Properties.Settings.Default.Name60;
                top30name = Clicking_game.Properties.Settings.Default.Name30;
                top15name = Clicking_game.Properties.Settings.Default.Name15;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = timeLeft;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            restart.Visible = false;
            Start.Visible = true;
            record.Visible = false;
            stats.Visible = true;
            label1.Text = "Score:   0";
            groupBox4.Visible = false;
            Start.Enabled = true;
            textBox1.Enabled = true;
            readHighScore();
        }

        private void hiScore_Click(object sender, EventArgs e)
        {
            hiScore.Text = "Best:   " + highScore;
        }

        private void stats_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            stats.Visible = false;
            groupBox3.Visible = true;
            kps.Visible = true;
            Back.Visible = true;
            resetStats.Visible = true;

            if (GameType == 0)
            {
                GameType = 15;
            }

            readHighScore();
            findHighScore();
            findKps();
        }

        private void findKps()
        {
            kps15 = Math.Round((decimal)highScore15 / 15, 3);
            kps30 = Math.Round((decimal)highScore30 / 30, 3);
            kps60 = Math.Round((decimal)highScore60 / 60, 3);
            kpsNow = Math.Round((decimal)score / GameType, 3);

            Kpss15.Text = "Kps15........................................" + kps15;
            Kpss30.Text = "Kps30........................................" + kps30;
            Kpss60.Text = "Kps60........................................" + kps60;
            thisKPS.Text = "KPS:...................." + kpsNow;
            thisScore.Text = "Clicks:................." + score;
            Namelabel.Text = "Name: " + playerName;
        }

        private void findHighScore()
        {
            if (highScore15 >= 100)
            {
                stat15.Text = "15s: " + top15name + "................................" + highScore15;
            }
            else
            {
                stat15.Text = "15s: " + top15name +".................................." + highScore15;
            }
            if (highScore30 >= 100)
            {
                stat30.Text = "30s: " + top30name + "................................" + highScore30;
            }
            else
            {
                stat30.Text = "30s: " + top30name + ".................................." + highScore30;
            }
            if (highScore60 >= 100)
            {
                stat60.Text = "60s: " + top60name + "................................" + highScore60;
            }
            else
            {
                stat60.Text = "60s: " + top60name + ".................................." + highScore60;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Start.Visible = true;
            stats.Visible = true;
            groupBox3.Visible = false;
            Back.Visible = false;
            kps.Visible = false;
            resetStats.Visible = false;
            record.Visible = false;
        }

        private void resetStats_Click(object sender, EventArgs e)
        {
            resetStats.Visible = false;
            Back.Visible = false;
            Yes.Visible = true;
            No.Visible = true;
            check.Visible = true;
        }

        private void No_Click(object sender, EventArgs e)
        {
            resetStats.Visible = true;
            Back.Visible = true;
            Yes.Visible = false;
            No.Visible = false;
            check.Visible = false;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            highScore15 = 0;
            highScore30 = 0;
            highScore60 = 0;
            highScore = 0;
            playerName = "N/A";

            GameType = 60;
            writeHigScore();

            GameType = 30;
            writeHigScore();

            GameType = 15;
            writeHigScore();

            readHighScore();
            findHighScore();
            findKps();

            resetStats.Visible = true;
            Back.Visible = true;
            Yes.Visible = false;
            No.Visible = false;
            check.Visible = false;
        }

        private void SaveName_Click(object sender, EventArgs e)
        {
            playerName = textBox1.Text;

            if (playerName == "N/A")
            {
                textBox1.Text = "AAA";
            }
            else
            {
                textBox1.Enabled = false;
                Start.Enabled = true;
            }
        }
    }
}
