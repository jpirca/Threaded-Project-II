﻿using System;
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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void btnNextSup_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSuppliersComfirmation form1 = new frmSuppliersComfirmation();
            form1.Show();
            form1.Activate();
        }
    }
}