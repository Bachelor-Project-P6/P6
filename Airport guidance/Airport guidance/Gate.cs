using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_guidance
{
    public partial class Gate : Form
    {
        public Gate()
        {
            InitializeComponent();
        }

        private void btnGate1_Click(object sender, EventArgs e)
        {
            //The button adds to the queue "stops" through the constructor "Dest" in the class "Destionations".
            Destinations.Dest.Enqueue("gate 1");
        }

        private void btnGate2_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 2");
        }

        private void btnGate3_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 3");
        }

        private void btnGate4_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 4");
        }

        private void btnGate5_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 5");
        }

        private void btnGate6_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 6");
        }

        private void btnGate7_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 7");
        }

        private void btnGate8_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 8");
        }

        private void btnGate9_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 9");
        }

        private void btnGate10_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 10");
        }

        private void btnGate11_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("gate 11");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Gate_Load(object sender, EventArgs e)
        {

        }
    }
}
