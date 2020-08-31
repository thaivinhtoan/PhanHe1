using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Entity_Object;
using Business_Logic_Layer;
namespace GiaoDien
{
    public partial class DropUser : Form
    {
        private DanhSachUser ds = null;
        public DropUser()
        {
            InitializeComponent();
            LoadDsUser();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            var services = new BLL();
            var user_drop = new DanhSachUser();
            user_drop.username = comboBox_ListUser.Text;
            ds = services.Drop_user(user_drop);
            MessageBox.Show("Drop user thành công", "*****THÔNG BÁO*****");
            
        }

        private void LoadDsUser()
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsUser();
            comboBox_ListUser.DataSource = dsUser;
            comboBox_ListUser.DisplayMember = "username";
        }


    }
}
