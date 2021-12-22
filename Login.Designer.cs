namespace WindowsFormsApp1
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminLoginPanelB = new System.Windows.Forms.Button();
            this.cashierLoginPanelB = new System.Windows.Forms.Button();
            this.adminP = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminLoginB = new System.Windows.Forms.Button();
            this.adminPassWordT = new System.Windows.Forms.TextBox();
            this.adminNameT = new System.Windows.Forms.TextBox();
            this.cashierP = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashierLoginB = new System.Windows.Forms.Button();
            this.empIdT = new System.Windows.Forms.TextBox();
            this.mainP = new System.Windows.Forms.Panel();
            this.exitB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.adminP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.cashierP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.adminLoginPanelB);
            this.panel1.Controls.Add(this.cashierLoginPanelB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 325);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(53, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "LogIn Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Loginnnn;
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // adminLoginPanelB
            // 
            this.adminLoginPanelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(70)))));
            this.adminLoginPanelB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminLoginPanelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginPanelB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminLoginPanelB.Location = new System.Drawing.Point(0, 117);
            this.adminLoginPanelB.Name = "adminLoginPanelB";
            this.adminLoginPanelB.Size = new System.Drawing.Size(186, 51);
            this.adminLoginPanelB.TabIndex = 0;
            this.adminLoginPanelB.Text = "Admin Login";
            this.adminLoginPanelB.UseVisualStyleBackColor = false;
            this.adminLoginPanelB.Click += new System.EventHandler(this.AdminLoginPanelB_Click);
            // 
            // cashierLoginPanelB
            // 
            this.cashierLoginPanelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(70)))));
            this.cashierLoginPanelB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cashierLoginPanelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLoginPanelB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cashierLoginPanelB.Location = new System.Drawing.Point(0, 195);
            this.cashierLoginPanelB.Name = "cashierLoginPanelB";
            this.cashierLoginPanelB.Size = new System.Drawing.Size(186, 47);
            this.cashierLoginPanelB.TabIndex = 3;
            this.cashierLoginPanelB.Text = "Cashier Login";
            this.cashierLoginPanelB.UseVisualStyleBackColor = false;
            this.cashierLoginPanelB.Click += new System.EventHandler(this.CashierLoginPanelB_Click);
            // 
            // adminP
            // 
            this.adminP.Controls.Add(this.pictureBox3);
            this.adminP.Controls.Add(this.label5);
            this.adminP.Controls.Add(this.label2);
            this.adminP.Controls.Add(this.label3);
            this.adminP.Controls.Add(this.adminLoginB);
            this.adminP.Controls.Add(this.adminPassWordT);
            this.adminP.Controls.Add(this.adminNameT);
            this.adminP.Location = new System.Drawing.Point(525, 295);
            this.adminP.Name = "adminP";
            this.adminP.Size = new System.Drawing.Size(312, 259);
            this.adminP.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Admin1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(82, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 37);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(58, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(131, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Admin";
            // 
            // adminLoginB
            // 
            this.adminLoginB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(70)))));
            this.adminLoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminLoginB.Location = new System.Drawing.Point(109, 140);
            this.adminLoginB.Name = "adminLoginB";
            this.adminLoginB.Size = new System.Drawing.Size(100, 30);
            this.adminLoginB.TabIndex = 4;
            this.adminLoginB.Text = "Login";
            this.adminLoginB.UseVisualStyleBackColor = false;
            this.adminLoginB.Click += new System.EventHandler(this.AdminLoginB_Click);
            // 
            // adminPassWordT
            // 
            this.adminPassWordT.Location = new System.Drawing.Point(109, 105);
            this.adminPassWordT.Name = "adminPassWordT";
            this.adminPassWordT.PasswordChar = '*';
            this.adminPassWordT.Size = new System.Drawing.Size(100, 20);
            this.adminPassWordT.TabIndex = 7;
            // 
            // adminNameT
            // 
            this.adminNameT.Location = new System.Drawing.Point(109, 74);
            this.adminNameT.Name = "adminNameT";
            this.adminNameT.Size = new System.Drawing.Size(100, 20);
            this.adminNameT.TabIndex = 5;
            // 
            // cashierP
            // 
            this.cashierP.Controls.Add(this.pictureBox2);
            this.cashierP.Controls.Add(this.label1);
            this.cashierP.Controls.Add(this.label4);
            this.cashierP.Controls.Add(this.cashierLoginB);
            this.cashierP.Controls.Add(this.empIdT);
            this.cashierP.Location = new System.Drawing.Point(525, 27);
            this.cashierP.Name = "cashierP";
            this.cashierP.Size = new System.Drawing.Size(312, 259);
            this.cashierP.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cashLogin1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.cashLogin1;
            this.pictureBox2.Location = new System.Drawing.Point(72, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 37);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(121, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cashier ";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cashierLoginB
            // 
            this.cashierLoginB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(70)))));
            this.cashierLoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierLoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLoginB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cashierLoginB.Location = new System.Drawing.Point(109, 115);
            this.cashierLoginB.Name = "cashierLoginB";
            this.cashierLoginB.Size = new System.Drawing.Size(100, 26);
            this.cashierLoginB.TabIndex = 4;
            this.cashierLoginB.Text = "Login";
            this.cashierLoginB.UseVisualStyleBackColor = false;
            this.cashierLoginB.Click += new System.EventHandler(this.CashierLoginB_Click);
            // 
            // empIdT
            // 
            this.empIdT.Location = new System.Drawing.Point(109, 74);
            this.empIdT.Name = "empIdT";
            this.empIdT.Size = new System.Drawing.Size(100, 20);
            this.empIdT.TabIndex = 5;
            // 
            // mainP
            // 
            this.mainP.Location = new System.Drawing.Point(192, 56);
            this.mainP.Name = "mainP";
            this.mainP.Size = new System.Drawing.Size(312, 259);
            this.mainP.TabIndex = 3;
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Transparent;
            this.exitB.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close_icon;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitB.Location = new System.Drawing.Point(473, 0);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(31, 31);
            this.exitB.TabIndex = 4;
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(514, 325);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.mainP);
            this.Controls.Add(this.cashierP);
            this.Controls.Add(this.adminP);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.adminP.ResumeLayout(false);
            this.adminP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.cashierP.ResumeLayout(false);
            this.cashierP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel adminP;
        private System.Windows.Forms.Button adminLoginPanelB;
        private System.Windows.Forms.Button cashierLoginPanelB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminLoginB;
        private System.Windows.Forms.TextBox adminPassWordT;
        private System.Windows.Forms.TextBox adminNameT;
        private System.Windows.Forms.Panel cashierP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cashierLoginB;
        private System.Windows.Forms.TextBox empIdT;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Panel mainP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}