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
    public partial class form_CTSP : Form
    {
        public form_CTSP()
        {
            InitializeComponent();
        }
        List<ListViewItem> list_Ncc = new List<ListViewItem>();
        SanPhamController navigate_SanPham = new SanPhamController();
        public static bool flag { get; private set; } = true;
        private void form_CTSP_Load(object sender, EventArgs e)
        {
            if(Form_QLSP.flag_sp==false)
            {
                txt_ma_sp.Text = Form_QLSP.lvi_sanPham.SubItems[0].Text;
                txt_ten_sp.Text = Form_QLSP.lvi_sanPham.SubItems[1].Text;
                cbo_loai_sp.Text = Form_QLSP.lvi_sanPham.SubItems[2].Text;
                cbo_danh_muc_sp.Text = Form_QLSP.lvi_sanPham.SubItems[3].Text;
                txt_so_luong_sp.Text = Form_QLSP.lvi_sanPham.SubItems[4].Text;
                txt_gia_sp.Text = Form_QLSP.lvi_sanPham.SubItems[5].Text;
                txt_nha_sx.Text = Form_QLSP.lvi_sanPham.SubItems[6].Text;
                list_Ncc = navigate_SanPham.Load_List_Ncc(Convert.ToInt16(txt_ma_sp.Text));
                enable_Control(Form_QLSP.flag_sp);
                foreach (ListViewItem a in list_Ncc)
                    lstv_nha_cung_cap.Items.Add(a);
            }
            else
            {

            }
        }
        private void enable_Control(bool flag)
        {
            txt_ten_sp.Enabled = txt_gia_sp.Enabled = txt_nha_sx.Enabled = txt_so_luong_sp.Enabled = cbo_danh_muc_sp.Enabled = cbo_loai_sp.Enabled = lstv_nha_cung_cap.Enabled = btn_luu.Enabled = flag;
            btn_sua.Enabled = !flag;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            enable_Control(true);
        }
    }
}
