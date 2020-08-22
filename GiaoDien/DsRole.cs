using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace GiaoDien
{
    public partial class DsRole : Form
    {
        public DsRole()
        {
            InitializeComponent();
            LoadDsRole();
        }
        private void LoadDsRole()
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsRole();
            comboBox_ListRole.DataSource = dsUser;
            comboBox_ListRole.DisplayMember = "username";
        }

        private void DsRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form f = new Role();
            f.ShowDialog();
            this.Close();
        }
    }
}
