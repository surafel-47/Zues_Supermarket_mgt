namespace WindowsFormsApp1.AdminClass
{
    partial class UpdateProdPrice
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
            this.idT = new System.Windows.Forms.TextBox();
            this.nameT = new System.Windows.Forms.TextBox();
            this.searchT = new System.Windows.Forms.TextBox();
            this.ProductsListTbl = new System.Windows.Forms.DataGridView();
            this.newUnitPriceT = new System.Windows.Forms.TextBox();
            this.oldUnitPriceT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // idT
            // 
            this.idT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.idT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idT.ForeColor = System.Drawing.SystemColors.Window;
            this.idT.Location = new System.Drawing.Point(84, 309);
            this.idT.Name = "idT";
            this.idT.ReadOnly = true;
            this.idT.Size = new System.Drawing.Size(63, 26);
            this.idT.TabIndex = 25;
            // 
            // nameT
            // 
            this.nameT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameT.ForeColor = System.Drawing.SystemColors.Window;
            this.nameT.Location = new System.Drawing.Point(213, 309);
            this.nameT.Name = "nameT";
            this.nameT.ReadOnly = true;
            this.nameT.Size = new System.Drawing.Size(160, 26);
            this.nameT.TabIndex = 24;
            // 
            // searchT
            // 
            this.searchT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchT.ForeColor = System.Drawing.SystemColors.Window;
            this.searchT.Location = new System.Drawing.Point(152, 26);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 26);
            this.searchT.TabIndex = 21;
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
            this.ProductsListTbl.Location = new System.Drawing.Point(23, 60);
            this.ProductsListTbl.MultiSelect = false;
            this.ProductsListTbl.Name = "ProductsListTbl";
            this.ProductsListTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsListTbl.Size = new System.Drawing.Size(614, 225);
            this.ProductsListTbl.TabIndex = 20;
            this.ProductsListTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsListTbl_CellClick);
            // 
            // newUnitPriceT
            // 
            this.newUnitPriceT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newUnitPriceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUnitPriceT.ForeColor = System.Drawing.SystemColors.Window;
            this.newUnitPriceT.Location = new System.Drawing.Point(501, 364);
            this.newUnitPriceT.Name = "newUnitPriceT";
            this.newUnitPriceT.Size = new System.Drawing.Size(100, 26);
            this.newUnitPriceT.TabIndex = 28;
            this.newUnitPriceT.TextChanged += new System.EventHandler(this.NewUnitPriceT_TextChanged);
            // 
            // oldUnitPriceT
            // 
            this.oldUnitPriceT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.oldUnitPriceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldUnitPriceT.ForeColor = System.Drawing.SystemColors.Window;
            this.oldUnitPriceT.Location = new System.Drawing.Point(511, 312);
            this.oldUnitPriceT.Name = "oldUnitPriceT";
            this.oldUnitPriceT.ReadOnly = true;
            this.oldUnitPriceT.Size = new System.Drawing.Size(80, 26);
            this.oldUnitPriceT.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Enter Name or ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pro ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(157, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(406, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Old Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(389, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "New Unit Price";
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
            this.returnB.Location = new System.Drawing.Point(26, 394);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 38;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // updateB
            // 
            this.updateB.BackColor = System.Drawing.Color.Indigo;
            this.updateB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateB.Image = global::WindowsFormsApp1.Properties.Resources.cart;
            this.updateB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateB.Location = new System.Drawing.Point(504, 399);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(97, 33);
            this.updateB.TabIndex = 39;
            this.updateB.Text = "Update";
            this.updateB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateB.UseVisualStyleBackColor = false;
            this.updateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // UpdateProdPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._801643;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 455);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oldUnitPriceT);
            this.Controls.Add(this.newUnitPriceT);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.ProductsListTbl);
            this.DoubleBuffered = true;
            this.Name = "UpdateProdPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateProdPrice";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.DataGridView ProductsListTbl;
        private System.Windows.Forms.TextBox newUnitPriceT;
        private System.Windows.Forms.TextBox oldUnitPriceT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Button updateB;
    }
}