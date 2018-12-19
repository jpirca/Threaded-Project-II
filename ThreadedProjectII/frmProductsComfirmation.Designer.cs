namespace ThreadedProjectII
{
    partial class frmProductsComfirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lstSuppliersSelec = new System.Windows.Forms.ListBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBackProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(346, 39);
            this.label10.TabIndex = 47;
            this.label10.Text = "Create New Product";
            // 
            // btnCancelProd
            // 
            this.btnCancelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProd.Location = new System.Drawing.Point(297, 412);
            this.btnCancelProd.Name = "btnCancelProd";
            this.btnCancelProd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProd.TabIndex = 46;
            this.btnCancelProd.Text = "&Cancel";
            this.btnCancelProd.UseVisualStyleBackColor = true;
            this.btnCancelProd.Click += new System.EventHandler(this.btnCancelProd_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Location = new System.Drawing.Point(109, 412);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 23);
            this.btnAddProd.TabIndex = 45;
            this.btnAddProd.Text = "&Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Suppliers Selected:";
            // 
            // lstSuppliersSelec
            // 
            this.lstSuppliersSelec.Enabled = false;
            this.lstSuppliersSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuppliersSelec.FormattingEnabled = true;
            this.lstSuppliersSelec.ItemHeight = 16;
            this.lstSuppliersSelec.Location = new System.Drawing.Point(205, 178);
            this.lstSuppliersSelec.Name = "lstSuppliersSelec";
            this.lstSuppliersSelec.Size = new System.Drawing.Size(167, 196);
            this.lstSuppliersSelec.TabIndex = 43;
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(109, 130);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.ReadOnly = true;
            this.txtProdName.Size = new System.Drawing.Size(263, 22);
            this.txtProdName.TabIndex = 42;
            this.txtProdName.Text = "Product XXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 44);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Please check all the information below and click \"Add\" to create the product.";
            // 
            // btnBackProd
            // 
            this.btnBackProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackProd.Location = new System.Drawing.Point(205, 412);
            this.btnBackProd.Name = "btnBackProd";
            this.btnBackProd.Size = new System.Drawing.Size(75, 23);
            this.btnBackProd.TabIndex = 48;
            this.btnBackProd.Text = "&Back";
            this.btnBackProd.UseVisualStyleBackColor = true;
            this.btnBackProd.Click += new System.EventHandler(this.btnBackProd_Click);
            // 
            // ProductsComfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.btnBackProd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstSuppliersSelec);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ProductsComfirmation";
            this.Text = "ProductsComfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstSuppliersSelec;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackProd;
    }
}