using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemTrial
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form uc =UserAccount.getInstance();
            uc.MdiParent = this;
            uc.Show();
        }
    }
}
