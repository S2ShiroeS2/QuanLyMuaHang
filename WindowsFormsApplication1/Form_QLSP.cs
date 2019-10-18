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
    public partial class Form_QLSP : Form
    {
        public Form_QLSP()
        {
            InitializeComponent();
        }

        List<ListViewItem> list_SanPham = new List<ListViewItem>();
        SanPhamController navigate_SanPham = new SanPhamController();
        public static ListViewItem sanPham { get; private set; } = new ListViewItem();

        private void Form_QLSP_Load(object sender, EventArgs e)
        {
            list_SanPham = navigate_SanPham.Load_List_San_Pham();
            foreach(ListViewItem SanPham in list_SanPham)
            {
                lstv_list_SP.Items.Add(SanPham);
            }
        }

        private void btn_tim_kiem_SP_Click(object sender, EventArgs e)
        {
            list_SanPham.Clear();
            lstv_list_SP.Items.Clear();
        }
    }
}
