using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treetest
{
    public partial class frmPackages : Form
    {
        public frmPackages()
        {
            InitializeComponent();
        }

        private void btnProdSup_Click(object sender, EventArgs e)
        {
            Product_Supliers formObj = new Product_Supliers();
            formObj.ShowDialog();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            int pkgId;
            string pkgName;
             DateTime strDate = Convert.ToDateTime(pkgStartDate.Text);
             DateTime endDate = Convert.ToDateTime(pkgEndigDate.Text);
            string pkgDescription;
            decimal pkgBasePrice;
            decimal pkgAgencyComm;

            if (validateClass.isProvided(txtPackageId, "Package Id can not be null")
                && validateClass.isNonNegativeInt(txtPackageId, "Package Id must be Positive Int")
                && (validateClass.isProvided(txtPackageName, "Package Name can not be null"))
                && (validateClass.validateDate(strDate,endDate))
                &&(validateClass.isProvided(txtPkgDescription,"Package Description can not be null"))
                && (validateClass.isProvided(txtPkgBasePrice, "Package Base Price can not be null"))
                &&(validateClass.isNonNegativeDoub(txtPkgBasePrice,"Package Price must be a Positive Whole number"))
                &&(validateClass.isProvided(txtAgencyComm,"Agency Comm can not be null"))
                &&(validateClass.isNonNegativeDoub(txtAgencyComm,"Agency Comm must be a positive whole number"))
                )
               // validateClass.validateDate(strDate, endDate))
            {
                pkgId = Convert.ToInt32(txtPackageId.Text);
                pkgName = txtPackageName.Text;
                pkgDescription = txtPkgDescription.Text;
                pkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                pkgAgencyComm = Convert.ToDecimal(txtAgencyComm.Text);
                AddPackage pkgObj = new AddPackage();

                string sql = "INSERT INTO packages(PackageId,PkgName,PkgStartDate,PkgEndDate,PkgDesc,PkgBasePrice,PkgAgencyCommission) " +
                    "VALUES ('" + pkgId + "','" + pkgName + "','" + strDate + "','" + endDate + "','" + pkgDescription + "','" + pkgBasePrice + "','" + pkgAgencyComm + "')";
                if (pkgObj.AddRecord(sql))
                {
                    MessageBox.Show("Package Created Successfully");
                    string query = "select * from packages";
                    if (pkgObj.FillDataGrid(query))
                    {
                        pkgGridView.DataSource = pkgObj.dt;
                    }
                }
            }

          
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            myConn pkgObjDataGrid = new myConn();
            string query = "select * from packages";
            if (pkgObjDataGrid.FillDataGrid(query))
            {
                pkgGridView.DataSource = pkgObjDataGrid.dt;
            }

            query = "select prodName from products";
            if (pkgObjDataGrid.FetchData(query))
            {
                while (pkgObjDataGrid.dataReader.Read())
                {
                    cmbProducts.Items.Add(Convert.ToString(pkgObjDataGrid.dataReader.GetValue(0)));
                }
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            myConn objAddSupplier = new myConn();
            lstSuppliers.Items.Clear();
            string query="select SupName from products,products_suppliers,suppliers where suppliers.SupplierId=products_suppliers.SupplierId and products.ProductId=products_suppliers.ProductId and prodName='" +cmbProducts.Text + "'";
            if (objAddSupplier.FetchData(query))
            {
                while (objAddSupplier.dataReader.Read())
                {
                    lstSuppliers.Items.Add(objAddSupplier.dataReader.GetValue(0));
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int getSupplierId=0;
            int getProductId=0;
            int getProductSupplierId=0;
            int pkgId = 0;
           int getPkgId =0;
            
            myConn objGetProductSuppId = new myConn();
            string query = "select SupplierId from suppliers where SupName='" + lstSuppliers.Text + "'";
            if (objGetProductSuppId.FetchData(query))
            {
                while (objGetProductSuppId.dataReader.Read())
                {
                    getSupplierId = Convert.ToInt32(objGetProductSuppId.dataReader.GetValue(0));

                }

                //MessageBox.Show(Convert.ToString(getSupplierId));
            }

            query="select ProductId from products where ProdName='"+cmbProducts.Text+"'";

            if (objGetProductSuppId.FetchData(query))
            {
                while (objGetProductSuppId.dataReader.Read())
                {
                    getProductId = Convert.ToInt32(objGetProductSuppId.dataReader.GetValue(0));

                }

               // MessageBox.Show(Convert.ToString(getProductId));
            }

            query = "select ProductSupplierId from products_suppliers where ProductId='" + getProductId + "'" +
                "and SupplierId='" + getSupplierId + "'";

            if (objGetProductSuppId.FetchData(query))
            {
                while (objGetProductSuppId.dataReader.Read())
                {
                    getProductSupplierId = Convert.ToInt32(objGetProductSuppId.dataReader.GetValue(0));

                }

                 MessageBox.Show(Convert.ToString(getProductSupplierId));
            }

            if (pkgGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = pkgGridView.Rows[selectedrowindex];

                 getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);


            }

            query = "insert into packages_products_suppliers values('" + getPkgId+ "'," + "'" + getProductSupplierId + "'" + ")";

            if (objGetProductSuppId.AddRecord(query))
            {
                MessageBox.Show("Added");
            }

            query= "SELECT prodName,SupName from products,suppliers where products.ProductId='"+getProductId+"'"+" and suppliers.SupplierId='"+getSupplierId+"'";
            if (objGetProductSuppId.FillDataGrid(query))
            {
                pkgProductGrid.DataSource = objGetProductSuppId.dt;
            }


        }

        private void pkgGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Changed");
        }

        private void pkgGridView_Click(object sender, EventArgs e)
        {
            int getPkgId = 0;
             int getProductSupplierId=0;
            int count = 0;
            if (pkgGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = pkgGridView.Rows[selectedrowindex];

                getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);


            }
            myConn objGetProductsIntoGrid = new myConn();
            string query = "select ProductSupplierId from packages_products_suppliers where PackageId='" + getPkgId + "'";
            if (objGetProductsIntoGrid.FetchData(query))
            {
                while (objGetProductsIntoGrid.dataReader.Read())
                {
                    getProductSupplierId = Convert.ToInt32(objGetProductsIntoGrid.dataReader.GetValue(0));
                   MessageBox.Show(Convert.ToString(getProductSupplierId));
                    
              

                }
                // pkgProductGrid.DataSource = objGetProductsIntoGrid.dt;

            }

            

        }

        private void btnAddPackage_Click_1(object sender, EventArgs e)
        {
            int pkgId;
            string pkgName;
            DateTime strDate = Convert.ToDateTime(pkgStartDate.Text);
            DateTime endDate = Convert.ToDateTime(pkgEndigDate.Text);
            string pkgDescription;
            decimal pkgBasePrice;
            decimal pkgAgencyComm;

            if (validateClass.isProvided(txtPackageId, "Package Id can not be null")
                && validateClass.isNonNegativeInt(txtPackageId, "Package Id must be Positive Int")
                && (validateClass.isProvided(txtPackageName, "Package Name can not be null"))
                && (validateClass.validateDate(strDate, endDate))
                && (validateClass.isProvided(txtPkgDescription, "Package Description can not be null"))
                && (validateClass.isProvided(txtPkgBasePrice, "Package Base Price can not be null"))
                && (validateClass.isNonNegativeDoub(txtPkgBasePrice, "Package Price must be a Positive Whole number"))
                && (validateClass.isProvided(txtAgencyComm, "Agency Comm can not be null"))
                && (validateClass.isNonNegativeDoub(txtAgencyComm, "Agency Comm must be a positive whole number"))
                )
            // validateClass.validateDate(strDate, endDate))
            {
                pkgId = Convert.ToInt32(txtPackageId.Text);
                pkgName = txtPackageName.Text;
                pkgDescription = txtPkgDescription.Text;
                pkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                pkgAgencyComm = Convert.ToDecimal(txtAgencyComm.Text);
                AddPackage pkgObj = new AddPackage();

                string sql = "INSERT INTO packages(PackageId,PkgName,PkgStartDate,PkgEndDate,PkgDesc,PkgBasePrice,PkgAgencyCommission) " +
                    "VALUES ('" + pkgId + "','" + pkgName + "','" + strDate + "','" + endDate + "','" + pkgDescription + "','" + pkgBasePrice + "','" + pkgAgencyComm + "')";
                if (pkgObj.AddRecord(sql))
                {
                    MessageBox.Show("Package Created Successfully");
                    string query = "select * from packages";
                    if (pkgObj.FillDataGrid(query))
                    {
                        pkgGridView.DataSource = pkgObj.dt;
                    }
                }
            }
        }
    }
}
