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
    public partial class FormObject : Form
    {
        public FormObject()
        {
            InitializeComponent();
            LoadObject();
        }

        private void LoadObject()
        {
            this.objectlv.BeginUpdate();
            this.objectlv.Clear();
            this.objectlv.Columns.Add("Object Name", 250);
            this.objectlv.Columns.Add("Subobject Name", 250);
            this.objectlv.Columns.Add("Object Type", 150);

            var objs = new Business_Logic_Layer.BLL().get_DsObject();

            foreach (var obj in objs)
            {
                String[] item = new String[3];
                item[0] = obj.object_name;
                item[1] = obj.subobject_name;
                item[2] = obj.object_type;

                ListViewItem ob = new ListViewItem(item);
                this.objectlv.Items.Add(ob);
            }

            this.objectlv.View = View.Details;
            this.objectlv.EndUpdate();


        }

        private void FormObject_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form fadmin = new FormAdmin();
            fadmin.ShowDialog();
            this.Close();
        }
    }
}
