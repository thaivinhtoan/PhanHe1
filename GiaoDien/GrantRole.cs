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
    public partial class GrantRole : Form
    {
        public GrantRole()
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

        private void button_grant_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var capquyen_option = new Entity_Object.CapQuyenOption();
            capquyen_option.username = comboBox_ListRole.Text;
            capquyen_option.name_privs = comboBox_ListQuyen.Text;
            var str = checkBox_option.CheckState == CheckState.Checked ? "with admin option" : checkBox_option.CheckState == CheckState.Unchecked ? " " : " ";
            capquyen_option.option = str;
            var grant = bll.Grant_privs_option(capquyen_option);
            MessageBox.Show("Grant quyền cho role thành công", "*****THÔNG BÁO*****");

        }

        private void button_Revoke_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var capquyen = new Entity_Object.CapQuyen();
            capquyen.username = comboBox_ListRole.Text;
            capquyen.name_privs = comboBox_ListQuyen.Text;
            var kt = bll.KT_QuyenCua_Role(capquyen.username, capquyen.name_privs);
            if (kt)
            {
                var grant = bll.Revoke_privs_Role(capquyen);
                MessageBox.Show("Revoke quyền của role thành công", "*****THÔNG BÁO*****");
            }
            else
            {
                MessageBox.Show("Revoke quyền của role không thành công", "*****THÔNG BÁO*****");
            }                      
        }

    }
}
