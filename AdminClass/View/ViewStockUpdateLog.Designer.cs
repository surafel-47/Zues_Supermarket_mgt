namespace WindowsFormsApp1.AdminClass.View
{
    partial class ViewStockUpdateLog
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
            this.stockUpdateLogTbl = new System.Windows.Forms.DataGridView();
            this.returnB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockUpdateLogTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // stockUpdateLogTbl
            // 
            this.stockUpdateLogTbl.AllowUserToAddRows = false;
            this.stockUpdateLogTbl.AllowUserToDeleteRows = false;
            this.stockUpdateLogTbl.AllowUserToOrderColumns = true;
            this.stockUpdateLogTbl.AllowUserToResizeColumns = false;
            this.stockUpdateLogTbl.AllowUserToResizeRows = false;
            this.stockUpdateLogTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockUpdateLogTbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stockUpdateLogTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stockUpdateLogTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stockUpdateLogTbl.Location = new System.Drawing.Point(27, 67);
            this.stockUpdateLogTbl.MultiSelect = false;
            this.stockUpdateLogTbl.Name = "stockUpdateLogTbl";
            this.stockUpdateLogTbl.ReadOnly = true;
            this.stockUpdateLogTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockUpdateLogTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockUpdateLogTbl.Size = new System.Drawing.Size(884, 306);
            this.stockUpdateLogTbl.TabIndex = 11;
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
            this.returnB.Location = new System.Drawing.Point(27, 400);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 16;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(301, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 49);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stock Update Logs";
            // 
            // ViewStockUpdateLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._801643;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.stockUpdateLogTbl);
            this.DoubleBuffered = true;
            this.Name = "ViewStockUpdateLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStockUpdateLog";
            ((System.ComponentModel.ISupportInitialize)(this.stockUpdateLogTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView stockUpdateLogTbl;
        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Label label1;
    }
}