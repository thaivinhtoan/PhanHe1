using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class LogManagementFrm : Form
    {
        public LogManagementFrm()
        {
            InitializeComponent();
        }

        private void AuditAllBtn_Click(object sender, EventArgs e)
        {
            Form AuditAllFrm = new AuditAllForm();
            AuditAllFrm.ShowDialog();
        }

        private void AuditConditionBtn_Click(object sender, EventArgs e)
        {
            Form AuditConditionFrm = new AuditConditionForm();
            AuditConditionFrm.ShowDialog();
        }

        private void CheckLogBtn_Click(object sender, EventArgs e)
        {
            Form CheckLogFrm = new CheckLogForm();
            CheckLogFrm.ShowDialog();
        }
    }
}
