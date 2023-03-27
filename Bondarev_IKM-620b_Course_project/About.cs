using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondarev_IKM_620b_Course_project
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void tAbout_Tick(object sender, EventArgs e)
        {
            tAbout.Stop();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            tAbout.Start();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LbIAndProject_Click(object sender, EventArgs e)
        {

        }
    }
}
