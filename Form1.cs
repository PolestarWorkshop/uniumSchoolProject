using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
		        public class RAM
        {
            public string type;
            public float frequency;
        }
        public class Processor
        {
            public string brend;
            public float frequency;
            public string socket;
            public string threads;
            public string cores;
        }
        public class Motherboard
        {
            public string brend;
            public string memoryslots;
            public string socket;
        }
        public class Videocard
        {
            public float memory;
            public string type;
            public string GPU;
        }
		
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
