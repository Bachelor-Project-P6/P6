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
    public partial class Password : Form
    {
        DateTime idleTimer;

        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            idleTimer = DateTime.Now;
            timer1.Start();
            timer1.Interval = 5000;
        }
        private void txtPasswordbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void key1_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "1";
        }

        private void key2_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "2";
        }

        private void key3_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "3";
        }

        private void key4_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "4";
        }

        private void key5_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "5";
        }

        private void key6_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "6";
        }

        private void key7_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "7";
        }

        private void key8_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "8";
        }

        private void key9_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "9";
        }

        private void key0_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "10";
        }

        private void keyQ_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "Q";
        }

        private void keyW_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "W";
        }

        private void keyE_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "E";
        }

        private void keyR_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "R";
        }

        private void keyT_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "T";
        }

        private void keyY_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "Y";
        }

        private void keyU_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "U";
        }

        private void keyI_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "I";
        }

        private void keyO_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "O";
        }

        private void keyP_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "P";
        }

        private void keyA_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "A";
        }

        private void keyS_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "S";
        }

        private void keyD_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "D";
        }

        private void keyF_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "F";
        }

        private void keyG_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "G";
        }

        private void keyH_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "H";
        }

        private void keyJ_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "J";
        }

        private void keyK_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "K";
        }

        private void keyL_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "L";
        }

        private void keyZ_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "Z";
        }

        private void keyX_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "X";
        }

        private void keyC_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "C";
        }

        private void keyV_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "V";
        }

        private void keyB_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "B";
        }

        private void keyN_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "N";
        }

        private void keyM_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text += "M";
        }

        private void keyBack_Click(object sender, EventArgs e)
        {
            txtPasswordbox.Text = txtPasswordbox.Text.Remove(txtPasswordbox.Text.Length - 1);

        }

        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            if (txtPasswordbox.Text == "TEMPPASS")
            {
                SetLocationMap open = new SetLocationMap();
                open.ShowDialog();
                Close();
            }
            else
            {
                BadPassword open = new BadPassword();
                open.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MapWindow open = new MapWindow();
            open.ShowDialog();
            Close();
        }
        private void Password_MouseMove(object sender, MouseEventArgs e)
        {
            idleTimer = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime checkTime = DateTime.Now;
            TimeSpan span = checkTime.Subtract(idleTimer);
            if (span.Seconds > 10)
            {
                MapWindow open = new MapWindow();
                timer1.Stop();
                open.ShowDialog();
                Close();
                Dispose(true);
            }

        
    }
    }
}





