namespace ThreadedProjectII
{
    partial class frmProducts
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
            this.btnNextProd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstSuppliersSelec = new System.Windows.Forms.ListBox();
            this.btnRemoveSuppliers = new System.Windows.Forms.Button();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.lstSuppliersAva = new System.Windows.Forms.ListBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(346, 39);
            this.label10.TabIndex = 39;
            this.label10.Text = "Create New Product";
            // 
            // btnCancelProd
            // 
            this.btnCancelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProd.Location = new System.Drawing.Point(290, 409);
            this.btnCancelProd.Name = "btnCancelProd";
            this.btnCancelProd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProd.TabIndex = 38;
            this.btnCancelProd.Text = "&Cancel";
            this.btnCancelProd.UseVisualStyleBackColor = true;
            this.btnCancelProd.Click += new System.EventHandler(this.btnCancelProd_Click);
            // 
            // btnNextProd
            // 
            this.btnNextProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextProd.Location = new System.Drawing.Point(198, 409);
            this.btnNextProd.Name = "btnNextProd";
            this.btnNextProd.Size = new System.Drawing.Size(75, 23);
            this.btnNextProd.TabIndex = 37;
            this.btnNextProd.Text = "&Next";
            this.btnNextProd.UseVisualStyleBackColor = true;
            this.btnNextProd.Click += new System.EventHandler(this.btnNextProd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Suppliers Selected:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Suppliers Available:";
            // 
            // lstSuppliersSelec
            // 
            this.lstSuppliersSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuppliersSelec.FormattingEnabled = true;
            this.lstSuppliersSelec.ItemHeight = 16;
            this.lstSuppliersSelec.Location = new System.Drawing.Point(236, 200);
            this.lstSuppliersSelec.Name = "lstSuppliersSelec";
            this.lstSuppliersSelec.Size = new System.Drawing.Size(129, 196);
            this.lstSuppliersSelec.TabIndex = 34;
            // 
            // btnRemoveSuppliers
            // 
            this.btnRemoveSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSuppliers.Location = new System.Drawing.Point(172, 304);
            this.btnRemoveSuppliers.Name = "btnRemoveSuppliers";
            this.btnRemoveSuppliers.Size = new System.Drawing.Size(38, 23);
            this.btnRemoveSuppliers.TabIndex = 33;
            this.btnRemoveSuppliers.Text = "< <";
            this.btnRemoveSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSuppliers.Location = new System.Drawing.Point(172, 263);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(38, 23);
            this.btnAddSuppliers.TabIndex = 32;
            this.btnAddSuppliers.Text = "> >";
            this.btnAddSuppliers.UseVisualStyleBackColor = true;
            // 
            // lstSuppliersAva
            // 
            this.lstSuppliersAva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuppliersAva.FormattingEnabled = true;
            this.lstSuppliersAva.ItemHeight = 16;
            this.lstSuppliersAva.Location = new System.Drawing.Point(21, 200);
            this.lstSuppliersAva.Name = "lstSuppliersAva";
            this.lstSuppliersAva.Size = new System.Drawing.Size(129, 196);
            this.lstSuppliersAva.TabIndex = 31;
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(102, 127);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(263, 22);
            this.txtProdName.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 16);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Please insert all the information require to create a \"Package\":";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelProd);
            this.Controls.Add(this.btnNextProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstSuppliersSelec);
            this.Controls.Add(this.btnRemoveSuppliers);
            this.Controls.Add(this.btnAddSuppliers);
            this.Controls.Add(this.lstSuppliersAva);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelProd;
        private System.Windows.Forms.Button btnNextProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstSuppliersSelec;
        private System.Windows.Forms.Button btnRemoveSuppliers;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.ListBox lstSuppliersAva;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
    }
}