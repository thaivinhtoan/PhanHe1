namespace GiaoDien
{
    partial class FormObject
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
            this.objectlv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // objectlv
            // 
            this.objectlv.HideSelection = false;
            this.objectlv.Location = new System.Drawing.Point(12, 42);
            this.objectlv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectlv.Name = "objectlv";
            this.objectlv.Size = new System.Drawing.Size(867, 353);
            this.objectlv.TabIndex = 1;
            this.objectlv.UseCompatibleStateImageBehavior = false;
            // 
            // FormObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 423);
            this.Controls.Add(this.objectlv);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormObject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormObject_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView objectlv;
    }
}