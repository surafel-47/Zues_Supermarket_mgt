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
            this.searchT = new System.Windows.Forms.TextBox();
            this.ProdListTbl = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdListTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // searchT
            // 
            this.searchT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchT.ForeColor = System.Drawing.SystemColors.Window;
            this.searchT.Location = new System.Drawing.Point(140, 25);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 24);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Name or ID";
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
            this.returnB.Location = new System.Drawing.Point(15, 435);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 14;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // ViewAllItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._801643;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 509);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.ProdListTbl);
            this.DoubleBuffered = true;
            this.Name = "ViewAllItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllItems";
            ((System.ComponentModel.ISupportInitialize)(this.ProdListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.DataGridView ProdListTbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnB;
    }
}