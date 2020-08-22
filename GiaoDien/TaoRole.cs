using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Object;
using Business_Logic_Layer;
namespace GiaoDien
{
    public partial class TaoRole : Form
    {
        private DanhSachUser ds = null;
        public TaoRole()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            var services = new BLL();
            var role_create = new Entity_Object.DanhSachUser();
            role_create.username = textBox_rolename.Text;
            var tontai = services.TonTaiRole(role_create.username);
            if (tontai)
            {
                MessageBox.Show("Role đã tồn tại");
                return;
            }
            ds = services.Create_role(role_create);
            MessageBox.Show("Tạo role thành công", "*****THÔNG BÁO*****");
        }

        private void TaoRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form f = new Role();
            f.ShowDialog();
            this.Close();
        }
    }
}
