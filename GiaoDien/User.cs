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

namespace GiaoDien
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button_XemDsUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form DsUser = new DsUser();
            DsUser.ShowDialog();
            this.Close();
        }

        private void button_TaoUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TaoUser = new TaoUser();
            TaoUser.ShowDialog();
            this.Close();
        }

        private void button_XoaUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form drop_user = new DropUser();
            drop_user.ShowDialog();
            this.Close();
        }

        private void button_CapQuyenUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form grant_privs_user = new GrantPrivs();
            grant_privs_user.ShowDialog();
            this.Close();
        }

        private void button_ThongTinVeQuyenUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form QuyenUser = new FormQuyenUser();
            QuyenUser.ShowDialog();
            this.Close();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form fadmin = new FormAdmin();
            fadmin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form grole_user = new GrantRole_User();
            grole_user.ShowDialog();
            this.Close();
        }
    }
}
