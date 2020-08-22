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
            this.button_Cancle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_ThongTinQuyen
            // 
            this.listView_ThongTinQuyen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Privilege});
            this.listView_ThongTinQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ThongTinQuyen.HideSelection = false;
            this.listView_ThongTinQuyen.Location = new System.Drawing.Point(12, 133);
            this.listView_ThongTinQuyen.Name = "listView_ThongTinQuyen";
            this.listView_ThongTinQuyen.Size = new System.Drawing.Size(438, 202);
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
            this.comboBox_DsRole.Location = new System.Drawing.Point(171, 83);
            this.comboBox_DsRole.Name = "comboBox_DsRole";
            this.comboBox_DsRole.Size = new System.Drawing.Size(279, 24);
            this.comboBox_DsRole.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Chọn role:";
            // 
            // button_Cancle
            // 
            this.button_Cancle.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancle.ForeColor = System.Drawing.Color.White;
            this.button_Cancle.Location = new System.Drawing.Point(315, 354);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(135, 42);
            this.button_Cancle.TabIndex = 42;
            this.button_Cancle.Text = "Cancel";
            this.button_Cancle.UseVisualStyleBackColor = false;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 39);
            this.label2.TabIndex = 41;
            this.label2.Text = "Thông tin về quyền của role";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(151, 354);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(133, 42);
            this.button_search.TabIndex = 40;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Quyen_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 411);
            this.Controls.Add(this.listView_ThongTinQuyen);
            this.Controls.Add(this.comboBox_DsRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quyen_Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quyen_Role";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quyen_Role_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_ThongTinQuyen;
        private System.Windows.Forms.ColumnHeader Privilege;
        private System.Windows.Forms.ComboBox comboBox_DsRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search;
    }
}