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
    public partial class Form_QLNV : Form
    {
        public Form_QLNV()
        {
            InitializeComponent();
        }

        List<ListViewItem> list_NV = new List<ListViewItem>();
        NhanVienController NVC = new NhanVienController();

        private void Form_QLNV_Load(object sender, EventArgs e)
        {
            list_NV = NVC.NhanVienList();

            foreach (ListViewItem Nv in list_NV)
                lv_list_NV.Items.Add(Nv);
        }
    }
}
