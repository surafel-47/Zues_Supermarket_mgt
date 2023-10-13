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
            this.newStockT = new System.Windows.Forms.TextBox();
            this.idT = new System.Windows.Forms.TextBox();
            this.nameT = new System.Windows.Forms.TextBox();
            this.searchT = new System.Windows.Forms.TextBox();
            this.ProductsListTbl = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateB = new System.Windows.Forms.Button();
            this.returnB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // newStockT
            // 
            this.newStockT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newStockT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStockT.ForeColor = System.Drawing.SystemColors.Window;
            this.newStockT.Location = new System.Drawing.Point(558, 303);
            this.newStockT.Name = "newStockT";
            this.newStockT.Size = new System.Drawing.Size(100, 26);
            this.newStockT.TabIndex = 41;
            this.newStockT.Click += new System.EventHandler(this.NewStock_TextChanged);
            this.newStockT.TextChanged += new System.EventHandler(this.NewStock_TextChanged);
            // 
            // idT
            // 
            this.idT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idT.ForeColor = System.Drawing.SystemColors.Window;
            this.idT.Location = new System.Drawing.Point(121, 303);
            this.idT.Name = "idT";
            this.idT.ReadOnly = true;
            this.idT.Size = new System.Drawing.Size(63, 26);
            this.idT.TabIndex = 38;
            // 
            // nameT
            // 
            this.nameT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameT.ForeColor = System.Drawing.SystemColors.Window;
            this.nameT.Location = new System.Drawing.Point(255, 300);
            this.nameT.Name = "nameT";
            this.nameT.ReadOnly = true;
            this.nameT.Size = new System.Drawing.Size(122, 26);
            this.nameT.TabIndex = 37;
            // 
            // searchT
            // 
            this.searchT.BackColor = System.Drawing.Color.DarkRed;
            this.searchT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchT.ForeColor = System.Drawing.SystemColors.Control;
            this.searchT.Location = new System.Drawing.Point(170, 17);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 26);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(37, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Enter Name or ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(37, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(201, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(432, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Enter New Stock";
            // 
            // updateB
            // 
            this.updateB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateB.BackColor = System.Drawing.Color.Blue;
            this.updateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateB.Image = global::WindowsFormsApp1.Properties.Resources.removeProd;
            this.updateB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateB.Location = new System.Drawing.Point(558, 345);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(96, 42);
            this.updateB.TabIndex = 50;
            this.updateB.Text = "Update";
            this.updateB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateB.UseVisualStyleBackColor = false;
            this.updateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // returnB
            // 
            this.returnB.BackColor = System.Drawing.Color.Indigo;
            this.returnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.returnB.Image = global::WindowsFormsApp1.Properties.Resources.back;
            this.returnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnB.Location = new System.Drawing.Point(43, 391);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 51;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // UpdateProductStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.HD_Wallpaper__332_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 446);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newStockT);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.ProductsListTbl);
            this.Name = "UpdateProductStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProductStock";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newStockT;
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.DataGridView ProductsListTbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Button returnB;
    }
}