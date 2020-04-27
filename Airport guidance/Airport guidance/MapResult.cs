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
        public MapResult()
        {
            InitializeComponent();
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            SelectDest open = new SelectDest();
            open.ShowDialog();
            Close();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Password open = new Password();
            open.ShowDialog();
            Close();
        }
    }
}
