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
            this.label1 = new System.Windows.Forms.Label();
            this.clearB = new System.Windows.Forms.Button();
            this.logOffB = new System.Windows.Forms.Button();
            this.catagoryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productsTbl = new System.Windows.Forms.DataGridView();
            this.transactB = new System.Windows.Forms.Button();
            this.selectedProdsTbl = new System.Windows.Forms.DataGridView();
            this.ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.removeB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedProdsTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // searchT
            // 
            this.searchT.Location = new System.Drawing.Point(173, 14);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(128, 20);
            this.searchT.TabIndex = 1;
            this.searchT.TextChanged += new System.EventHandler(this.SearchT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter  Name";
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(336, 572);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(61, 29);
            this.clearB.TabIndex = 0;
            this.clearB.Text = "Clear All";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // logOffB
            // 
            this.logOffB.Location = new System.Drawing.Point(26, 620);
            this.logOffB.Name = "logOffB";
            this.logOffB.Size = new System.Drawing.Size(61, 29);
            this.logOffB.TabIndex = 3;
            this.logOffB.Text = "Log Off";
            this.logOffB.UseVisualStyleBackColor = true;
            this.logOffB.Click += new System.EventHandler(this.LogOffB_Click);
            // 
            // catagoryCB
            // 
            this.catagoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagoryCB.FormattingEnabled = true;
            this.catagoryCB.Location = new System.Drawing.Point(494, 14);
            this.catagoryCB.Name = "catagoryCB";
            this.catagoryCB.Size = new System.Drawing.Size(122, 21);
            this.catagoryCB.TabIndex = 4;
            this.catagoryCB.SelectedIndexChanged += new System.EventHandler(this.CatagoryCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Catagory";
            // 
            // productsTbl
            // 
            this.productsTbl.AllowUserToAddRows = false;
            this.productsTbl.AllowUserToDeleteRows = false;
            this.productsTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.productsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsTbl.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productsTbl.Location = new System.Drawing.Point(104, 45);
            this.productsTbl.MultiSelect = false;
            this.productsTbl.Name = "productsTbl";
            this.productsTbl.ReadOnly = true;
            this.productsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.productsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTbl.Size = new System.Drawing.Size(544, 220);
            this.productsTbl.TabIndex = 6;
            this.productsTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsTbl_CellClick);
            // 
            // transactB
            // 
            this.transactB.Enabled = false;
            this.transactB.Location = new System.Drawing.Point(545, 572);
            this.transactB.Name = "transactB";
            this.transactB.Size = new System.Drawing.Size(103, 29);
            this.transactB.TabIndex = 7;
            this.transactB.Text = "Make Transaction";
            this.transactB.UseVisualStyleBackColor = true;
            this.transactB.Click += new System.EventHandler(this.TransactB_Click);
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
            this.selectedProdsTbl.Location = new System.Drawing.Point(104, 336);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // removeB
            // 
            this.removeB.Location = new System.Drawing.Point(414, 572);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(112, 29);
            this.removeB.TabIndex = 10;
            this.removeB.Text = "Remove Selected";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // MakeTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 661);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedProdsTbl);
            this.Controls.Add(this.transactB);
            this.Controls.Add(this.productsTbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catagoryCB);
            this.Controls.Add(this.logOffB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchT);
            this.Name = "MakeTransaction";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productsTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedProdsTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button logOffB;
        private System.Windows.Forms.ComboBox catagoryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView productsTbl;
        private System.Windows.Forms.Button transactB;
        private System.Windows.Forms.DataGridView selectedProdsTbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewComboBoxColumn quantity;
    }
}

