﻿namespace GiaoDien
{
    partial class FormAdmin
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
            this.button_QuanLyUser = new System.Windows.Forms.Button();
            this.button_QuanLyRole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Xemdoituong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_QuanLyUser
            // 
            this.button_QuanLyUser.BackColor = System.Drawing.Color.Gold;
            this.button_QuanLyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLyUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_QuanLyUser.Location = new System.Drawing.Point(9, 86);
            this.button_QuanLyUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_QuanLyUser.Name = "button_QuanLyUser";
            this.button_QuanLyUser.Size = new System.Drawing.Size(138, 119);
            this.button_QuanLyUser.TabIndex = 27;
            this.button_QuanLyUser.Text = "QUẢN LÝ USER";
            this.button_QuanLyUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_QuanLyUser.UseMnemonic = false;
            this.button_QuanLyUser.UseVisualStyleBackColor = false;
            this.button_QuanLyUser.Click += new System.EventHandler(this.button_QuanLyUser_Click);
            // 
            // button_QuanLyRole
            // 
            this.button_QuanLyRole.BackColor = System.Drawing.Color.Gold;
            this.button_QuanLyRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLyRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_QuanLyRole.Location = new System.Drawing.Point(184, 86);
            this.button_QuanLyRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_QuanLyRole.Name = "button_QuanLyRole";
            this.button_QuanLyRole.Size = new System.Drawing.Size(138, 119);
            this.button_QuanLyRole.TabIndex = 28;
            this.button_QuanLyRole.Text = "QUẢN LÝ ROLE";
            this.button_QuanLyRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_QuanLyRole.UseMnemonic = false;
            this.button_QuanLyRole.UseVisualStyleBackColor = false;
            this.button_QuanLyRole.Click += new System.EventHandler(this.button_QuanLyRole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 46);
            this.label2.TabIndex = 29;
            this.label2.Text = "Administrator";
            // 
            // button_Xemdoituong
            // 
            this.button_Xemdoituong.BackColor = System.Drawing.Color.Gold;
            this.button_Xemdoituong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xemdoituong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Xemdoituong.Location = new System.Drawing.Point(363, 86);
            this.button_Xemdoituong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Xemdoituong.Name = "button_Xemdoituong";
            this.button_Xemdoituong.Size = new System.Drawing.Size(138, 119);
            this.button_Xemdoituong.TabIndex = 31;
            this.button_Xemdoituong.Text = "XEM ĐỐI TƯỢNG";
            this.button_Xemdoituong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Xemdoituong.UseMnemonic = false;
            this.button_Xemdoituong.UseVisualStyleBackColor = false;
            this.button_Xemdoituong.Click += new System.EventHandler(this.button_Xemdoituong_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(521, 214);
            this.Controls.Add(this.button_Xemdoituong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_QuanLyRole);
            this.Controls.Add(this.button_QuanLyUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_QuanLyUser;
        private System.Windows.Forms.Button button_QuanLyRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Xemdoituong;
    }
}