using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_QLNCC : Form
    {
        public Form_QLNCC()
        {
            InitializeComponent();
        }
        DataClasses1DataContext a = new DataClasses1DataContext();
        ListViewItem lvi_vendor = new ListViewItem();
        private void Form_QLNCC_Load(object sender, EventArgs e)
        {
            var ncc = from listncc in a.Vendors
                      select listncc;
            foreach(var tmp in ncc)
            {
                lvi_vendor = lv_list_ncc.Items.Add(tmp.VendorID.ToString());
                lvi_vendor.SubItems.Add(tmp.VendorName);
            }
        }
    }
}
