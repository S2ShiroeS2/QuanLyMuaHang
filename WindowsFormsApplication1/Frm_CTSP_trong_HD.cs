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
    public partial class Frm_CTSP_trong_HD : Form
    {
        public Frm_CTSP_trong_HD()
        {
            InitializeComponent();
        }

        CTHD_controller cthd_ctrl = new CTHD_controller();

        private void Frm_Them_SP_vao_HD_Load(object sender, EventArgs e)
        {
            txt_Nha_cc.Text = frm_CTHD.ncc_name;
            List<string> list_sp = cthd_ctrl.load_list_sp(txt_Nha_cc.Text);
            foreach (var i in list_sp)
                cbo_Ten_SP.Items.Add(i);
            txt_Thue.Enabled = txt_So_luong.Enabled =btn_xac_nhan.Enabled= false;
        }

        private void cbo_Ten_SP_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_Thue.Enabled = txt_So_luong.Enabled = true;
            txt_Don_gia.Text = cthd_ctrl.load_gia_tien_sp(cbo_Ten_SP.Text).ToString();

            
        }

        private void txt_So_luong_TextChanged(object sender, EventArgs e)
        {
            if (txt_So_luong.Text.Length != 0&&txt_So_luong.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_So_luong.Text) > 0)
            {
                this.err_so_luong.Clear();
                btn_xac_nhan.Enabled = true;
                txt_tien_truoc_thue.Text = (cthd_ctrl.load_gia_tien_sp(cbo_Ten_SP.Text) * Convert.ToDouble(txt_So_luong.Text)).ToString();
                if (txt_Thue.Text.Length != 0 && txt_Thue.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_Thue.Text) >= 0)
                {
                    txt_tien_thue.Text = (cthd_ctrl.load_gia_tien_sp(cbo_Ten_SP.Text) * Convert.ToDouble(txt_So_luong.Text) * Convert.ToDouble(txt_Thue.Text) / 100).ToString();
                    txt_Tong_tien.Text = (Convert.ToDouble(txt_tien_truoc_thue.Text) + Convert.ToDouble(txt_tien_thue.Text)).ToString();
                }
                else
                {
                    btn_xac_nhan.Enabled = false;
                    this.err_thue.SetError(txt_Thue, "Thuế không được để trống");
                }
                    
                    
            }

            else
            {
                btn_xac_nhan.Enabled = false;
                this.err_so_luong.SetError(txt_So_luong, "Số lượng không được là chữ số và phải lớn hơn 0");
            }
                
        }

        private void txt_Thue_TextChanged(object sender, EventArgs e)
        {
            if(txt_Thue.Text.Length==0|| txt_Thue.Text.All(char.IsNumber)==false || Convert.ToDouble(txt_Thue.Text) <0)
            {
                btn_xac_nhan.Enabled = false;
                this.err_thue.SetError(txt_Thue, "Thuế phải là số và lớn hơn 0");
            }                
            else
            {
                this.err_thue.Clear();
                if (txt_So_luong.Text.Length != 0 && txt_So_luong.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_So_luong.Text) > 0)
                {
                    btn_xac_nhan.Enabled = true;
                    txt_tien_thue.Text = (cthd_ctrl.load_gia_tien_sp(cbo_Ten_SP.Text) * Convert.ToDouble(txt_So_luong.Text) * Convert.ToDouble(txt_Thue.Text) / 100).ToString();
                    txt_Tong_tien.Text = (Convert.ToDouble(txt_tien_truoc_thue.Text) + Convert.ToDouble(txt_tien_thue.Text)).ToString();
                    this.err_so_luong.Clear();
                }
                else
                    this.err_so_luong.SetError(txt_So_luong, "Số lượng không được để trống");
            }   
        }

        private void btn_xac_nhan_Click(object sender, EventArgs e)
        {
            ListViewItem sp = new ListViewItem();
            sp.Text = cbo_Ten_SP.SelectedItem.ToString();
            sp.SubItems.Add ( txt_So_luong.Text);
            sp.SubItems.Add(txt_Don_gia.Text);
            sp.SubItems.Add(txt_Thue.Text);
            sp.SubItems.Add(txt_Tong_tien.Text);
            CTHD_controller.sp_moi = cthd_ctrl.Them_SP(sp);
            this.Close();
        }
    }
}
