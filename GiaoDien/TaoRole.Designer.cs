namespace GiaoDien
{
    partial class TaoRole
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rolename = new System.Windows.Forms.TextBox();
            this.MSSV = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(92, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 39);
            this.label2.TabIndex = 39;
            this.label2.Text = "TẠO ROLE";
            // 
            // textBox_rolename
            // 
            this.textBox_rolename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rolename.Location = new System.Drawing.Point(119, 91);
            this.textBox_rolename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_rolename.Name = "textBox_rolename";
            this.textBox_rolename.Size = new System.Drawing.Size(198, 26);
            this.textBox_rolename.TabIndex = 38;
            // 
            // MSSV
            // 
            this.MSSV.AutoEllipsis = true;
            this.MSSV.BackColor = System.Drawing.Color.SandyBrown;
            this.MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSSV.Location = new System.Drawing.Point(14, 89);
            this.MSSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MSSV.Name = "MSSV";
            this.MSSV.Size = new System.Drawing.Size(100, 30);
            this.MSSV.TabIndex = 37;
            this.MSSV.Text = "Role name:";
            this.MSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.SandyBrown;
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.ForeColor = System.Drawing.Color.Black;
            this.button_Submit.Location = new System.Drawing.Point(119, 140);
            this.button_Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(174, 43);
            this.button_Submit.TabIndex = 40;
            this.button_Submit.Text = "TẠO ROLE";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // TaoRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(341, 210);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_rolename);
            this.Controls.Add(this.MSSV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaoRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rolename;
        private System.Windows.Forms.Label MSSV;
        private System.Windows.Forms.Button button_Submit;
    }
}