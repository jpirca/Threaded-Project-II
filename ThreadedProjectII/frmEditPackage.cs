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
    public partial class frmEditPackage : Form
    {
        public frmEditPackage()
        {
            InitializeComponent();
        }

        private void btnNextPkg_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPackage form1 = new frmPackage();
            form1.Show();

        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
