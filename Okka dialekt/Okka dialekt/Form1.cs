using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okka_dialekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap dest = new Bitmap(Properties.Resources.Normal_B);
        private void button1_Click(object sender, EventArgs e)
        {
            //Infinitiv
            //--------------------------------------------------------------------------------------
            if (radioButton1.Checked)
            {

            }
            else if(radioButton2.Checked)
            {

            }

            //Personlig Pron 1-Pers
            //--------------------------------------------------------------------------------------
            if (radioButton5.Checked)
            {

            }
            else if (radioButton6.Checked)
            {

            }

            //Personlig Pron 2-Pers
            //--------------------------------------------------------------------------------------
            if (radioButton9.Checked)
            {

            }
            else if (radioButton10.Checked)
            {

            }
            else if (radioButton11.Checked)
            {

            }

            //Nektningsadverb
            //--------------------------------------------------------------------------------------
            if (radioButton12.Checked)
            {

            }
            else if (radioButton13.Checked)
            {

            }

            //Special
            //--------------------------------------------------------------------------------------
            if (konsonantChck.Checked)
            {
                compareimages(dest, Properties.Resources.Konsonant);
            }
            if (hoytoneChck.Checked)
            {
                compareimages(dest, Properties.Resources.Hoytone);
            }
            if (skarreChck.Checked)
            {
                compareimages(dest, Properties.Resources.Skarre);
            }
            if (palataliseringChck.Checked)
            {
                compareimages(dest, Properties.Resources.Palatalisering);
            }
            if (tjukkLShc.Checked)
            {
                compareimages(dest, Properties.Resources.tjukk_L);
            }

            //Diable button not to duplicate pictures and draw anyways.
            button1.Enabled = false;
        }

        public void compareimages(Bitmap src, Bitmap comp)
        {
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color pix1 = src.GetPixel(x, y);
                    if (pix1 != null)
                    {
                        Color pix2 = comp.GetPixel(x, y);

                        if (pix1 == pix2 && pix1 == Color.FromArgb(0, 0, 255))
                        {
                            dest.SetPixel(x, y, pix1);
                        }

                        else if (pix1 == Color.Magenta | pix2 == Color.FromArgb(255, 0, 255))
                        {
                            dest.SetPixel(x, y, Color.FromArgb(255, 0, 255));
                        }
                    }
                }
            }
            pictureBox1.Image = dest;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            pictureBox1.Image = (Properties.Resources.Normal);
            dest = (Properties.Resources.Normal_B);
        }
    }
}
