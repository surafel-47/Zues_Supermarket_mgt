﻿namespace WindowsFormsApp1.AdminClass
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
            this.priceUpdateLogTbl = new System.Windows.Forms.DataGridView();
            this.returnB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpdateLogTbl)).BeginInit();
            this.SuspendLayout();
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
            this.priceUpdateLogTbl.Location = new System.Drawing.Point(28, 61);
            this.priceUpdateLogTbl.MultiSelect = false;
            this.priceUpdateLogTbl.Name = "priceUpdateLogTbl";
            this.priceUpdateLogTbl.ReadOnly = true;
            this.priceUpdateLogTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.priceUpdateLogTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.priceUpdateLogTbl.Size = new System.Drawing.Size(884, 306);
            this.priceUpdateLogTbl.TabIndex = 9;
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
            this.returnB.Location = new System.Drawing.Point(28, 377);
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
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 49);
            this.label1.TabIndex = 18;
            this.label1.Text = "Price Update Logs";
            // 
            // ViewPriceUpdateLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._801643;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.priceUpdateLogTbl);
            this.DoubleBuffered = true;
            this.Name = "ViewPriceUpdateLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPriceUpdateLogs";
            ((System.ComponentModel.ISupportInitialize)(this.priceUpdateLogTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView priceUpdateLogTbl;
        private System.Windows.Forms.Button returnB;
        private System.Windows.Forms.Label label1;
    }
}