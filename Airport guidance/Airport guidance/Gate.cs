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
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate2_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate3_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate4_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate5_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate6_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate7_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate8_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate9_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate10_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnGate11_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectDest open = new SelectDest();
            open.ShowDialog();
            Close();
        }
    }
}
