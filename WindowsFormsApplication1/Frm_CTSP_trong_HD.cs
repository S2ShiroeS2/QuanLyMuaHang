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
        ListViewItem ctsp = new ListViewItem();


        private void Frm_Them_SP_vao_HD_Load(object sender, EventArgs e)
        {
            txt_Nha_cc.Text = frm_CTHD.ncc_name;
            List<string> list_sp = cthd_ctrl.load_list_sp(txt_Nha_cc.Text);
            foreach (var i in list_sp)
                cbo_Ten_SP.Items.Add(i);
            txt_Thue.Enabled = txt_So_luong.Enabled =txt_Don_gia.Enabled=btn_xac_nhan.Enabled= false;
            if(frm_CTHD.flag_them_sp==false)                // Double click vào sp ở CTHD
            {
                ctsp=cthd_ctrl.load_ctsp();
                cbo_Ten_SP.SelectedItem= ctsp.SubItems[1].Text;
                txt_So_luong.Text = ctsp.SubItems[2].Text;
                txt_Don_gia.Text = ctsp.SubItems[3].Text;
                txt_Thue.Text = ctsp.SubItems[4].Text;
                cbo_Ten_SP.Enabled = false;
            }
            else                                            // Double click vào dòng thêm sản phẩm
            {

            }
        }

        private void cbo_Ten_SP_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_Thue.Enabled = txt_So_luong.Enabled =txt_Don_gia.Enabled= true;
            if (txt_So_luong.Text.Length != 0 && txt_So_luong.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_So_luong.Text) > 0 && txt_Thue.Text.Length != 0 && txt_Thue.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_Thue.Text) >= 0)
            {
            }
        }

        private void txt_So_luong_TextChanged(object sender, EventArgs e)
        {
            if (txt_So_luong.Text.Length != 0&&txt_So_luong.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_So_luong.Text) > 0)
            {
                this.err_so_luong.Clear();
                btn_xac_nhan.Enabled = true;
                
                if (txt_Thue.Text.Length != 0 && txt_Thue.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_Thue.Text) >= 0)
                {
                    if(txt_Don_gia.Text.Length != 0 && txt_Don_gia.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_Don_gia.Text) >= 0)
                    {
                        txt_tien_truoc_thue.Text = (Convert.ToDouble(txt_Don_gia.Text) * Convert.ToDouble(txt_So_luong.Text)).ToString();
                        txt_tien_thue.Text = (Convert.ToDouble(txt_Don_gia.Text) * Convert.ToDouble(txt_So_luong.Text) * Convert.ToDouble(txt_Thue.Text) / 100).ToString();
                        txt_Tong_tien.Text = (Convert.ToDouble(txt_tien_truoc_thue.Text) + Convert.ToDouble(txt_tien_thue.Text)).ToString();
                    }
                    else
                    {
                        btn_xac_nhan.Enabled = false;
                        this.err_Don_gia.SetError(txt_Don_gia, "Giá không được để trống");
                    }
                }
                else
                {
                    btn_xac_nhan.Enabled = false;
                    this.err_thue.SetError(txt_Thue, "Thuế không được để trống");
                    this.err_Don_gia.SetError(txt_Don_gia, "Giá không được để trống");
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
                    if(txt_Don_gia.Text.Length != 0 && txt_Don_gia.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_Don_gia.Text) >= 0)
                    {
                        btn_xac_nhan.Enabled = true;
                        txt_tien_truoc_thue.Text = (Convert.ToDouble(txt_Don_gia.Text) * Convert.ToDouble(txt_So_luong.Text)).ToString();
                        txt_tien_thue.Text = (Convert.ToDouble(txt_Don_gia.Text) * Convert.ToDouble(txt_So_luong.Text) * Convert.ToDouble(txt_Thue.Text) / 100).ToString();
                        txt_Tong_tien.Text = (Convert.ToDouble(txt_Don_gia.Text) * Convert.ToInt32(txt_So_luong.Text) + Convert.ToDouble(txt_tien_thue.Text)).ToString();
                        this.err_so_luong.Clear();
                    }
                    else
                    {
                        btn_xac_nhan.Enabled = false;
                        this.err_Don_gia.SetError(txt_Don_gia, "Giá không được để trống");
                    }
                }
                else
                {
                    btn_xac_nhan.Enabled = false;
                    this.err_thue.SetError(txt_Thue, "Thuế không được để trống");
                }
                    
            }   
        }

        private void btn_xac_nhan_Click(object sender, EventArgs e)
        {
            if(frm_CTHD.flag_them_sp==true)
            {
                ListViewItem sp = new ListViewItem();
                sp.Text = cbo_Ten_SP.SelectedItem.ToString();
                sp.SubItems.Add(txt_So_luong.Text);
                sp.SubItems.Add(txt_Don_gia.Text);
                sp.SubItems.Add(txt_Thue.Text);
                sp.SubItems.Add(txt_Tong_tien.Text);
                CTHD_controller.sp_moi = cthd_ctrl.Them_SP(sp);
            }
            else
            {
                ctsp.SubItems[1].Text = cbo_Ten_SP.SelectedItem.ToString();
                ctsp.SubItems[2].Text = txt_So_luong.Text;
                ctsp.SubItems[4].Text = txt_Thue.Text;
                ctsp.SubItems[5].Text = txt_Tong_tien.Text;
                CTHD_controller.sp_moi = cthd_ctrl.Sua_SP(ctsp);
            }
            this.Close();
        }

        private void txt_Don_gia_TextChanged(object sender, EventArgs e)
        {
            if (txt_Don_gia.Text.Length != 0 && txt_Don_gia.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_Don_gia.Text) > 0)
            {
                this.err_Don_gia.Clear();
                btn_xac_nhan.Enabled = true;

                if (txt_So_luong.Text.Length != 0 && txt_So_luong.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_So_luong.Text) > 0 )
                {
                    if(txt_Thue.Text.Length != 0 && txt_Thue.Text.All(char.IsNumber) == true && Convert.ToDouble(txt_Thue.Text) >= 0)
                    {
                        txt_tien_truoc_thue.Text = (Convert.ToDouble(txt_Don_gia.Text) * Convert.ToDouble(txt_So_luong.Text)).ToString();
                        txt_tien_thue.Text = (Convert.ToDouble(txt_Don_gia.Text) * Convert.ToDouble(txt_So_luong.Text) * Convert.ToDouble(txt_Thue.Text) / 100).ToString();
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
                    this.err_thue.SetError(txt_Thue, "Thuế không được để trống");
                    this.err_so_luong.SetError(txt_So_luong, "Số lượng không được để trống");
                }


            }

            else
            {
                btn_xac_nhan.Enabled = false;
                this.err_Don_gia.SetError(txt_Don_gia, "Giá không được là chữ số và phải lớn hơn 0");
            }
        }
    }
}
