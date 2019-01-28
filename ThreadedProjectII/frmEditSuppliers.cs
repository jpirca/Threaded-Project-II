using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadedProjectLib;

namespace ThreadedProjectII
{
    public partial class frmEditSuppliers : Form
    {
        public frmEditSuppliers()
        {
            InitializeComponent();
            SupplierDB supADO = new SupplierDB();
            List<Supplier> suppliers = supADO.GetSuppliers();
            this.listBox1.Items.Clear();
            this.listBox1.DataSource = suppliers;
        }

        private void btnNextPkg_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSuppliers form1 = new frmSuppliers();
            form1.setEditedSupplier((Supplier)this.listBox1.SelectedItem);
            form1.Show();
            form1.Activate();
        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
