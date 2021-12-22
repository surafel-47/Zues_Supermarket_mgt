namespace WindowsFormsApp1.AdminClass
{
    partial class ViewPriceUpdateLogs
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
            this.priceUpdateLogTbl = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpdateLogTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // returnB
            // 
            this.returnB.Location = new System.Drawing.Point(28, 382);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(75, 23);
            this.returnB.TabIndex = 10;
            this.returnB.Text = "Return";
            this.returnB.UseVisualStyleBackColor = true;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // priceUpdateLogTbl
            // 
            this.priceUpdateLogTbl.AllowUserToAddRows = false;
            this.priceUpdateLogTbl.AllowUserToDeleteRows = false;
            this.priceUpdateLogTbl.AllowUserToOrderColumns = true;
            this.priceUpdateLogTbl.AllowUserToResizeColumns = false;
            this.priceUpdateLogTbl.AllowUserToResizeRows = false;
            this.priceUpdateLogTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.priceUpdateLogTbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceUpdateLogTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.priceUpdateLogTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.priceUpdateLogTbl.Location = new System.Drawing.Point(28, 45);
            this.priceUpdateLogTbl.MultiSelect = false;
            this.priceUpdateLogTbl.Name = "priceUpdateLogTbl";
            this.priceUpdateLogTbl.ReadOnly = true;
            this.priceUpdateLogTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.priceUpdateLogTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.priceUpdateLogTbl.Size = new System.Drawing.Size(884, 306);
            this.priceUpdateLogTbl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // ViewPriceUpdateLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.priceUpdateLogTbl);
            this.Name = "ViewPriceUpdateLogs";
            this.Text = "ViewPriceUpdateLogs";
            ((System.ComponentModel.ISupportInitialize)(this.priceUpdateLogTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.DataGridView priceUpdateLogTbl;
        private System.Windows.Forms.Label label1;
    }
}