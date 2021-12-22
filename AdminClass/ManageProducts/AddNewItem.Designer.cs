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
            this.label1 = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.catagoryCB = new System.Windows.Forms.ComboBox();
            this.upriceT = new System.Windows.Forms.TextBox();
            this.stockT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.returnB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(403, 241);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 2;
            this.addB.Text = "Add Item";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.AddB_Click);
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
            this.stockT.Location = new System.Drawing.Point(314, 32);
            this.stockT.Name = "stockT";
            this.stockT.Size = new System.Drawing.Size(91, 20);
            this.stockT.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Initial Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Catagory";
            // 
            // returnB
            // 
            this.returnB.Location = new System.Drawing.Point(12, 346);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(75, 23);
            this.returnB.TabIndex = 9;
            this.returnB.Text = "Return";
            this.returnB.UseVisualStyleBackColor = true;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(305, 241);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 10;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.catagoryCB);
            this.panel1.Controls.Add(this.nameT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.upriceT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stockT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 154);
            this.panel1.TabIndex = 11;
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.addB);
            this.Name = "AddNewItem";
            this.Text = "AddNewItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.ComboBox catagoryCB;
        private System.Windows.Forms.TextBox upriceT;
        private System.Windows.Forms.TextBox stockT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Panel panel1;
    }
}