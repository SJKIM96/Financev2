using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace iFINANCE
{
    public partial class iFINANCE : Form
    {
        public iFINANCE()
        {

            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About _about = new About();
            _about.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void financialReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financial_Report _report = new Financial_Report();
            _report.MdiParent = this;
            _report.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void a1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
