using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistry_Calculator
{
    public partial class Form2 : Form
    {
        private decimal C1, C2, V1, V2;
        public bool nC1, nC2, nV1, nV2;

        public Form2()
        {
            InitializeComponent();
        }

        private void getValues()
        {
            C1 = numericUpDown1.Value;
            C2 = numericUpDown3.Value;
            V1 = numericUpDown2.Value;
            V2 = numericUpDown4.Value;
        }

        private void getStatement()
        {
            nC1 = C1 <= 0;
            nC2 = C2 <= 0;
            nV1 = V1 <= 0;
            nV2 = V2 <= 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getValues();
            getStatement();

            if (nV1 & !nV2 & !nC1 & !nC2) { V1 = (C2 * V2) / C1; }
            if (nV2 & !nV1 & !nC1 & !nC2) { V2 = (C1 * V1) / C2; }
            if (nC1 & !nV2 & !nV1 & !nC2) { C1 = (C2 * V2) / V1; }
            if (nC2 & !nV2 & !nC1 & !nV1) { C2 = (C1 * V1) / V2; }

            numericUpDown1.Value = C1;
            numericUpDown3.Value = C2;
            numericUpDown2.Value = V1;
            numericUpDown4.Value = V2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = C1 = 0;
            numericUpDown3.Value = C2 = 0;
            numericUpDown2.Value = V1 = 0;
            numericUpDown4.Value = V2 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
