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
    public partial class GrantPrivs : Form
    {
        public GrantPrivs()
        {
            InitializeComponent();
            LoadUser();
        }

        private void LoadUser()
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsUser();
            comboBox_DsUser.DataSource = dsUser;
            comboBox_DsUser.DisplayMember = "username";
        }

        private void button_grant_Click(object sender, EventArgs e)
        {
            //BLL bll = new BLL();

            //var capquyen = new Entity_Object.CapQuyen();
            //capquyen.username = comboBox_DsUser.Text;
            //capquyen.name_privs = comboBox_ListQuyen.Text;
            //var grant = bll.Grant_privs(capquyen);
            //MessageBox.Show("Grant privilege successful!", "*****Notification*****");
            BLL bll = new BLL();

            var capquyen_option = new Entity_Object.CapQuyenOption();
            capquyen_option.username = comboBox_DsUser.Text;
            capquyen_option.name_privs = comboBox_ListQuyen.Text;
            var str = checkBox_option.CheckState == CheckState.Checked ? "with admin option" : "";
            capquyen_option.option = str;
            var grant = bll.Grant_privs_option(capquyen_option);
            MessageBox.Show("Grant quyền thành công", "*****THÔNG BÁO*****");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var capquyen = new Entity_Object.CapQuyen();
            capquyen.username = comboBox_DsUser.Text;
            capquyen.name_privs = comboBox_ListQuyen.Text;
            var kt = bll.KT_QuyenCua_User(capquyen.username, capquyen.name_privs);
            if(kt)
            {
                var grant = bll.Revoke_privs(capquyen);
                MessageBox.Show("Revoke quyền thành công", "*****THÔNG BÁO*****");
            }
            else
            {
                MessageBox.Show("Revoke quyền không thành công", "*****THÔNG BÁO*****");
            }
            
        }

        private void GrantPrivs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form f = new User();
            f.ShowDialog();
            this.Close();
        }
    }
}
