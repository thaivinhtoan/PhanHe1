using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void button_TaoRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form tao_role = new TaoRole();
            tao_role.ShowDialog();
            this.Close();
        }

        private void button_XoaRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form drop_role = new DropRole();
            drop_role.ShowDialog();
            this.Close();
        }

        private void button_XemDsRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Dsrole = new DsRole();
            Dsrole.ShowDialog();
            this.Close();
        }

        private void button_CapQuyenUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Grantrole = new GrantRole();
            Grantrole.ShowDialog();
            this.Close();
        }

        private void button_ThongTinVeQuyenUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fqr = new FormQuyenRole();
            fqr.ShowDialog();
            this.Close();
        }


        private void button_ThongTinQuyenCuaRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Quyen_Role();
            f.ShowDialog();
            this.Close();
        }
    }
}
