using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapWinGIS;

namespace Airport_guidance
{

    public partial class SetLocationMap : Form
    {
        //Will probably be converted to a cell value of the vertex.
        public static int Loc = 370;
        DateTime idleTimer;
        public SetLocationMap()
        {
            InitializeComponent();
        }

        private void btnCancelNode_Click(object sender, EventArgs e)
        {
            MapWindow open = new MapWindow();
            Destinations.Dest.Clear();
            open.ShowDialog();
            Close();
        }
        private void SetLocationMap_Load(object sender, EventArgs e)
        {
            idleTimer = DateTime.Now;
            Timer1.Start();
            Timer1.Interval = 5000;
        }
        

        private void SetLocationMap_MouseMove(object sender, MouseEventArgs e)
        {
            idleTimer = DateTime.Now;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime checkTime = DateTime.Now;
            TimeSpan span = checkTime.Subtract(idleTimer);
            if (span.Seconds > 30)
            {
                MapWindow open = new MapWindow();
                Timer1.Stop();
                open.ShowDialog();
                Destinations.Dest.Clear();
                Close();
                Dispose(true);
            }
        }


    }
}
