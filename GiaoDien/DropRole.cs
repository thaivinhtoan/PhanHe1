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
using Entity_Object;
namespace GiaoDien
{
    public partial class DropRole : Form
    {
        private DanhSachUser ds = null;
        public DropRole()
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

        private void button_Submit_Click(object sender, EventArgs e)
        {
            var services = new BLL();
            var user_drop = new DanhSachUser();
            user_drop.username = comboBox_ListRole.Text;
            ds = services.Drop_role(user_drop);
            MessageBox.Show("Drop role thành công", "*****THÔNG BÁO*****");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DropRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form f = new Role();
            f.ShowDialog();
            this.Close();
        }
    }
}
