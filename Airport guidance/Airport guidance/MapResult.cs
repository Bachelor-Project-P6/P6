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
    public partial class MapResult : Form
    {
        DateTime idleTimer;
        public MapResult()
        {
            InitializeComponent();
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            SelectDest open = new SelectDest();
            Destinations.Dest.Clear();
            open.ShowDialog();
            timer1.Stop();
            open.ShowDialog();
            Close();
            Dispose(true);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Password open = new Password();
            Destinations.Dest.Clear();
            open.ShowDialog();
            timer1.Stop();
            open.ShowDialog();
            Close();
            Dispose(true);
        }

        private void MapResult_Load(object sender, EventArgs e)
        {
            idleTimer = DateTime.Now;
            timer1.Start();
            timer1.Interval = 5000;

        }

        private void MapResult_MouseMove(object sender, MouseEventArgs e)
        {
            idleTimer = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime checkTime = DateTime.Now;
            TimeSpan span = checkTime.Subtract(idleTimer);
            if (span.Seconds > 20)
            {
                MapWindow open = new MapWindow();
                timer1.Stop();
                Destinations.Dest.Clear();
                open.ShowDialog();
                Close();
                Dispose(true);
            }
        }

        

        
    }
}
