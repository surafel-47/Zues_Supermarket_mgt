namespace WindowsFormsApp1.CashierClass
{
    partial class ViewTransaction
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
            this.totalT = new System.Windows.Forms.TextBox();
            this.transactionDetailsTbl = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // totalT
            // 
            this.totalT.Location = new System.Drawing.Point(673, 367);
            this.totalT.Name = "totalT";
            this.totalT.ReadOnly = true;
            this.totalT.Size = new System.Drawing.Size(100, 20);
            this.totalT.TabIndex = 19;
            // 
            // transactionDetailsTbl
            // 
            this.transactionDetailsTbl.AllowUserToAddRows = false;
            this.transactionDetailsTbl.AllowUserToDeleteRows = false;
            this.transactionDetailsTbl.AllowUserToOrderColumns = true;
            this.transactionDetailsTbl.AllowUserToResizeColumns = false;
            this.transactionDetailsTbl.AllowUserToResizeRows = false;
            this.transactionDetailsTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionDetailsTbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transactionDetailsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.transactionDetailsTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transactionDetailsTbl.Location = new System.Drawing.Point(27, 38);
            this.transactionDetailsTbl.MultiSelect = false;
            this.transactionDetailsTbl.Name = "transactionDetailsTbl";
            this.transactionDetailsTbl.ReadOnly = true;
            this.transactionDetailsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transactionDetailsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionDetailsTbl.Size = new System.Drawing.Size(746, 308);
            this.transactionDetailsTbl.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total";
            // 
            // returnB
            // 
            this.returnB.Location = new System.Drawing.Point(298, 417);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(89, 21);
            this.returnB.TabIndex = 21;
            this.returnB.Text = "Return";
            this.returnB.UseVisualStyleBackColor = true;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // ViewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalT);
            this.Controls.Add(this.transactionDetailsTbl);
            this.Name = "ViewTransaction";
            this.Text = "viewTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox totalT;
        private System.Windows.Forms.DataGridView transactionDetailsTbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnB;
    }
}