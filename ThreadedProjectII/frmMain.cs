using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectII
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.IsMdiContainer = true;
            frmLogin Form1 = new frmLogin();
            Form1.MdiParent = this;
            //Form2.Enabled = true;
            //Form2.BringToFront();
            menuMain.Enabled = false;
            Form1.Show();
            Form1.Activate();
        }
    }
}
