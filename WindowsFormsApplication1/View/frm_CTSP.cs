using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;
namespace WindowsFormsApplication1
{
    public partial class frm_CTSP : Form
    {
        public frm_CTSP()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }
        public static List<ListViewItem> list_Ncc = new List<ListViewItem>();
        SanPhamController navigate_SanPham = new SanPhamController();
        public static bool flag { get; private set; } = true;
        public static ListViewItem lvi_SanPham { get; private set; } = new ListViewItem();
        public static int id_sp { get; private set; } = -1;
        //Load dữ liệu lên form chi tiết sản phẩm
        private void form_CTSP_Load(object sender, EventArgs e)
        {
            list_Ncc=new List<ListViewItem>();
            if(frm_QLSP.flag_sp==false) // Sửa sản phẩm
            {
                txt_ma_sp.Text = frm_QLSP.lvi_sanPham.SubItems[0].Text;
                txt_ten_sp.Text = frm_QLSP.lvi_sanPham.SubItems[1].Text; 
                foreach(var loai in cbo_loai_sp.Items)
                {
                    if(loai.ToString()== frm_QLSP.lvi_sanPham.SubItems[2].Text)
                        cbo_loai_sp.SelectedItem = loai;
                }
                lam_moi_cbo_danh_muc();
                cbo_danh_muc_sp.SelectedItem = frm_QLSP.lvi_sanPham.SubItems[3].Text;
                txt_nha_sx.Text = frm_QLSP.lvi_sanPham.SubItems[4].Text;
                list_Ncc = navigate_SanPham.Load_List_Ncc(Convert.ToInt16(txt_ma_sp.Text));
                enable_Control(frm_QLSP.flag_sp);
                foreach (ListViewItem a in list_Ncc)
                    lstv_nha_cung_cap.Items.Add(a);
            }
            else //Tạo mới
            {
                flag = true;
                txt_ma_sp.Text = (navigate_SanPham.GetMax_ProductID() + 1).ToString();
                lam_moi_cbo_danh_muc();
                btn_sua.Enabled = false;

            }
        }
        //Hiện những trường cần thiết để chỉnh sửa thông tin
        private void enable_Control(bool flag)
        {
            txt_ten_sp.Enabled = txt_nha_sx.Enabled = cbo_danh_muc_sp.Enabled = cbo_loai_sp.Enabled = lstv_nha_cung_cap.Enabled = btn_luu.Enabled = btn_them_ncc.Enabled = flag;
            btn_sua.Enabled = !flag;
        }
        //Nút Sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            enable_Control(true);
            flag = false;
        }

        private void btn_them_ncc_Click(object sender, EventArgs e)
        {
            list_Ncc.Clear();
            foreach(ListViewItem i in lstv_nha_cung_cap.Items)
            {
                list_Ncc.Add(i);
            }
            frm_ChiTiet_NCC_SanPham GUI_NCC = new frm_ChiTiet_NCC_SanPham();
            id_sp = Convert.ToInt32( txt_ma_sp.Text);
            GUI_NCC.ShowDialog();
            if(frm_ChiTiet_NCC_SanPham.list!=null&& frm_ChiTiet_NCC_SanPham.flag==true)
            {
                lstv_nha_cung_cap.Items.Clear();
                foreach (ListViewItem a in frm_ChiTiet_NCC_SanPham.list)
                {
                    ListViewItem tmp = new ListViewItem();
                    tmp.Text = a.Text;
                    lstv_nha_cung_cap.Items.Add(tmp);
                }
            }
        }

        public void lam_moi_cbo_danh_muc()
        {
            cbo_danh_muc_sp.Items.Clear();
            foreach (var category in navigate_SanPham.load_List_Category())
            {
                cbo_danh_muc_sp.Items.Insert(0, category);
            }
            cbo_danh_muc_sp.Items.Add( "Thêm danh mục");
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (lstv_nha_cung_cap.Items.Count > 0 && txt_nha_sx.Text.Length>0 && txt_ten_sp.Text.Length>0 && cbo_danh_muc_sp.SelectedItem!=null && cbo_loai_sp.SelectedItem!=null&& (txt_ten_sp.Text.Where(c => !Char.IsWhiteSpace(c)).ToArray()).Count()>0 && (txt_nha_sx.Text.Where(c => !Char.IsWhiteSpace(c)).ToArray()).Count() > 0)
            {

                lvi_SanPham = new ListViewItem();
                lvi_SanPham.Text = (txt_ma_sp.Text);
                lvi_SanPham.SubItems.Add(txt_ten_sp.Text);
                lvi_SanPham.SubItems.Add(cbo_loai_sp.SelectedItem.ToString());
                lvi_SanPham.SubItems.Add(cbo_danh_muc_sp.SelectedItem.ToString());
                lvi_SanPham.SubItems.Add(txt_nha_sx.Text);
                if (flag == true)
                {
                    navigate_SanPham.Insert_Product(lvi_SanPham, lstv_nha_cung_cap.Items);
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                {
                    navigate_SanPham.Edit_Poduct(lvi_SanPham, lstv_nha_cung_cap.Items);
                    MessageBox.Show("Lưu thành công!");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Còn dữ liệu chưa nhập vào!");
        }

        private void cbo_danh_muc_sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_danh_muc_sp.SelectedItem.ToString() == "Thêm danh mục")
            {
                frm_Them_danh_muc form_them_dm = new frm_Them_danh_muc();
                this.Hide();
                form_them_dm.ShowDialog();
                lam_moi_cbo_danh_muc();
                cbo_danh_muc_sp.SelectedText = "";
                this.Show();
                
            }
                
        }








    }
}
