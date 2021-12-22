namespace WindowsFormsApp1.AdminClass
{
    partial class UpdateProductStock
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
            this.returnB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newStockT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idT = new System.Windows.Forms.TextBox();
            this.nameT = new System.Windows.Forms.TextBox();
            this.updateB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchT = new System.Windows.Forms.TextBox();
            this.ProductsListTbl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // returnB
            // 
            this.returnB.Location = new System.Drawing.Point(40, 411);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(75, 23);
            this.returnB.TabIndex = 45;
            this.returnB.Text = "Return";
            this.returnB.UseVisualStyleBackColor = true;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Enter New Stock";
            // 
            // newStockT
            // 
            this.newStockT.Location = new System.Drawing.Point(131, 347);
            this.newStockT.Name = "newStockT";
            this.newStockT.Size = new System.Drawing.Size(100, 20);
            this.newStockT.TabIndex = 41;
            this.newStockT.Click += new System.EventHandler(this.NewStock_TextChanged);
            this.newStockT.TextChanged += new System.EventHandler(this.NewStock_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name";
            // 
            // idT
            // 
            this.idT.Location = new System.Drawing.Point(101, 300);
            this.idT.Name = "idT";
            this.idT.ReadOnly = true;
            this.idT.Size = new System.Drawing.Size(63, 20);
            this.idT.TabIndex = 38;
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(230, 300);
            this.nameT.Name = "nameT";
            this.nameT.ReadOnly = true;
            this.nameT.Size = new System.Drawing.Size(160, 20);
            this.nameT.TabIndex = 37;
            // 
            // updateB
            // 
            this.updateB.Enabled = false;
            this.updateB.Location = new System.Drawing.Point(255, 344);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(75, 23);
            this.updateB.TabIndex = 36;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enter Name or ID";
            // 
            // searchT
            // 
            this.searchT.Location = new System.Drawing.Point(150, 17);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 20);
            this.searchT.TabIndex = 34;
            this.searchT.TextChanged += new System.EventHandler(this.SearchT_TextChanged);
            // 
            // ProductsListTbl
            // 
            this.ProductsListTbl.AllowUserToAddRows = false;
            this.ProductsListTbl.AllowUserToDeleteRows = false;
            this.ProductsListTbl.AllowUserToResizeRows = false;
            this.ProductsListTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsListTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsListTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductsListTbl.Location = new System.Drawing.Point(40, 51);
            this.ProductsListTbl.MultiSelect = false;
            this.ProductsListTbl.Name = "ProductsListTbl";
            this.ProductsListTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsListTbl.Size = new System.Drawing.Size(614, 225);
            this.ProductsListTbl.TabIndex = 33;
            this.ProductsListTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsListTbl_CellClick);
            // 
            // UpdateProductStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 446);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newStockT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.ProductsListTbl);
            this.Name = "UpdateProductStock";
            this.Text = "UpdateProductStock";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newStockT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.DataGridView ProductsListTbl;
    }
}