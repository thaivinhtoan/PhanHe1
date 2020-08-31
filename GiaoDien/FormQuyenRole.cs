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
    public partial class FormQuyenRole : Form
    {
        public FormQuyenRole()
        {
            InitializeComponent();
            LoadDsRole();
        }
        private void LoadDsRole()
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsRole();
            comboBox_DsRole.DataSource = dsUser;
            comboBox_DsRole.DisplayMember = "username";
        }


        private void ListQuyen_To_ListView(ListView listView_ThongTinQuyen, List<string> quyen)
        {
            listView_ThongTinQuyen.Items.Clear();
            foreach (var privs in quyen)
            {
                ListViewItem item = new ListViewItem();
                item.Text = privs;
                listView_ThongTinQuyen.Items.Add(item);
                item.Tag = privs;
            }
        }



        private void comboBox_DsRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rolename = comboBox_DsRole.Text;
            BLL bll = new BLL();
            var quyen = bll.Lay_DsQuyen_UngVoiRole(rolename);
            ListQuyen_To_ListView(listView_ThongTinQuyen, quyen);
        }
    }
}
