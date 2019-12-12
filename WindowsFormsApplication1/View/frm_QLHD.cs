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
    public partial class frm_QLHD : Form
    {
        public frm_QLHD()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }

        QLHD_Controller QLHD_crtl = new QLHD_Controller(); // Khởi tạo biến của QLHD_Controller
        List<ListViewItem> list_lvi_hd = new List<ListViewItem>();// Danh sach lưu thông tin của hóa đơn
        public static bool flag { get; private set; } = true;// Biến kiểm tra xem button tạo mới được click hay là double click ở listview
        public static int hd_id { get; private set; } = new int();
        public static ListViewItem lvi_selected_hd = new ListViewItem();

        private void bt_tao_moi_Click(object sender, EventArgs e)
        {
            flag = true;
            frm_CTHD ct = new frm_CTHD();
            this.Hide();
            ct.ShowDialog();
            lam_moi_listview(); 
            this.Show();


        }

        private void lam_moi_listview()
        {
            list_lvi_hd = new List<ListViewItem>();
            lstv_list_HD.Items.Clear();
            list_lvi_hd = QLHD_crtl.load_list_hd();
            foreach (ListViewItem a in list_lvi_hd)
                lstv_list_HD.Items.Add(a);
        }

        private void frm_QLHD_Load(object sender, EventArgs e)
        {
            lstv_list_HD.Items.Clear();
            list_lvi_hd=QLHD_crtl.load_list_hd();
            foreach (ListViewItem a in list_lvi_hd)
                lstv_list_HD.Items.Add(a);
        }

        private void lstv_list_HD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            flag = !true;
            frm_CTHD ct = new frm_CTHD();
            this.Hide();
            lvi_selected_hd = lstv_list_HD.SelectedItems[0];
            hd_id =Convert.ToInt16( lstv_list_HD.SelectedItems[0].SubItems[0].Text);
            ct.ShowDialog();
            this.Show();
        }

        private void lstv_list_HD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstv_list_HD.SelectedItems.Count>0)
            {
                hd_id = Convert.ToInt16(lstv_list_HD.SelectedItems[0].SubItems[0].Text);
                if (lstv_list_HD.SelectedItems[0].SubItems[4].Text == "Đang yêu cầu")
                    btn_xac_nhan_HD.Enabled = btn_huy_don_hang.Enabled = true;
                else
                    btn_xac_nhan_HD.Enabled=btn_huy_don_hang.Enabled = false;
            }
                
        }

        private void btn_xac_nhan_HD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nhà cung cấp đã giao hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                QLHD_crtl.thay_doi_tinh_trang_HD(Convert.ToInt32(lstv_list_HD.SelectedItems[0].SubItems[0].Text), lstv_list_HD.SelectedItems[0].SubItems[4].Text);
            }
            else
            {
            }
            lam_moi_listview();
            btn_xac_nhan_HD.Enabled =btn_huy_don_hang.Enabled= false;
        }



        private void btn_search_Click(object sender, EventArgs e)
        {
            lam_moi_listview();
            foreach(ListViewItem lvi in lstv_list_HD.Items)
            {
                int kiemtra = 0;
                foreach(ListViewItem.ListViewSubItem sub in lvi.SubItems)
                {
                    if (sub.Text.ToLower().Contains(txt_search.Text.ToLower()) == false)
                    {
                        kiemtra++;
                    }        
                }
                if (kiemtra == lvi.SubItems.Count)
                    lstv_list_HD.Items.Remove(lvi);
            }

        }

        private void lstv_list_HD_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo a=lstv_list_HD.HitTest(e.Location);
            if (e.Button == MouseButtons.Left)
            {
                if (a.Location == ListViewHitTestLocations.None)
                {
                    btn_xac_nhan_HD.Enabled = false;
                    btn_huy_don_hang.Enabled = false;
                }               
            }
        }

        private void btn_huy_don_hang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận hủy đơn hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                QLHD_crtl.huy_HD(Convert.ToInt32(lstv_list_HD.SelectedItems[0].SubItems[0].Text), lstv_list_HD.SelectedItems[0].SubItems[4].Text);
            }
            else
            {
            }
            lam_moi_listview();
            btn_xac_nhan_HD.Enabled = btn_huy_don_hang.Enabled = false;
        }
    }
}
