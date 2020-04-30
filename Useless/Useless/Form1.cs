using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Useless
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Public variables
        bool paint = false;
        Color color = Color.Black;
        SolidBrush brush;
        Graphics graphics;
        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorPreview.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            brush = new SolidBrush(ColorPreview.BackColor);
            graphics = drawingPanel.CreateGraphics();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                ColorPreview.BackColor = color;
                brush = new SolidBrush(color);
                ColorPreview.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                brush = new SolidBrush(ColorPreview.BackColor);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawingPanel.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            timer2.Start();
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            timer1.Start();
        }

        private void drawingPanel_Move(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                graphics.FillEllipse(brush, e.X + random.Next(0, 3), e.Y + random.Next(0, 3), trackBar1.Value, trackBar2.Value);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            drawingPanel.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            ColorPreview.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            brush = new SolidBrush(ColorPreview.BackColor);
        }
    }
}
