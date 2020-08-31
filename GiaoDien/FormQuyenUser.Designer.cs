namespace GiaoDien
{
    partial class FormQuyenUser
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
            this.listView_ThongTinQuyen = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Privilege = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin_option = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Common = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inherited = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_dsQuyen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView_ThongTinQuyen
            // 
            this.listView_ThongTinQuyen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Privilege,
            this.Admin_option,
            this.Common,
            this.Inherited});
            this.listView_ThongTinQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ThongTinQuyen.HideSelection = false;
            this.listView_ThongTinQuyen.Location = new System.Drawing.Point(9, 120);
            this.listView_ThongTinQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView_ThongTinQuyen.Name = "listView_ThongTinQuyen";
            this.listView_ThongTinQuyen.Size = new System.Drawing.Size(775, 253);
            this.listView_ThongTinQuyen.TabIndex = 27;
            this.listView_ThongTinQuyen.UseCompatibleStateImageBehavior = false;
            this.listView_ThongTinQuyen.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 130;
            // 
            // Privilege
            // 
            this.Privilege.Text = "Privilege";
            this.Privilege.Width = 317;
            // 
            // Admin_option
            // 
            this.Admin_option.Text = "Admin_option";
            this.Admin_option.Width = 141;
            // 
            // Common
            // 
            this.Common.Text = "Common";
            this.Common.Width = 110;
            // 
            // Inherited
            // 
            this.Inherited.Text = "Inherited";
            this.Inherited.Width = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chọn username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "DS QUYỀN CỦA USER";
            // 
            // comboBox_dsQuyen
            // 
            this.comboBox_dsQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dsQuyen.FormattingEnabled = true;
            this.comboBox_dsQuyen.Location = new System.Drawing.Point(613, 78);
            this.comboBox_dsQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_dsQuyen.Name = "comboBox_dsQuyen";
            this.comboBox_dsQuyen.Size = new System.Drawing.Size(171, 21);
            this.comboBox_dsQuyen.TabIndex = 32;
            this.comboBox_dsQuyen.SelectedIndexChanged += new System.EventHandler(this.comboBox_dsQuyen_SelectedIndexChanged);
            // 
            // FormQuyenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(795, 384);
            this.Controls.Add(this.comboBox_dsQuyen);
            this.Controls.Add(this.listView_ThongTinQuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuyenUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuyenUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_ThongTinQuyen;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Privilege;
        private System.Windows.Forms.ColumnHeader Admin_option;
        private System.Windows.Forms.ColumnHeader Common;
        private System.Windows.Forms.ColumnHeader Inherited;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_dsQuyen;
    }
}