namespace ShopMgtSys
{
    partial class AddNewItem
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
            this.nameT = new System.Windows.Forms.TextBox();
            this.catagoryCB = new System.Windows.Forms.ComboBox();
            this.upriceT = new System.Windows.Forms.TextBox();
            this.stockT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(109, 35);
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(100, 20);
            this.nameT.TabIndex = 0;
            // 
            // catagoryCB
            // 
            this.catagoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagoryCB.FormattingEnabled = true;
            this.catagoryCB.Location = new System.Drawing.Point(314, 73);
            this.catagoryCB.Name = "catagoryCB";
            this.catagoryCB.Size = new System.Drawing.Size(121, 21);
            this.catagoryCB.TabIndex = 3;
            // 
            // upriceT
            // 
            this.upriceT.Location = new System.Drawing.Point(109, 73);
            this.upriceT.Name = "upriceT";
            this.upriceT.Size = new System.Drawing.Size(100, 20);
            this.upriceT.TabIndex = 4;
            // 
            // stockT
            // 
            this.stockT.Location = new System.Drawing.Point(314, 35);
            this.stockT.Name = "stockT";
            this.stockT.Size = new System.Drawing.Size(91, 20);
            this.stockT.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.catagoryCB);
            this.panel1.Controls.Add(this.nameT);
            this.panel1.Controls.Add(this.upriceT);
            this.panel1.Controls.Add(this.stockT);
            this.panel1.Location = new System.Drawing.Point(43, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 154);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(240, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(259, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Unit Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product Name";
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
            this.returnB.Location = new System.Drawing.Point(12, 326);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(97, 43);
            this.returnB.TabIndex = 15;
            this.returnB.Text = "Return";
            this.returnB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // clearB
            // 
            this.clearB.BackColor = System.Drawing.Color.SlateBlue;
            this.clearB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearB.Image = global::WindowsFormsApp1.Properties.Resources.removeProd;
            this.clearB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearB.Location = new System.Drawing.Point(295, 241);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(97, 33);
            this.clearB.TabIndex = 16;
            this.clearB.Text = "Clear";
            this.clearB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearB.UseVisualStyleBackColor = false;
            this.clearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.Indigo;
            this.addB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addB.Image = global::WindowsFormsApp1.Properties.Resources.cart;
            this.addB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addB.Location = new System.Drawing.Point(398, 241);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(97, 33);
            this.addB.TabIndex = 17;
            this.addB.Text = "Add";
            this.addB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ph_10555;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 381);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.ComboBox catagoryCB;
        private System.Windows.Forms.TextBox upriceT;
        private System.Windows.Forms.TextBox stockT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button addB;
    }
}