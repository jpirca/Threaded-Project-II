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
    public partial class Product_Supliers : Form
    {
        public Product_Supliers()
        {
            InitializeComponent();
        }
        List<string> productName = new List<string>();
        string returnedProductName;
        string returnedSupName;
        string returnedSupId;
        string returnedProdId;
        string returnedSupplier_SupId;
        private void button1_Click(object sender, EventArgs e)
        {
            List<CheckBox> CheckBoxes = new List<CheckBox>();

            int intialTop = 50;
            //string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < 4; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Top = intialTop;
                chk.Left = 50;
                chk.Text = "CheckBox Test" + i;
                chk.Name = "chkTest" + i;
                chk.CheckedChanged += new EventHandler(chk_checked);
                this.Controls.Add(chk);
                CheckBoxes.Add(chk);

                intialTop += 20;
            }

        }

        public void chk_checked(object sender, EventArgs e)
        {
            MessageBox.Show("Clcicked");
        }

        public void criarCheckBox(String nome, String texto)
        {

            List<CheckBox> listaCheckBox = new List<CheckBox>();
            int intialTop = 50;
            for (int i = 0; i < 3; i++)
            {
                CheckBox box = new CheckBox();
                box.Top = intialTop;
                box.Left = 50;
                box.Name = nome + i;
                box.Text = texto + i;
                listaCheckBox.Add(box);
                box.CheckedChanged += new EventHandler(checkBoxClick);
                this.Controls.Add(box);
                intialTop += 40;
            }
        }
        void checkBoxClick(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            //  checkBox.Text = "Hello";
            // MessageBox.Show(Convert.ToString(checkBox.Name));
            var chkName = checkBox.Name;
            if (chkName == "Air0")
            {
                MessageBox.Show("Air 0 is called" + checkBox.Location);
                // List<CheckBox> listaCheckBox = new List<CheckBox>();
                int intialTop = 50;
                int initialLeft = 200;
                for (int i = 0; i <= 2; i++)
                {
                    RadioButton rdo = new RadioButton();
                    rdo.Name = "RadioButton" + i;
                    rdo.Text = "Radio Button " + i;

                    //   rdo.Location = new Point(20,50+i);
                    rdo.Left = initialLeft;
                    rdo.Top = 50;
                    rdo.CheckedChanged += new EventHandler(RadioButtonEvent);
                    this.Controls.Add(rdo);
                    MessageBox.Show(Convert.ToString(initialLeft));
                    initialLeft += 150;

                }
            }
            if (chkName == "Air1")
            {

                MessageBox.Show("Air 1 is called" + checkBox.Location);
                int intialTop = 50;
                int initialLeft = 200;
                for (int i = 0; i <= 2; i++)
                {
                    RadioButton rdo = new RadioButton();
                    rdo.Name = "RadioButton" + i;
                    rdo.Text = "Radio Button " + i;
                    int left = checkBox.Left;
                    int top = checkBox.Top;
                    //   rdo.Location = new Point(20,50+i);
                    rdo.Left = initialLeft;
                    rdo.Top = 90;
                    rdo.CheckedChanged += new EventHandler(RadioButtonEvent);
                    this.Controls.Add(rdo);
                    MessageBox.Show(Convert.ToString(initialLeft));
                    initialLeft += 150;
                    MessageBox.Show(Convert.ToString(left) + "," + Convert.ToString(top));

                }


            }
            else
            {
                MessageBox.Show("Air 2 is called");
                int left = checkBox.Left;
                int top = checkBox.Top;
                MessageBox.Show(Convert.ToString(left) + "," + Convert.ToString(top));

                ComboBox comboBox3 = new ComboBox();
                comboBox3.Location = new Point(250, 130);
                comboBox3.Size = new Size(240, 21);
                comboBox3.Items.Add("Clear Float");
                comboBox3.Items.Add("Low E");
                comboBox3.Items.Add("Toughened Low E");
                comboBox3.Items.Add("Toughened Float One Side");
                comboBox3.Items.Add("Clear Laminate Low E");
                comboBox3.Items.Add("Float Gray Tint");
                comboBox3.Items.Add("Float Gray Tint Toughened One Side");
                comboBox3.Items.Add("Obscure - Toilet Only");
                comboBox3.Items.Add("Obscure - Bathroom Toughened One Side");
                comboBox3.Items.Add("Toughened E Tch Lite - Toilet Only");
                comboBox3.Items.Add("E Tch Lite - Toughened One Side");
                comboBox3.Name = "comboBox3";
                comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_SelectedIndexChanged);
                this.Controls.Add(comboBox3);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            criarCheckBox("Air", "Air");
        }

        public void RadioButtons()
        {

            List<CheckBox> listaCheckBox = new List<CheckBox>();
            int intialTop = 50;
            for (int i = 0; i <= 4; i++)
            {
                RadioButton rdo = new RadioButton();
                rdo.Name = "RadioButton" + i;
                rdo.Text = "Radio Button " + i;
                rdo.Location = new Point(5, 30 * i);
                rdo.CheckedChanged += new EventHandler(RadioButtonEvent);
                this.Controls.Add(rdo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RadioButtons();
        }

        void RadioButtonEvent(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            var rdoName = radio.Name;
            if (rdoName == "RadioButton0")
            {
                MessageBox.Show(rdoName);
            }

        }

        void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (ComboBox)sender;
            MessageBox.Show(selected.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckBox_ProductName();
        }

        public void chk_checked1(object sender, EventArgs e)
        {
            MessageBox.Show("Clcicked");
        }

        public void CheckBox_ProductName()
        {

            List<CheckBox> listaCheckBox = new List<CheckBox>();
            myConn ProdObj = new myConn();
           // string prod = "products";
            string query = "select prodName from products ";
            if (ProdObj.FetchData(query))
            {
                int intialTop = 50;
                while (ProdObj.dataReader.Read())
                {
                    productName.Add(Convert.ToString(ProdObj.dataReader.GetValue(0)));
                    CheckBox box = new CheckBox();
                    box.Top = intialTop;
                    box.Left = 50;
                    box.Name = Convert.ToString(ProdObj.dataReader.GetValue(0));
                    box.Text = Convert.ToString(ProdObj.dataReader.GetValue(0));
                    listaCheckBox.Add(box);
                    box.CheckedChanged += new EventHandler(getSupplierName);
                    this.Controls.Add(box);
                    intialTop += 40;
                }
            }
        }

        public void getSupplierName(object sender, EventArgs e)
        {
            var Name = (CheckBox)sender;
            int left = Name.Left;
            int top = Name.Top;
            returnedProductName = Name.Text;
            string query = "select SupName from products,products_suppliers,suppliers where suppliers.SupplierId=products_suppliers.SupplierId and products.ProductId=products_suppliers.ProductId and prodName='"+Name.Text+"'";
            ComboBox_SupName(query,Name.Text, left, top);
        }

        public void ComboBox_SupName(String Joinquery,string criteria, int l, int t)
        {

            ComboBox SupCombo = new ComboBox();
            SupCombo.Location = new Point(l + 200, t);
            SupCombo.Size = new Size(240, 21);
            string query = Joinquery;
            string searchcriteria = criteria;
            myConn SupObj = new myConn();
            if (SupObj.FetchData(query))
            {
                while (SupObj.dataReader.Read())
                {
                    //MessageBox.Show(Convert.ToString(SupObj.dataReader.GetValue(0)));
                    SupCombo.Items.Add(Convert.ToString(SupObj.dataReader.GetValue(0)));
                }

                SupCombo.SelectedIndexChanged += new System.EventHandler(SupCombo_SelectedIndexChanged);
                this.Controls.Add(SupCombo);

            }
        }

        public void SupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SupName = (ComboBox)sender;
            returnedSupName = SupName.Text;
            // MessageBox.Show(Convert.ToString(SupName.Text));

            // Initializes the variables to pass to the MessageBox.Show method.

            string message = "Do want to save the changes?";
            string caption = "Update Info";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form.

                // this.Close();
                getSupId();
                getProductCode();
                getProductSupplierId();
                Add_Packages_Products_Suppliers();


            }


        }

        public void getSupId()
        {
            myConn pkgInsertObj = new myConn();
            string query = "select SupplierId from suppliers where SupName='" + returnedSupName + "'";
            if (pkgInsertObj.FetchData(query))
            {
                while (pkgInsertObj.dataReader.Read())
                {
                    returnedSupId = Convert.ToString(pkgInsertObj.dataReader.GetValue(0));
                    //MessageBox.Show(returnedSupId);
                }
            }


        }
        public void getProductCode()
        {
            myConn getProdCodeObj = new myConn();
            string query = "select ProductId from products where ProdName='" + returnedProductName + "'";

            if (getProdCodeObj.FetchData(query))
            {
                while (getProdCodeObj.dataReader.Read())
                {
                    returnedProdId =Convert.ToString(getProdCodeObj.dataReader.GetValue(0));
                   // MessageBox.Show(returnedProdId);
                }
            }

        }

        public void getProductSupplierId()
        {
            myConn getProdSupObj = new myConn();
            string query = "select ProductSupplierId from products_suppliers where ProductId='" + returnedProdId + "'" + "and SupplierId='" + returnedSupId + "'";
            if (getProdSupObj.FetchData(query))
            {
                while (getProdSupObj.dataReader.Read())
                {
                    returnedSupplier_SupId = Convert.ToString(getProdSupObj.dataReader.GetValue(0));
                    MessageBox.Show(returnedSupplier_SupId);
                }
            }
        }

        public void Add_Packages_Products_Suppliers()
        {
            myConn addPkgProdSupObj = new myConn();
            string query = "insert into packages_products_suppliers values(1,'" + returnedSupplier_SupId + "'" + ")";
            if (addPkgProdSupObj.AddRecord(query))
            {
                MessageBox.Show("Record Updated");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string count in productName)
            {
                MessageBox.Show(count);
            }

        }

    }
}




        
    

   

