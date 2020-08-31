namespace GiaoDien
{
    partial class GrantRole
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
            this.comboBox_ListQuyen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ListRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_option = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_Revoke
            // 
            this.button_Revoke.BackColor = System.Drawing.Color.Red;
            this.button_Revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Revoke.ForeColor = System.Drawing.Color.White;
            this.button_Revoke.Location = new System.Drawing.Point(241, 185);
            this.button_Revoke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Revoke.Name = "button_Revoke";
            this.button_Revoke.Size = new System.Drawing.Size(82, 32);
            this.button_Revoke.TabIndex = 49;
            this.button_Revoke.Text = "Revoke";
            this.button_Revoke.UseVisualStyleBackColor = false;
            this.button_Revoke.Click += new System.EventHandler(this.button_Revoke_Click);
            // 
            // button_grant
            // 
            this.button_grant.BackColor = System.Drawing.Color.Green;
            this.button_grant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grant.ForeColor = System.Drawing.Color.White;
            this.button_grant.Location = new System.Drawing.Point(154, 185);
            this.button_grant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_grant.Name = "button_grant";
            this.button_grant.Size = new System.Drawing.Size(82, 32);
            this.button_grant.TabIndex = 48;
            this.button_grant.Text = "Grant";
            this.button_grant.UseVisualStyleBackColor = false;
            this.button_grant.Click += new System.EventHandler(this.button_grant_Click);
            // 
            // comboBox_ListQuyen
            // 
            this.comboBox_ListQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ListQuyen.FormattingEnabled = true;
            this.comboBox_ListQuyen.Items.AddRange(new object[] {
            "create session",
            "create user",
            "drop user",
            "create role",
            "create table",
            "insert any table",
            "update any table",
            "select any table",
            "create procedure",
            "drop any procedure",
            "drop any table"});
            this.comboBox_ListQuyen.Location = new System.Drawing.Point(154, 127);
            this.comboBox_ListQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_ListQuyen.Name = "comboBox_ListQuyen";
            this.comboBox_ListQuyen.Size = new System.Drawing.Size(171, 21);
            this.comboBox_ListQuyen.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Chọn quyền:";
            // 
            // comboBox_ListRole
            // 
            this.comboBox_ListRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ListRole.FormattingEnabled = true;
            this.comboBox_ListRole.Location = new System.Drawing.Point(154, 78);
            this.comboBox_ListRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_ListRole.Name = "comboBox_ListRole";
            this.comboBox_ListRole.Size = new System.Drawing.Size(171, 21);
            this.comboBox_ListRole.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Chọn role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(2, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "CẤP/THU HỒI QUYỀN CỦA ROLE";
            // 
            // checkBox_option
            // 
            this.checkBox_option.AutoSize = true;
            this.checkBox_option.Location = new System.Drawing.Point(342, 129);
            this.checkBox_option.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_option.Name = "checkBox_option";
            this.checkBox_option.Size = new System.Drawing.Size(108, 17);
            this.checkBox_option.TabIndex = 50;
            this.checkBox_option.Text = "with admin option";
            this.checkBox_option.UseVisualStyleBackColor = true;
            // 
            // GrantRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(461, 232);
            this.Controls.Add(this.checkBox_option);
            this.Controls.Add(this.button_Revoke);
            this.Controls.Add(this.button_grant);
            this.Controls.Add(this.comboBox_ListQuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ListRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrantRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Revoke;
        private System.Windows.Forms.Button button_grant;
        private System.Windows.Forms.ComboBox comboBox_ListQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_ListRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_option;
    }
}