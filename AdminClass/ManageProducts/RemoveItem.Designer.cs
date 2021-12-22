namespace ShopMgtSys
{
    partial class RemoveItem
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.idT = new System.Windows.Forms.TextBox();
            this.nameT = new System.Windows.Forms.TextBox();
            this.removeB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchT = new System.Windows.Forms.TextBox();
            this.ProductsListTbl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // returnB
            // 
            this.returnB.Location = new System.Drawing.Point(38, 422);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(75, 23);
            this.returnB.TabIndex = 17;
            this.returnB.Text = "Return";
            this.returnB.UseVisualStyleBackColor = true;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(404, 395);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(103, 23);
            this.clearB.TabIndex = 16;
            this.clearB.Text = "Clear Selected";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // idT
            // 
            this.idT.Location = new System.Drawing.Point(99, 312);
            this.idT.Name = "idT";
            this.idT.ReadOnly = true;
            this.idT.Size = new System.Drawing.Size(63, 20);
            this.idT.TabIndex = 15;
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(319, 310);
            this.nameT.Name = "nameT";
            this.nameT.ReadOnly = true;
            this.nameT.Size = new System.Drawing.Size(160, 20);
            this.nameT.TabIndex = 14;
            // 
            // removeB
            // 
            this.removeB.Enabled = false;
            this.removeB.Location = new System.Drawing.Point(577, 312);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(75, 23);
            this.removeB.TabIndex = 13;
            this.removeB.Text = "Remove";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Name or ID";
            // 
            // searchT
            // 
            this.searchT.Location = new System.Drawing.Point(232, 29);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 20);
            this.searchT.TabIndex = 11;
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
            this.ProductsListTbl.Location = new System.Drawing.Point(38, 63);
            this.ProductsListTbl.MultiSelect = false;
            this.ProductsListTbl.Name = "ProductsListTbl";
            this.ProductsListTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsListTbl.Size = new System.Drawing.Size(614, 225);
            this.ProductsListTbl.TabIndex = 10;
            this.ProductsListTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsListTbl_CellClick);
            // 
            // RemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.ProductsListTbl);
            this.Name = "RemoveItem";
            this.Text = "RemoveItem";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.DataGridView ProductsListTbl;
    }
}