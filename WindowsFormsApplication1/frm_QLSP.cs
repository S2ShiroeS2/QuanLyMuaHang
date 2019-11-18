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
    public partial class frm_QLSP : Form
    {
        public frm_QLSP()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }

        List<ListViewItem> list_SanPham = new List<ListViewItem>();
        SanPhamController navigate_SanPham = new SanPhamController();
        public static ListViewItem lvi_sanPham { get; private set; } = new ListViewItem();
        public static bool flag_sp { get; private set; } = true;

        private void Form_QLSP_Load(object sender, EventArgs e)
        {
            list_SanPham = navigate_SanPham.Load_List_San_Pham();
            foreach (ListViewItem SanPham in list_SanPham)
            {
                lstv_list_SP.Items.Add(SanPham);
            }
        }

        private void btn_tim_kiem_SP_Click(object sender, EventArgs e)
        {
            list_SanPham.Clear();
            lstv_list_SP.Items.Clear();
            list_SanPham = navigate_SanPham.Search_Product(txt_tim_kiem_SP.Text);
            if (txt_tim_kiem_SP.Text.Length > 0)
            {
                foreach (ListViewItem item in list_SanPham)
                {
                    lstv_list_SP.Items.Add(item);
                }
            }
            else
                lam_moi();
            
        }

        private void lam_moi()
        {
            list_SanPham.Clear();
            lstv_list_SP.Items.Clear();
            list_SanPham = navigate_SanPham.Load_List_San_Pham();

            foreach (ListViewItem V in list_SanPham)
                lstv_list_SP.Items.Add(V);
        }

        private void lstv_list_SP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            flag_sp = false; // Lúc sửa sản phẩm
            frm_CTSP GUI_CTSP = new frm_CTSP();
            GUI_CTSP.ShowDialog();
            lam_moi();
        }

        private void lstv_list_SP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv_list_SP.SelectedItems.Count > 0)
                lvi_sanPham = lstv_list_SP.SelectedItems[0];
        }

        private void btn_tao_moi_SP_Click(object sender, EventArgs e)
        {
            flag_sp = true; //Lúc tạo mới
            if(flag_sp == true)
            {
                lvi_sanPham = new ListViewItem();
                frm_CTSP GUI_CTSP = new frm_CTSP();
                GUI_CTSP.ShowDialog();
                lam_moi();
            }
        }
    }
}
