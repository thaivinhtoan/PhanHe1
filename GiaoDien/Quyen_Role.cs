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
    public partial class Quyen_Role : Form
    {
        public Quyen_Role()
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
        private void button_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListQuyen_To_ListView(ListView listView_ThongTinQuyen, List<string> dsquyen)
        {
            listView_ThongTinQuyen.Items.Clear();
            foreach (var ds in dsquyen)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ds;
                listView_ThongTinQuyen.Items.Add(item);
                item.Tag = ds;
            }
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var dsquyen = bll.Lay_Quyen_UngVoiRole(comboBox_DsRole.Text);
            ListQuyen_To_ListView(listView_ThongTinQuyen, dsquyen);            
        }

        private void Quyen_Role_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form f = new Role();
            f.ShowDialog();
            this.Close();
        }
    }
}
