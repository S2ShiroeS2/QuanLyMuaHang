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
        public delegate void SendMessage(List<ListViewItem> value);
        List<ListViewItem> list_Ncc = new List<ListViewItem>();
        SanPhamController navigate_SanPham = new SanPhamController();
        public static bool flag { get; private set; } = true;
        public static ListViewItem lvi_SanPham { get; private set; } = new ListViewItem();
        //Load dữ liệu lên form chi tiết sản phẩm
        private void form_CTSP_Load(object sender, EventArgs e)
        {
            if(Form_QLSP.flag_sp==false) // Sửa sản phẩm
            {
                txt_ma_sp.Text = Form_QLSP.lvi_sanPham.SubItems[0].Text;
                txt_ten_sp.Text = Form_QLSP.lvi_sanPham.SubItems[1].Text;
               
                foreach(var loai in cbo_loai_sp.Items)
                {
                    if(loai.ToString()== Form_QLSP.lvi_sanPham.SubItems[2].Text)
                        cbo_loai_sp.SelectedItem = loai;
                }
                cbo_danh_muc_sp.Text = Form_QLSP.lvi_sanPham.SubItems[3].Text;
                txt_so_luong_sp.Text = Form_QLSP.lvi_sanPham.SubItems[4].Text;
                txt_gia_sp.Text = Form_QLSP.lvi_sanPham.SubItems[5].Text;
                txt_nha_sx.Text = Form_QLSP.lvi_sanPham.SubItems[6].Text;
                list_Ncc = navigate_SanPham.Load_List_Ncc(Convert.ToInt16(txt_ma_sp.Text));
                enable_Control(Form_QLSP.flag_sp);
                foreach (ListViewItem a in list_Ncc)
                    lstv_nha_cung_cap.Items.Add(a);
                //Them moi nha cc
            }
            else //Tạo mới
            {
                //enable_Control(flag);
                txt_ma_sp.Text = (navigate_SanPham.GetMax_ProductCategoryID() + 1).ToString();

            }
        }
        //Hiện những trường cần thiết để chỉnh sửa thông tin
        private void enable_Control(bool flag)
        {
            txt_ten_sp.Enabled = txt_gia_sp.Enabled = txt_nha_sx.Enabled = txt_so_luong_sp.Enabled = cbo_danh_muc_sp.Enabled = cbo_loai_sp.Enabled = lstv_nha_cung_cap.Enabled = btn_luu.Enabled = btn_them_ncc.Enabled = flag;
            btn_sua.Enabled = !flag;
        }
        private void UpdateNCC(List<ListViewItem> value)
        {
            list_Ncc.Clear();
            foreach (ListViewItem a in value)
                list_Ncc.Add(a);           
            


        }
        //Nút Sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            enable_Control(true);
        }

        private void btn_them_ncc_Click(object sender, EventArgs e)
        {
            frm_themNhaCungCap GUI_NCC = new frm_themNhaCungCap(UpdateNCC);
            foreach (ListViewItem a in list_Ncc)
                GUI_NCC.list_Ncc_update.Add(a);
            GUI_NCC.ShowDialog();
            lstv_nha_cung_cap.Items.Clear();
            lstv_nha_cung_cap.Refresh();
            foreach (ListViewItem a in list_Ncc)
            {
                ListViewItem tmp = new ListViewItem();
                tmp.Text = a.Text;
                lstv_nha_cung_cap.Items.Add(tmp);
            }
                
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            lvi_SanPham = new ListViewItem();
            lvi_SanPham.SubItems.Add(txt_ma_sp.Text);
            lvi_SanPham.SubItems.Add(txt_ten_sp.Text);
            lvi_SanPham.SubItems.Add(cbo_loai_sp.SelectedItem.ToString());
            lvi_SanPham.SubItems.Add(cbo_danh_muc_sp.SelectedItem.ToString());
            lvi_SanPham.SubItems.Add(txt_so_luong_sp.Text);
            lvi_SanPham.SubItems.Add(txt_nha_sx.Text);
        }

        private void lstv_nha_cung_cap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
