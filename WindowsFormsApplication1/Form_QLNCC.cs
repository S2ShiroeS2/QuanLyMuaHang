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
        ListViewItem lvi_vendor = new ListViewItem();
        VendorController VC = new VendorController();

        private void Form_QLNCC_Load(object sender, EventArgs e)
        {
            lvi_vendor = VC.VendorList();
            
            lv_list_ncc.Items.Add(lvi_vendor);
        }
    }
}
