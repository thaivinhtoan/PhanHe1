﻿namespace GiaoDien
{
    partial class AuditAllForm
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
            this.NoAuditBtn = new System.Windows.Forms.Button();
            this.AuditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoAuditBtn
            // 
            this.NoAuditBtn.Location = new System.Drawing.Point(51, 133);
            this.NoAuditBtn.Name = "NoAuditBtn";
            this.NoAuditBtn.Size = new System.Drawing.Size(150, 74);
            this.NoAuditBtn.TabIndex = 3;
            this.NoAuditBtn.Text = "Tắt ghi nhật ký";
            this.NoAuditBtn.UseVisualStyleBackColor = true;
            this.NoAuditBtn.Click += new System.EventHandler(this.NoAuditBtn_Click);
            // 
            // AuditBtn
            // 
            this.AuditBtn.Location = new System.Drawing.Point(51, 36);
            this.AuditBtn.Name = "AuditBtn";
            this.AuditBtn.Size = new System.Drawing.Size(150, 74);
            this.AuditBtn.TabIndex = 2;
            this.AuditBtn.Text = "Bật ghi nhật ký";
            this.AuditBtn.UseVisualStyleBackColor = true;
            this.AuditBtn.Click += new System.EventHandler(this.AuditBtn_Click);
            // 
            // AuditAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 247);
            this.Controls.Add(this.NoAuditBtn);
            this.Controls.Add(this.AuditBtn);
            this.Name = "AuditAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuditAllForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NoAuditBtn;
        private System.Windows.Forms.Button AuditBtn;
    }
}