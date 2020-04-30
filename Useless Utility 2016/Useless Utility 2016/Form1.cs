using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Useless_Utility_2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            output_label.Text = "";
        }

        Random rnd = new Random();
        int MaxBar = 600+1;
        int MinBar = 50;
        public bool working = false;
        int chance = 700;

        string[] prefix = {
                              "Initilizing", "Booting", "Uppdating", "Removing", "Deleting","Computing","Rendering","Adding","Divinding","Multiplying",
                              "Dumping", "Pawning", "Calculating", "Quantifying", "Connecting", "Globalizing", "Visiulizing", "Buying", "Using",
                              "Resurecting", "Animating", "Constructing", "Drawing", "Voidifying", "Monitoring", "Switching", "Activating",
                              "De-activating", "Producing", "Randomizing", "Analyzing", "Transforming", "Mirroring", "Compenzating", "Composing",
                              "Exiting", "Overriding", "Compiling", "De-Compiling", "Enabling", "Disabling", "Transmitting", "Injecting", "Refreshing",
                              "Discombobulating"
                          };

        string[] middle = { 
                              "temporary ", "quantom ", "viritual ", "solid state ", "random ", "basic ", "global ", "protected ", "hidden ", "optical ",
                              "primary ", "", "linear ", "compact ", "power ", "3D ", "", "digital ", "analog ", "", "2 dimentional ", "stereoscopic ",
                              "HTTP ", "HTTPS ", "default ", "new ", "optical ", "SMTP "
                          };

        string[] suffix = {
                              "firewall", "OS", "ASCII", "harddrive", "prefixes", "vektors", "parameters", "mainframe", "GUI", "SQL", "XML circuit",
                              "drivers", "DNS", "IP adress", "MAC adress", "wireless matrix", "BIOS", "the Internet", "atomic variables", "frequency",
                              "gluon strings", "quantom bits", "properties", "assets", "RAM", "files", "XHTML bus", "monitor", 
                              "RSS array", "USB - ports", "CPU", "GPU", "PSU", "malware", "viruses", "LUT - setup", "MACRO", "frame window",
                              "audio files", "helpers", "particle flow", "deflectors", "fields", "offsets", "settings", "time-date-format", "hardware",
                              "display", "features", "SLI", "Crossfire", "BUS-es", "information", "archives", "backup", "sites", "capasitors", "pixels",
                              "geometry", "array"
                          };

        public void btn_start_Click(object sender, EventArgs e)
        {
            timer2.Start();
            btn_start.Enabled = false;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                working = false;
                timer2.Start();
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int bar_lenght = rnd.Next(MinBar, MaxBar);

            progressBar1.Maximum = bar_lenght;
            progressBar1.Value = 0;

            output_label.Text = prefix[rnd.Next(0, prefix.Length)] + " " + middle[rnd.Next(0, middle.Length)] + suffix[rnd.Next(0, suffix.Length)];

            if (rnd.Next(0, 1000) > chance)
            {
                System.Diagnostics.Process.Start("CMD.exe", "/C");
            }

            timer1.Start();
            timer2.Stop();
            working = true;
        }
    }

        
}
