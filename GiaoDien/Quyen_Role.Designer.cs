namespace GiaoDien
{
    partial class Quyen_Role
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
            this.Privilege = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_DsRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_ThongTinQuyen
            // 
            this.listView_ThongTinQuyen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Privilege});
            this.listView_ThongTinQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ThongTinQuyen.HideSelection = false;
            this.listView_ThongTinQuyen.Location = new System.Drawing.Point(9, 108);
            this.listView_ThongTinQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.listView_ThongTinQuyen.Name = "listView_ThongTinQuyen";
            this.listView_ThongTinQuyen.Size = new System.Drawing.Size(426, 215);
            this.listView_ThongTinQuyen.TabIndex = 39;
            this.listView_ThongTinQuyen.UseCompatibleStateImageBehavior = false;
            this.listView_ThongTinQuyen.View = System.Windows.Forms.View.Details;
            // 
            // Privilege
            // 
            this.Privilege.Text = "Privilege";
            this.Privilege.Width = 317;
            // 
            // comboBox_DsRole
            // 
            this.comboBox_DsRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DsRole.FormattingEnabled = true;
            this.comboBox_DsRole.Location = new System.Drawing.Point(211, 70);
            this.comboBox_DsRole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_DsRole.Name = "comboBox_DsRole";
            this.comboBox_DsRole.Size = new System.Drawing.Size(210, 21);
            this.comboBox_DsRole.TabIndex = 44;
            this.comboBox_DsRole.SelectedIndexChanged += new System.EventHandler(this.comboBox_DsRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Chọn role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "DANH SÁCH QUYỀN CỦA ROLE";
            // 
            // Quyen_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(446, 334);
            this.Controls.Add(this.listView_ThongTinQuyen);
            this.Controls.Add(this.comboBox_DsRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quyen_Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quyen_Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_ThongTinQuyen;
        private System.Windows.Forms.ColumnHeader Privilege;
        private System.Windows.Forms.ComboBox comboBox_DsRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}