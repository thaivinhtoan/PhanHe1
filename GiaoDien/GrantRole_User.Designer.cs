namespace GiaoDien
{
    partial class GrantRole_User
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
            this.button_Revoke = new System.Windows.Forms.Button();
            this.button_grant = new System.Windows.Forms.Button();
            this.comboBox_ListUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ListRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Revoke
            // 
            this.button_Revoke.BackColor = System.Drawing.Color.Red;
            this.button_Revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Revoke.ForeColor = System.Drawing.Color.White;
            this.button_Revoke.Location = new System.Drawing.Point(302, 261);
            this.button_Revoke.Name = "button_Revoke";
            this.button_Revoke.Size = new System.Drawing.Size(110, 39);
            this.button_Revoke.TabIndex = 56;
            this.button_Revoke.Text = "Revoke";
            this.button_Revoke.UseVisualStyleBackColor = false;
            this.button_Revoke.Click += new System.EventHandler(this.button_Revoke_Click);
            // 
            // button_grant
            // 
            this.button_grant.BackColor = System.Drawing.Color.Green;
            this.button_grant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grant.ForeColor = System.Drawing.Color.White;
            this.button_grant.Location = new System.Drawing.Point(185, 261);
            this.button_grant.Name = "button_grant";
            this.button_grant.Size = new System.Drawing.Size(110, 39);
            this.button_grant.TabIndex = 55;
            this.button_grant.Text = "Grant";
            this.button_grant.UseVisualStyleBackColor = false;
            this.button_grant.Click += new System.EventHandler(this.button_grant_Click);
            // 
            // comboBox_ListUser
            // 
            this.comboBox_ListUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ListUser.FormattingEnabled = true;
            this.comboBox_ListUser.Location = new System.Drawing.Point(185, 190);
            this.comboBox_ListUser.Name = "comboBox_ListUser";
            this.comboBox_ListUser.Size = new System.Drawing.Size(227, 24);
            this.comboBox_ListUser.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Chọn user:";
            // 
            // comboBox_ListRole
            // 
            this.comboBox_ListRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ListRole.FormattingEnabled = true;
            this.comboBox_ListRole.Location = new System.Drawing.Point(185, 130);
            this.comboBox_ListRole.Name = "comboBox_ListRole";
            this.comboBox_ListRole.Size = new System.Drawing.Size(227, 24);
            this.comboBox_ListRole.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Chọn role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 39);
            this.label2.TabIndex = 50;
            this.label2.Text = "Cấp/thu hồi role của user";
            // 
            // GrantRole_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 310);
            this.Controls.Add(this.button_Revoke);
            this.Controls.Add(this.button_grant);
            this.Controls.Add(this.comboBox_ListUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ListRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrantRole_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantRole_User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GrantRole_User_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Revoke;
        private System.Windows.Forms.Button button_grant;
        private System.Windows.Forms.ComboBox comboBox_ListUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_ListRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}