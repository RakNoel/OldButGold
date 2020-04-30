using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{

    public partial class Test : Form
    {

        int timeLeft;
        int hours;
        int minutes;
        int seconds;

        public Test()
        {
            InitializeComponent();
        }

        private void EventHandler(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            hours = ((trackBar1.Value / 60) / 60);
            minutes = ((trackBar1.Value / 60) - (hours * 60));
            seconds = (trackBar1.Value - (minutes * 60) - ((hours * 60) * 60));
            label1.Text = "Hours   :  " + hours;
            label2.Text = "Minutes:  " + minutes;
            label3.Text = "Second:  " + seconds;
            timeLeftBar.Value = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hours = ((trackBar1.Value / 60) / 60);
            minutes = ((trackBar1.Value / 60) - (hours * 60));
            seconds = (trackBar1.Value - (minutes * 60) - ((hours * 60) * 60));
            label1.Text = "Hours   :  " + Convert.ToString(hours);
            label2.Text = "Minutes:  " + Convert.ToString(minutes);
            label3.Text = "Second:  " + Convert.ToString(seconds);

            Hitme.Enabled = false;
            trackBar1.Enabled = false;

            Pause.Enabled = true;
            Abort.Enabled = true;
            
            timeLeft = trackBar1.Value;
            timer1.Start();
        }

        private void timeLeft_Click(object sender, EventArgs e)
        {
            
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                hours = ((timeLeft / 60) / 60);
                minutes = ((timeLeft / 60) - (hours * 60));
                seconds = (timeLeft - (minutes * 60) - ((hours * 60) * 60));

                timeLeftBar.Value = --timeLeft;
                label1.Text = "Hours   :  " + Convert.ToString(hours);
                label2.Text = "Minutes:  " + Convert.ToString(minutes);
                label3.Text = "Second:  " + Convert.ToString(seconds);
            }
            else
            {
                timer1.Stop();
                Process.Start("shutdown", "/s /t 0");

                Pause.Enabled = false;
                Abort.Enabled = false;

                Hitme.Enabled = true;
                trackBar1.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Pause.Visible = false;
            Abort.Visible = false;
            returner.Visible = true;
        }

        private void returner_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Pause.Visible = true;
            Abort.Visible = true;
            returner.Visible = false;
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Hitme.Enabled = true;
            trackBar1.Enabled = true;

            Pause.Enabled = false;
            Abort.Enabled = false;
        }

        private void Countdown_Click(object sender, EventArgs e)
        {
        }

    }
}
