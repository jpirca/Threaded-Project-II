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
    public partial class frmPackage : Form
    {
        public frmPackage()
        {
            InitializeComponent();
        }

        // User pressed OK during step 1 for adding packages
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPkgConfirmation form1 = new frmPkgConfirmation();
            form1.Activate();
            form1.Show();
        }

        // User pressed CANCEL during step 1 for adding packages
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel?", "Adding \"Packages\"", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
