using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chemistry_Calculator;

namespace Kjemi_kalkulator
{
    public partial class Form1 : Form
    {
        private decimal n, m, Mm, v, Vm, c, d;
        public bool noN, noM, noMm, noV, noVm, noC, noD;

        public Form1()
        {
            InitializeComponent();
        }


        private void getValues()
        {
            n = numericUpDown1.Value;
            m = numericUpDown2.Value;
            Mm = numericUpDown3.Value;
            v = numericUpDown4.Value;
            Vm = numericUpDown5.Value;
            c = numericUpDown6.Value;
            d = numericUpDown7.Value;
        }
        private void getStatements()
        {
            noN = n <= 0;
            noM = m <= 0;
            noMm = Mm <= 0;
            noV = v <= 0;
            noVm = Vm <= 0;
            noC = c <= 0;
            noD = d <= 0;
        }

        private void calculatieVariables()
        {
            //find Amount-of-substance
            if (noN & !noM & !noMm) { n = m / Mm; }
            if (noN & !noV & !noVm) { n = v / Vm; }
            if (noN & !noC & !noV) { n = c * v; }

            getStatements();

            //find Volume
            if (noV & !noN & !noVm) { v = n * Vm; }
            if (noV & !noC & !noN) { v = n / c; }
            if (noV & !noD & !noM) { v = m / d; }

            getStatements();

            //find Mass
            if (noM & !noN & !noMm) { m = n * Mm; }
            if (noM & !noD & !noV) { m = v * d; }

            getStatements();

            //find Molar-mass
            if (noMm & !noN & !noM) { Mm = m / n; }

            getStatements();

            //find Molar-volume
            if (noVm & !noV & !noN) { Vm = v / n; }

            getStatements();

            //find Consentration
            if (noC & !noN & !noV) { c = n / v; }

            getStatements();

            //find Dencity
            if (noD & !noV & !noM) { d = m / v; }

            getStatements();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getValues();
            getStatements();

            int i = 0;
            while (i < 3) { calculatieVariables(); i++; }

            numericUpDown1.Value = n;
            numericUpDown2.Value = m;
            numericUpDown3.Value = Mm;
            numericUpDown4.Value = v;
            numericUpDown5.Value = Vm;
            numericUpDown6.Value = c;
            numericUpDown7.Value = d;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = n = 0;
            numericUpDown2.Value = m = 0;
            numericUpDown3.Value = Mm = 0;
            numericUpDown4.Value = v = 0;
            numericUpDown5.Value = Vm = 0;
            numericUpDown6.Value = c = 0;
            numericUpDown7.Value = d = 0;
        }

        private void hexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Hexadecimal)
            {
                numericUpDown1.Hexadecimal = false;
                numericUpDown2.Hexadecimal = false;
                numericUpDown3.Hexadecimal = false;
                numericUpDown4.Hexadecimal = false;
                numericUpDown5.Hexadecimal = false;
                numericUpDown6.Hexadecimal = false;
            }
            else
            {
                numericUpDown1.Hexadecimal = true;
                numericUpDown2.Hexadecimal = true;
                numericUpDown3.Hexadecimal = true;
                numericUpDown4.Hexadecimal = true;
                numericUpDown5.Hexadecimal = true;
                numericUpDown6.Hexadecimal = true;
            }
        }

        private void thousandSeperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.ThousandsSeparator)
            {
                numericUpDown1.ThousandsSeparator = false;
                numericUpDown2.ThousandsSeparator = false;
                numericUpDown3.ThousandsSeparator = false;
                numericUpDown4.ThousandsSeparator = false;
                numericUpDown5.ThousandsSeparator = false;
                numericUpDown6.ThousandsSeparator = false;
                numericUpDown7.ThousandsSeparator = false;
            }
            else
            {
                numericUpDown1.ThousandsSeparator = true;
                numericUpDown2.ThousandsSeparator = true;
                numericUpDown3.ThousandsSeparator = true;
                numericUpDown4.ThousandsSeparator = true;
                numericUpDown5.ThousandsSeparator = true;
                numericUpDown6.ThousandsSeparator = true;
                numericUpDown7.ThousandsSeparator = false;
            }
        }

        private void decimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimalsToolStripMenuItem1.Checked = false;
            toolStripMenuItem2.Checked = false;

            numericUpDown1.DecimalPlaces = 3;
            numericUpDown2.DecimalPlaces = 3;
            numericUpDown3.DecimalPlaces = 3;
            numericUpDown4.DecimalPlaces = 3;
            numericUpDown5.DecimalPlaces = 3;
            numericUpDown6.DecimalPlaces = 3;
            numericUpDown7.DecimalPlaces = 3;
        }

        private void decimalsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            decimalsToolStripMenuItem.Checked = false;
            toolStripMenuItem2.Checked = false;

            numericUpDown1.DecimalPlaces = 5;
            numericUpDown2.DecimalPlaces = 5;
            numericUpDown3.DecimalPlaces = 5;
            numericUpDown4.DecimalPlaces = 5;
            numericUpDown5.DecimalPlaces = 5;
            numericUpDown6.DecimalPlaces = 5;
            numericUpDown7.DecimalPlaces = 5;
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            decimalsToolStripMenuItem.Checked = false;
            decimalsToolStripMenuItem1.Checked = false;

            numericUpDown1.DecimalPlaces = 10;
            numericUpDown2.DecimalPlaces = 10;
            numericUpDown3.DecimalPlaces = 10;
            numericUpDown4.DecimalPlaces = 10;
            numericUpDown5.DecimalPlaces = 10;
            numericUpDown6.DecimalPlaces = 10;
            numericUpDown7.DecimalPlaces = 10;
        }

        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Amount of substance")
            {
                label1.Text = "mol";
                label2.Text = "g";
                label3.Text = "g/mol";
                label4.Text = "L";
                label5.Text = "L/mol";
                label6.Text = "mol/L";
                label8.Text = "mg/L";
            }
            else
            {
                label1.Text = "Amount of substance";
                label2.Text = "Mass";
                label3.Text = "Molar mass";
                label4.Text = "Volume";
                label5.Text = "Molar volume";
                label6.Text = "Concentration";
                label8.Text = "Dencity";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.ShowDialog(); // Shows About / Help
        }

        private void dilutionCalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(); // Shows the dilution calculator
            f2.Location = new Point(this.Left + this.Width, this.Top);
        }
    }
}
