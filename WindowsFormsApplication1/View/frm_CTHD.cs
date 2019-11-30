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
    public partial class frm_CTHD : Form
    {
        public frm_CTHD()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }

        CTHD_controller b = new CTHD_controller();
        CTHD_controller cthd_ctr = new CTHD_controller();
        public static string ncc_name { get; private set; } = "";
        public static bool flag_them_sp { get; private set; } = true;
        public static string ma_hd { get; private set; } = "";
        public static ListViewItem selected_SP { get; private set; } = new ListViewItem();
        double tien_truoc_thue = 0;
        double tien_thue = 0;
        string ncc_previous = "";


        //
        // Hàm dùng để điều khiển các control trong form
        //
        private void enable_control(bool flag)
        {
            btn_luu.Enabled =cbo_nha_cc.Enabled=lstv_list_cthd.Enabled= flag;
        }


        //
        // Load dữ liệu lên form
        //
        private void frm_CTHD_Load(object sender, EventArgs e)
        {
            List<string> list_ncc = cthd_ctr.load_list_ncc();
            foreach (var tmp in list_ncc)
                cbo_nha_cc.Items.Add(tmp);

           if(frm_QLHD.flag==true)                                      // Button tạo mới được click
            {
                enable_control(frm_QLHD.flag);
                txt_Ma_HD.Text = cthd_ctr.tao_ma_hd_moi().ToString();
            }
           else                                                         // Double click vào list view item
            {
                enable_control(frm_QLHD.flag);
                txt_Ma_HD.Text = frm_QLHD.lvi_selected_hd.SubItems[0].Text;
                cbo_nha_cc.SelectedItem = frm_QLHD.lvi_selected_hd.SubItems[2].Text;
                dtpk_ngay_dat_hang.Text = frm_QLHD.lvi_selected_hd.SubItems[1].Text;  
                List<ListViewItem> list_lvi_item = cthd_ctr.load_list_lvi_cthd(frm_QLHD.hd_id);
                foreach (ListViewItem a in list_lvi_item)
                    lstv_list_cthd.Items.Insert(0,a);
            }
            load_tong_tien();
        }

        private void lstv_list_cthd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv_list_cthd.SelectedItems.Count>0 && lstv_list_cthd.SelectedItems[0].Text!= "Thêm sản phẩm")
                btn_Xoa_SP.Enabled = true;
            else
                btn_Xoa_SP.Enabled = false;

        }
        private void lstv_list_cthd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tien_truoc_thue = 0;
            tien_thue = 0;
            CTHD_controller.sp_moi = new ListViewItem();
            if (lstv_list_cthd.SelectedItems[0].Text == "Thêm sản phẩm")
            {
                flag_them_sp = true;
                if (cbo_nha_cc.SelectedItem == null)
                {
                    MessageBox.Show("Bạn chưa chọn nhà cung cấp cho hóa đơn");
                }
                    
                else
                {
                    Frm_CTSP_trong_HD frm_them_sp = new Frm_CTSP_trong_HD();
                    this.Hide();
                    ncc_name = cbo_nha_cc.SelectedItem.ToString();
                    frm_them_sp.ShowDialog();
                    if(CTHD_controller.sp_moi.SubItems[0].Text!="")
                    {
                       if(lstv_list_cthd.FindItemWithText("Thêm sản phẩm").Index - 1>=0)
                            CTHD_controller.sp_moi.SubItems[0].Text = (Convert.ToInt32( lstv_list_cthd.Items[lstv_list_cthd.FindItemWithText("Thêm sản phẩm").Index - 1].Text)+1).ToString();
                        lstv_list_cthd.Items.Insert(lstv_list_cthd.FindItemWithText("Thêm sản phẩm").Index, CTHD_controller.sp_moi);
                    }
                    
                    
                }
            }
            else
            {
                flag_them_sp = false;
                selected_SP = lstv_list_cthd.SelectedItems[0];
                Frm_CTSP_trong_HD frm_them_sp = new Frm_CTSP_trong_HD();
                this.Hide();
                ncc_name = cbo_nha_cc.SelectedItem.ToString();
                frm_them_sp.ShowDialog();
                lstv_list_cthd.Items[ lstv_list_cthd.FindItemWithText(CTHD_controller.sp_moi.SubItems[0].Text).Index] = CTHD_controller.sp_moi;
               
            }
            load_tong_tien();
            this.Show();
        }

        private void load_tong_tien()
        {
            foreach (ListViewItem a in lstv_list_cthd.Items)
            {
                if (a.Text != "Thêm sản phẩm")
                {
                    tien_truoc_thue += Convert.ToInt32(a.SubItems[2].Text) * Convert.ToInt32(a.SubItems[3].Text);
                    tien_thue += Convert.ToInt32(a.SubItems[2].Text) * Convert.ToInt32(a.SubItems[3].Text) * Convert.ToDouble(a.SubItems[4].Text) / 100;
                }

            }
            txt_tong_tien_HD_khong_thue.Text = tien_truoc_thue.ToString();
            txt_Thue_HD.Text = tien_thue.ToString();
            txt_Tong_tien_HD.Text = (tien_thue + tien_truoc_thue).ToString();
        }

        private void cbo_nha_cc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ncc_previous != "")
            {
                if(ncc_previous!=cbo_nha_cc.SelectedItem.ToString())
                {
                    DialogResult result = MessageBox.Show("Chi tiết sản phẩm sẽ bị xóa hết nếu thay đổi nhà cung cấp", "Xác nhận", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        ListViewItem them_SP = lstv_list_cthd.FindItemWithText("Thêm sản phẩm");
                        lstv_list_cthd.Items.Clear();
                        lstv_list_cthd.Items.Add(them_SP);
                    }
                    else
                    {
                        cbo_nha_cc.SelectedItem = ncc_previous;
                    }
                }
                
            }  
        }

        private void btn_Xoa_SP_Click(object sender, EventArgs e)
        {
            tien_thue = 0;
            tien_truoc_thue = 0;
            ListViewItem item_selected= lstv_list_cthd.FindItemWithText(lstv_list_cthd.SelectedItems[0].Text);
            lstv_list_cthd.Items.Remove(lstv_list_cthd.SelectedItems[0]);
            foreach(ListViewItem lvi in lstv_list_cthd.Items)
            {
                if(string.Compare(lvi.Text,item_selected.Text)==1&&lvi.SubItems[0].Text!= "Thêm sản phẩm")
                {
                    lvi.SubItems[0].Text = (Convert.ToInt32(lvi.Text)-1).ToString();
                }
            }
            load_tong_tien();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (lstv_list_cthd.Items.Count > 1)
            {
                cthd_ctr.Luu_HD(lstv_list_cthd.Items, txt_Ma_HD.Text, cbo_nha_cc.SelectedItem.ToString(), dtpk_ngay_dat_hang);
                this.Close();
            }
                
            else
                MessageBox.Show("Hóa đơn chưa có sản phẩm nào");
        }

        private void cbo_nha_cc_DropDown(object sender, EventArgs e)
        {
            if (cbo_nha_cc.SelectedItem != null)
                ncc_previous = cbo_nha_cc.SelectedItem.ToString();
            else
                ncc_previous = "";
        }

        private void txt_Ma_HD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tong_tien_HD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Thue_HD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tong_tien_HD_khong_thue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
