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
    public partial class SelectDest : Form
    {
        DateTime idleTimer;
        public SelectDest()
        {
            InitializeComponent();
        }


        private void btnGate_Click(object sender, EventArgs e)
        {
            Gate open = new Gate();
            open.ShowDialog();
            
        }

        private void btnRestroom_Click(object sender, EventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            MapResult open = new MapResult();
            open.ShowDialog();
            Close();
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {

        }

        private void SelectDest_Load(object sender, EventArgs e)
        {
            idleTimer = DateTime.Now;
            timer1.Start();
            timer1.Interval = 5000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime checkTime = DateTime.Now;
            TimeSpan span = checkTime.Subtract(idleTimer);
            if (span.Seconds > 20)
            {
                MapWindow open = new MapWindow();
                timer1.Stop();
                open.ShowDialog();
                Close();
                Dispose(true);
            }
        }

       

        private void SelectDest_MouseMove(object sender, MouseEventArgs e)
        {
            idleTimer = DateTime.Now;
        }
    }
}
