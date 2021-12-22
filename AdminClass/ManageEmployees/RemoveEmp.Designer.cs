namespace ShopMgtSys
{
    partial class RemoveEmp
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
            this.EmpListTbl = new System.Windows.Forms.DataGridView();
            this.searchT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeB = new System.Windows.Forms.Button();
            this.nameT = new System.Windows.Forms.TextBox();
            this.idT = new System.Windows.Forms.TextBox();
            this.clearB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpListTbl)).BeginInit();
            this.SuspendLayout();
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
            this.EmpListTbl.Location = new System.Drawing.Point(34, 102);
            this.EmpListTbl.MultiSelect = false;
            this.EmpListTbl.Name = "EmpListTbl";
            this.EmpListTbl.ReadOnly = true;
            this.EmpListTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmpListTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpListTbl.Size = new System.Drawing.Size(614, 225);
            this.EmpListTbl.TabIndex = 0;
            this.EmpListTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpListTbl_CellClick);
            // 
            // searchT
            // 
            this.searchT.Location = new System.Drawing.Point(145, 68);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(160, 20);
            this.searchT.TabIndex = 1;
            this.searchT.TextChanged += new System.EventHandler(this.SearchT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name or ID";
            // 
            // removeB
            // 
            this.removeB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.removeB.Enabled = false;
            this.removeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeB.Location = new System.Drawing.Point(573, 351);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(75, 23);
            this.removeB.TabIndex = 3;
            this.removeB.Text = "Remove";
            this.removeB.UseVisualStyleBackColor = false;
            this.removeB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(213, 357);
            this.nameT.Name = "nameT";
            this.nameT.ReadOnly = true;
            this.nameT.Size = new System.Drawing.Size(160, 20);
            this.nameT.TabIndex = 4;
            // 
            // idT
            // 
            this.idT.Location = new System.Drawing.Point(76, 354);
            this.idT.Name = "idT";
            this.idT.ReadOnly = true;
            this.idT.Size = new System.Drawing.Size(63, 20);
            this.idT.TabIndex = 5;
            // 
            // clearB
            // 
            this.clearB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.clearB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.ForeColor = System.Drawing.Color.White;
            this.clearB.Location = new System.Drawing.Point(383, 401);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(103, 33);
            this.clearB.TabIndex = 6;
            this.clearB.Text = "Clear Selected";
            this.clearB.UseVisualStyleBackColor = false;
            this.clearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(172, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(31, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "EmpID";
            // 
            // returnB
            // 
            this.returnB.BackColor = System.Drawing.Color.Black;
            this.returnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.returnB.Image = global::WindowsFormsApp1.Properties.Resources.back;
            this.returnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnB.Location = new System.Drawing.Point(34, 441);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 10;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // RemoveEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.nathan_anderson_iYO_EGosrCo_unsplash1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 505);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchT);
            this.Controls.Add(this.EmpListTbl);
            this.Name = "RemoveEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Employee";
            ((System.ComponentModel.ISupportInitialize)(this.EmpListTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpListTbl;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnB;
    }
}