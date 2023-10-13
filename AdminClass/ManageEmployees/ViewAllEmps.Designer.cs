namespace WindowsFormsApp1.AdminClass
{
    partial class ViewAllEmps
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
            this.searchT = new System.Windows.Forms.TextBox();
            this.EmpListTbl = new System.Windows.Forms.DataGridView();
            this.returnB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpListTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Name or ID";
            // 
            // searchT
            // 
            this.searchT.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchT.Location = new System.Drawing.Point(172, 36);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 24);
            this.searchT.TabIndex = 4;
            this.searchT.TextChanged += new System.EventHandler(this.SearchT_TextChanged);
            // 
            // EmpListTbl
            // 
            this.EmpListTbl.AllowUserToAddRows = false;
            this.EmpListTbl.AllowUserToDeleteRows = false;
            this.EmpListTbl.AllowUserToOrderColumns = true;
            this.EmpListTbl.AllowUserToResizeColumns = false;
            this.EmpListTbl.AllowUserToResizeRows = false;
            this.EmpListTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpListTbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmpListTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmpListTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmpListTbl.Location = new System.Drawing.Point(28, 82);
            this.EmpListTbl.MultiSelect = false;
            this.EmpListTbl.Name = "EmpListTbl";
            this.EmpListTbl.ReadOnly = true;
            this.EmpListTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmpListTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpListTbl.Size = new System.Drawing.Size(884, 306);
            this.EmpListTbl.TabIndex = 3;
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
            this.returnB.Location = new System.Drawing.Point(28, 414);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 8;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // ViewAllEmps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._801643;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 488);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.EmpListTbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewAllEmps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllEmps";
            ((System.ComponentModel.ISupportInitialize)(this.EmpListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.DataGridView EmpListTbl;
        private System.Windows.Forms.Button returnB;
    }
}