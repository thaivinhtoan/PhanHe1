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
    public partial class GrantRole_User : Form
    {
        public GrantRole_User()
        {
            InitializeComponent();
            LoadDsRole();
            LoadDsUser();
        }
        private void LoadDsRole()
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsRole();
            comboBox_ListRole.DataSource = dsUser;
            comboBox_ListRole.DisplayMember = "username";
        }
        private void LoadDsUser()
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsUser();
            comboBox_ListUser.DataSource = dsUser;
            comboBox_ListUser.DisplayMember = "username";
        }
        private void button_grant_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var capquyen = new Entity_Object.CapQuyen();
            capquyen.username = comboBox_ListRole.Text;
            capquyen.name_privs = comboBox_ListUser.Text;
            var grant = bll.Grant_Role_To_User(capquyen);
            MessageBox.Show("Grant role cho user thành công", "*****THÔNG BÁO*****");
        }

        private void button_Revoke_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var capquyen = new Entity_Object.CapQuyen();
            capquyen.username = comboBox_ListRole.Text;
            capquyen.name_privs = comboBox_ListUser.Text;
            var kt = bll.KT_user_Role(capquyen.name_privs, capquyen.username);
            if (kt)
            {
                var grant = bll.Revoke_Role_To_User(capquyen);
                MessageBox.Show("Revoke role của user thành công", "*****THÔNG BÁO*****");
            }
            else
            {
                MessageBox.Show("Revoke role cua user không thành công", "*****THÔNG BÁO*****");
            }

        }
        
        private void GrantRole_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form f = new User();
            f.ShowDialog();
            this.Close();
        }
    }
}
