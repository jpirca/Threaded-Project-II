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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        // Method to verify agent login
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool result = false;

            // Harcord to always login
            result = true;

            //result = AgentLogin(userId,userPassword)

            if (result)
            {
                this.Close();
 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
