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
            this.clearB = new System.Windows.Forms.Button();
            this.idT = new System.Windows.Forms.TextBox();
            this.nameT = new System.Windows.Forms.TextBox();
            this.searchT = new System.Windows.Forms.TextBox();
            this.ProductsListTbl = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            this.removeB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // clearB
            // 
            this.clearB.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearB.Location = new System.Drawing.Point(499, 370);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(136, 39);
            this.clearB.TabIndex = 16;
            this.clearB.Text = "Clear Selected";
            this.clearB.UseVisualStyleBackColor = false;
            this.clearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // idT
            // 
            this.idT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idT.ForeColor = System.Drawing.SystemColors.Window;
            this.idT.Location = new System.Drawing.Point(119, 314);
            this.idT.Name = "idT";
            this.idT.ReadOnly = true;
            this.idT.Size = new System.Drawing.Size(63, 26);
            this.idT.TabIndex = 15;
            // 
            // nameT
            // 
            this.nameT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameT.ForeColor = System.Drawing.SystemColors.Window;
            this.nameT.Location = new System.Drawing.Point(319, 310);
            this.nameT.Name = "nameT";
            this.nameT.ReadOnly = true;
            this.nameT.Size = new System.Drawing.Size(160, 26);
            this.nameT.TabIndex = 14;
            // 
            // searchT
            // 
            this.searchT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchT.ForeColor = System.Drawing.SystemColors.Window;
            this.searchT.Location = new System.Drawing.Point(164, 21);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 26);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(35, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Enter Name or ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(265, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name";
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
            this.returnB.Location = new System.Drawing.Point(38, 385);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 39;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // removeB
            // 
            this.removeB.BackColor = System.Drawing.Color.SlateBlue;
            this.removeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeB.Image = global::WindowsFormsApp1.Properties.Resources.removeProd;
            this.removeB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeB.Location = new System.Drawing.Point(499, 310);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(114, 33);
            this.removeB.TabIndex = 40;
            this.removeB.Text = "Remove ";
            this.removeB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeB.UseVisualStyleBackColor = false;
            this.removeB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // RemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.w000065;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(690, 454);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.ProductsListTbl);
            this.Name = "RemoveItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveItem";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.DataGridView ProductsListTbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Button removeB;
    }
}