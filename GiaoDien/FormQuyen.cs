﻿using System;
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
    public partial class FormQuyen : Form
    {
        public FormQuyen()
        {
            InitializeComponent();
        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var username = textBox_username.Text;
            BLL bll = new BLL();
            var quyen = bll.Lay_DsQuyen(username);
            ListQuyen_To_ListView(listView_ThongTinQuyen, quyen);


        }
        private void ListQuyen_To_ListView(ListView listView_ThongTinQuyen, List<Quyen> quyen)
        {
            listView_ThongTinQuyen.Items.Clear();
            foreach(var privs in quyen)
            {
                ListViewItem item = new ListViewItem();
                item.Text = privs.grantee;
                item.SubItems.Add(privs.privilege);
                item.SubItems.Add(privs.admin_option);
                item.SubItems.Add(privs.common);
                item.SubItems.Add(privs.inheritied);
                listView_ThongTinQuyen.Items.Add(item);
                item.Tag = privs;
              
            }
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView_ThongTinQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormQuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form f = new User();
            f.ShowDialog();
            this.Close();
        }
    }
}
