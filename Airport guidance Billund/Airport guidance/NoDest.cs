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
    public partial class NoDest : Form
    {
        public NoDest()
        {
            InitializeComponent();
        }

        private void nodestokay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NoDest_Load(object sender, EventArgs e)
        {

        }
    }
}
