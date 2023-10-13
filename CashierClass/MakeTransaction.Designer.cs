namespace ShopMgtSys
{
    partial class MakeTransaction
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
            this.searchT = new System.Windows.Forms.TextBox();
            this.catagoryCB = new System.Windows.Forms.ComboBox();
            this.productsTbl = new System.Windows.Forms.DataGridView();
            this.selectedProdsTbl = new System.Windows.Forms.DataGridView();
            this.ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOffB = new System.Windows.Forms.Button();
            this.transactB = new System.Windows.Forms.Button();
            this.removeB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedProdsTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchT
            // 
            this.searchT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchT.ForeColor = System.Drawing.SystemColors.Window;
            this.searchT.Location = new System.Drawing.Point(127, 16);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(128, 26);
            this.searchT.TabIndex = 1;
            this.searchT.TextChanged += new System.EventHandler(this.SearchT_TextChanged);
            // 
            // catagoryCB
            // 
            this.catagoryCB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.catagoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagoryCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryCB.ForeColor = System.Drawing.Color.White;
            this.catagoryCB.FormattingEnabled = true;
            this.catagoryCB.Location = new System.Drawing.Point(401, 15);
            this.catagoryCB.Name = "catagoryCB";
            this.catagoryCB.Size = new System.Drawing.Size(180, 28);
            this.catagoryCB.TabIndex = 4;
            this.catagoryCB.SelectedIndexChanged += new System.EventHandler(this.CatagoryCB_SelectedIndexChanged);
            // 
            // productsTbl
            // 
            this.productsTbl.AllowUserToAddRows = false;
            this.productsTbl.AllowUserToDeleteRows = false;
            this.productsTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.productsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsTbl.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productsTbl.Location = new System.Drawing.Point(37, 46);
            this.productsTbl.MultiSelect = false;
            this.productsTbl.Name = "productsTbl";
            this.productsTbl.ReadOnly = true;
            this.productsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.productsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTbl.Size = new System.Drawing.Size(544, 220);
            this.productsTbl.TabIndex = 6;
            this.productsTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsTbl_CellClick);
            // 
            // selectedProdsTbl
            // 
            this.selectedProdsTbl.AllowUserToAddRows = false;
            this.selectedProdsTbl.AllowUserToDeleteRows = false;
            this.selectedProdsTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedProdsTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.selectedProdsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.selectedProdsTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProID,
            this.name,
            this.price,
            this.quantity});
            this.selectedProdsTbl.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectedProdsTbl.Location = new System.Drawing.Point(37, 337);
            this.selectedProdsTbl.MultiSelect = false;
            this.selectedProdsTbl.Name = "selectedProdsTbl";
            this.selectedProdsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selectedProdsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedProdsTbl.Size = new System.Drawing.Size(544, 220);
            this.selectedProdsTbl.TabIndex = 8;
            // 
            // ProID
            // 
            this.ProID.HeaderText = "ProID";
            this.ProID.Name = "ProID";
            this.ProID.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.quantity.MaxDropDownItems = 10;
            this.quantity.Name = "quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(282, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.cart_icon;
            this.pictureBox1.Location = new System.Drawing.Point(37, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // logOffB
            // 
            this.logOffB.BackColor = System.Drawing.Color.MediumBlue;
            this.logOffB.FlatAppearance.BorderSize = 0;
            this.logOffB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOffB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffB.ForeColor = System.Drawing.Color.White;
            this.logOffB.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.logOffB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOffB.Location = new System.Drawing.Point(37, 608);
            this.logOffB.Name = "logOffB";
            this.logOffB.Size = new System.Drawing.Size(96, 30);
            this.logOffB.TabIndex = 19;
            this.logOffB.Text = "LOG OFF";
            this.logOffB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOffB.UseVisualStyleBackColor = false;
            this.logOffB.Click += new System.EventHandler(this.LogOffB_Click);
            // 
            // transactB
            // 
            this.transactB.BackColor = System.Drawing.Color.Indigo;
            this.transactB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transactB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transactB.Image = global::WindowsFormsApp1.Properties.Resources.cart;
            this.transactB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactB.Location = new System.Drawing.Point(401, 565);
            this.transactB.Name = "transactB";
            this.transactB.Size = new System.Drawing.Size(180, 29);
            this.transactB.TabIndex = 20;
            this.transactB.Text = "Make Transaction";
            this.transactB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transactB.UseVisualStyleBackColor = false;
            this.transactB.Click += new System.EventHandler(this.TransactB_Click);
            // 
            // removeB
            // 
            this.removeB.BackColor = System.Drawing.Color.Indigo;
            this.removeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeB.Location = new System.Drawing.Point(249, 565);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(146, 29);
            this.removeB.TabIndex = 21;
            this.removeB.Text = "Remove Selected";
            this.removeB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeB.UseVisualStyleBackColor = false;
            this.removeB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // clearB
            // 
            this.clearB.BackColor = System.Drawing.Color.Indigo;
            this.clearB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearB.Location = new System.Drawing.Point(158, 565);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(85, 29);
            this.clearB.TabIndex = 22;
            this.clearB.Text = "Clear All";
            this.clearB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearB.UseVisualStyleBackColor = false;
            this.clearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(90, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cart";
            // 
            // MakeTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.vUys1x;
            this.ClientSize = new System.Drawing.Size(637, 661);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.transactB);
            this.Controls.Add(this.logOffB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedProdsTbl);
            this.Controls.Add(this.productsTbl);
            this.Controls.Add(this.catagoryCB);
            this.Controls.Add(this.searchT);
            this.Name = "MakeTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Out/Make a Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.productsTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedProdsTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.ComboBox catagoryCB;
        private System.Windows.Forms.DataGridView productsTbl;
        private System.Windows.Forms.DataGridView selectedProdsTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewComboBoxColumn quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logOffB;
        private System.Windows.Forms.Button transactB;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label label2;
    }
}

