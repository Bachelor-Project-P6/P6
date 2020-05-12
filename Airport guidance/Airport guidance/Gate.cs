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
            Destinations.Dest.Enqueue("Gate 1");
        }

        private void btnGate2_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 2");
        }

        private void btnGate3_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 3");
        }

        private void btnGate4_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 4");
        }

        private void btnGate5_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 5");
        }

        private void btnGate6_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 6");
        }

        private void btnGate7_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 7");
        }

        private void btnGate8_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 8");
        }

        private void btnGate9_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 9");
        }

        private void btnGate10_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 10");
        }

        private void btnGate11_Click(object sender, EventArgs e)
        {
            Destinations.Dest.Enqueue("Gate 11");
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
