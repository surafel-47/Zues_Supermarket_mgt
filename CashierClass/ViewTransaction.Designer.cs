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
            this.label4 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // totalT
            // 
            this.totalT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totalT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalT.ForeColor = System.Drawing.SystemColors.Window;
            this.totalT.Location = new System.Drawing.Point(673, 367);
            this.totalT.Name = "totalT";
            this.totalT.ReadOnly = true;
            this.totalT.Size = new System.Drawing.Size(100, 26);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(617, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total";
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
            this.returnB.Location = new System.Drawing.Point(27, 380);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 23;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // ViewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._801643;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalT);
            this.Controls.Add(this.transactionDetailsTbl);
            this.DoubleBuffered = true;
            this.Name = "ViewTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox totalT;
        private System.Windows.Forms.DataGridView transactionDetailsTbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button returnB;
    }
}