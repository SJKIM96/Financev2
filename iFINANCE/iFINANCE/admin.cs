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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void manageAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doubleEntryBookeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            About _about = new About();
            _about.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
