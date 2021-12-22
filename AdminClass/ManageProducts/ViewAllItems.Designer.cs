namespace WindowsFormsApp1.AdminClass
{
    partial class ViewAllItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchT = new System.Windows.Forms.TextBox();
            this.ProdListTbl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProdListTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // returnB
            // 
            this.returnB.Location = new System.Drawing.Point(14, 462);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(75, 23);
            this.returnB.TabIndex = 12;
            this.returnB.Text = "Return";
            this.returnB.UseVisualStyleBackColor = true;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Name or ID";
            // 
            // searchT
            // 
            this.searchT.Location = new System.Drawing.Point(107, 24);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 20);
            this.searchT.TabIndex = 10;
            this.searchT.TextChanged += new System.EventHandler(this.SearchT_TextChanged);
            // 
            // ProdListTbl
            // 
            this.ProdListTbl.AllowUserToAddRows = false;
            this.ProdListTbl.AllowUserToDeleteRows = false;
            this.ProdListTbl.AllowUserToOrderColumns = true;
            this.ProdListTbl.AllowUserToResizeColumns = false;
            this.ProdListTbl.AllowUserToResizeRows = false;
            this.ProdListTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdListTbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProdListTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProdListTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProdListTbl.Location = new System.Drawing.Point(14, 70);
            this.ProdListTbl.MultiSelect = false;
            this.ProdListTbl.Name = "ProdListTbl";
            this.ProdListTbl.ReadOnly = true;
            this.ProdListTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProdListTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdListTbl.Size = new System.Drawing.Size(884, 306);
            this.ProdListTbl.TabIndex = 9;
            // 
            // ViewAllItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 509);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.ProdListTbl);
            this.Name = "ViewAllItems";
            this.Text = "ViewAllItems";
            ((System.ComponentModel.ISupportInitialize)(this.ProdListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.DataGridView ProdListTbl;
    }
}