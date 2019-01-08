namespace ThreadedProjectII
{
    partial class frmEditSuppliers
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
            this.btnCancelPkg = new System.Windows.Forms.Button();
            this.btnNextPkg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelPkg
            // 
            this.btnCancelPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPkg.Location = new System.Drawing.Point(293, 303);
            this.btnCancelPkg.Name = "btnCancelPkg";
            this.btnCancelPkg.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPkg.TabIndex = 48;
            this.btnCancelPkg.Text = "&Cancel";
            this.btnCancelPkg.UseVisualStyleBackColor = true;
            this.btnCancelPkg.Click += new System.EventHandler(this.btnCancelPkg_Click);
            // 
            // btnNextPkg
            // 
            this.btnNextPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPkg.Location = new System.Drawing.Point(198, 303);
            this.btnNextPkg.Name = "btnNextPkg";
            this.btnNextPkg.Size = new System.Drawing.Size(75, 23);
            this.btnNextPkg.TabIndex = 47;
            this.btnNextPkg.Text = "&Edit";
            this.btnNextPkg.UseVisualStyleBackColor = true;
            this.btnNextPkg.Click += new System.EventHandler(this.btnNextPkg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Supplier";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Supplier A",
            "Supplier B",
            "Supplier C",
            "Supplier D",
            "Supplier E",
            "Supplier F",
            "Supplier G",
            "Supplier H",
            "Supplier I",
            "Supplier J",
            "Supplier K"});
            this.listBox1.Location = new System.Drawing.Point(36, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 132);
            this.listBox1.TabIndex = 44;

            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 42);
            this.label10.TabIndex = 43;
            this.label10.Text = "Edit Supplier";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 16);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Please select the supplier to edit and press button \"Edit\":";
            // 
            // frmEditSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 348);
            this.Controls.Add(this.btnCancelPkg);
            this.Controls.Add(this.btnNextPkg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmEditSuppliers";
            this.Text = "frmEditSuppliers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPkg;
        private System.Windows.Forms.Button btnNextPkg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTitle;
    }
}