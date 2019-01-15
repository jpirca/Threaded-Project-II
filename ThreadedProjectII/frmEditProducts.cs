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
    public partial class frmEditProducts : Form
    {
        public frmEditProducts()
        {
            InitializeComponent();
        }

        private void btnNextPkg_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProducts form1 = new frmProducts();
            form1.Show();
            form1.Activate();
        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditProducts_Load(object sender, EventArgs e)
        {
            //Display all Products

            ProductADO productList = new ProductADO();
            Console.WriteLine(productList);

            //foreach (Product perProduct in productList)
            //{

            //}
        }
    }
}
