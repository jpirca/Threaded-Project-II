namespace ThreadedProjectII
{
    partial class frmEditPackage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelPkg = new System.Windows.Forms.Button();
            this.btnNextPkg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(112, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 42);
            this.label10.TabIndex = 27;
            this.label10.Text = "Edit Package";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 16);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Please select the package to edit and press button \"Edit\":";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Package 01\tJan 01, 2019\tMar 31, 2019",
            "Package 02\tJan 01, 2019\tMar 31, 2019",
            "Package 03\tJan 01, 2019\tMar 31, 2019",
            "Package 04\tJan 01, 2019\tMar 31, 2019",
            "Package 05\tJan 01, 2019\tMar 31, 2019",
            "Package 06\tJan 01, 2019\tMar 31, 2019",
            "Package 07\tJan 01, 2019\tMar 31, 2019",
            "Package 08\tJan 01, 2019\tMar 31, 2019",
            "Package 09\tJan 01, 2019\tMar 31, 2019",
            "Package 10\tJan 01, 2019\tMar 31, 2019"});
            this.listBox1.Location = new System.Drawing.Point(34, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(385, 132);
            this.listBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "End Date";
            // 
            // btnCancelPkg
            // 
            this.btnCancelPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPkg.Location = new System.Drawing.Point(344, 331);
            this.btnCancelPkg.Name = "btnCancelPkg";
            this.btnCancelPkg.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPkg.TabIndex = 33;
            this.btnCancelPkg.Text = "&Cancel";
            this.btnCancelPkg.UseVisualStyleBackColor = true;
            this.btnCancelPkg.Click += new System.EventHandler(this.btnCancelPkg_Click);
            // 
            // btnNextPkg
            // 
            this.btnNextPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPkg.Location = new System.Drawing.Point(249, 331);
            this.btnNextPkg.Name = "btnNextPkg";
            this.btnNextPkg.Size = new System.Drawing.Size(75, 23);
            this.btnNextPkg.TabIndex = 32;
            this.btnNextPkg.Text = "&Next";
            this.btnNextPkg.UseVisualStyleBackColor = true;
            this.btnNextPkg.Click += new System.EventHandler(this.btnNextPkg_Click);
            // 
            // frmEditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 384);
            this.Controls.Add(this.btnCancelPkg);
            this.Controls.Add(this.btnNextPkg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmEditPackage";
            this.Text = "Edit Package";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelPkg;
        private System.Windows.Forms.Button btnNextPkg;
    }
}