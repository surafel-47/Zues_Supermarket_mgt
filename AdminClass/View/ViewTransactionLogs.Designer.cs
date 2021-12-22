namespace WindowsFormsApp1.AdminClass
{
    partial class ViewTransactionLogs
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
            this.label1 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            this.transactionsLogTbl = new System.Windows.Forms.DataGridView();
            this.transactionDetailsTbl = new System.Windows.Forms.DataGridView();
            this.selectTicketT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsLogTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // returnB
            // 
            this.returnB.Location = new System.Drawing.Point(12, 567);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(75, 23);
            this.returnB.TabIndex = 13;
            this.returnB.Text = "Return";
            this.returnB.UseVisualStyleBackColor = true;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // transactionsLogTbl
            // 
            this.transactionsLogTbl.AllowUserToAddRows = false;
            this.transactionsLogTbl.AllowUserToDeleteRows = false;
            this.transactionsLogTbl.AllowUserToOrderColumns = true;
            this.transactionsLogTbl.AllowUserToResizeColumns = false;
            this.transactionsLogTbl.AllowUserToResizeRows = false;
            this.transactionsLogTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsLogTbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transactionsLogTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.transactionsLogTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transactionsLogTbl.Location = new System.Drawing.Point(12, 58);
            this.transactionsLogTbl.MultiSelect = false;
            this.transactionsLogTbl.Name = "transactionsLogTbl";
            this.transactionsLogTbl.ReadOnly = true;
            this.transactionsLogTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transactionsLogTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsLogTbl.Size = new System.Drawing.Size(679, 214);
            this.transactionsLogTbl.TabIndex = 12;
            this.transactionsLogTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionsLogTbl_CellClick);
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
            this.transactionDetailsTbl.Location = new System.Drawing.Point(12, 319);
            this.transactionDetailsTbl.MultiSelect = false;
            this.transactionDetailsTbl.Name = "transactionDetailsTbl";
            this.transactionDetailsTbl.ReadOnly = true;
            this.transactionDetailsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transactionDetailsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionDetailsTbl.Size = new System.Drawing.Size(679, 214);
            this.transactionDetailsTbl.TabIndex = 15;
            this.transactionDetailsTbl.Visible = false;
            // 
            // selectTicketT
            // 
            this.selectTicketT.Location = new System.Drawing.Point(100, 289);
            this.selectTicketT.Name = "selectTicketT";
            this.selectTicketT.ReadOnly = true;
            this.selectTicketT.Size = new System.Drawing.Size(100, 20);
            this.selectTicketT.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Selected Ticket";
            // 
            // ViewTransactionLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectTicketT);
            this.Controls.Add(this.transactionDetailsTbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.transactionsLogTbl);
            this.Name = "ViewTransactionLogs";
            this.Text = "ViewTransactionLogs";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsLogTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.DataGridView transactionsLogTbl;
        private System.Windows.Forms.DataGridView transactionDetailsTbl;
        private System.Windows.Forms.TextBox selectTicketT;
        private System.Windows.Forms.Label label2;
    }
}