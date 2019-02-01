using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Threaded_ProjectLib;

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
            AgentDB agentDB = new AgentDB();
            //example
            //usernmae = janet.delton@travelexperts.com
            string passsword = "abcd1234";
            //HashSalt hashy = new HashSalt();
            AgentDB.GenerateSaltedHash(passsword);
            
            result = agentDB.AgentLogin(new Agent(emailLogin.Text, passwordLogin.Text));

            if (result)
            {
                //Open dashboard and close this form 
                MessageBox.Show("Successfully Logged in");
            }
            else {
                MessageBox.Show("Your email or Password is wrong");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            passwordLogin.PasswordChar = '*';
        }
    }
}
