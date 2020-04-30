using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Useless2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            progressBar1.Value = 10;
            int ran = random.Next(1200, 6000);
            progressBar1.Maximum = ran/100;
            timer1.Interval = ran;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum - 1)
            {
                progressBar1.Value = progressBar1.Value + 2;
                progressBar1.Value--;
            }

        }
    }
}
