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
    public partial class frm_CTHD : Form
    {
        public frm_CTHD()
        {
            InitializeComponent();
        }

        CTHD_controller b = new CTHD_controller();
        CTHD_controller cthd_ctr = new CTHD_controller();
        

        private void MS_sua_HD_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
        }

        private void MS_xoa_HD_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }


        //
        // Hàm dùng để điều khiển các control trong form
        //
        private void enable_control(bool flag)
        {
            btn_luu.Enabled =cbo_nha_cc.Enabled=lstv_list_cthd.Enabled= flag;
            btn_sua.Enabled = !flag;
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
        }

        private void lstv_list_cthd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstv_list_cthd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if (lstv_list_cthd.SelectedItems[0].Text == "Thêm sản phẩm")
            {
                if (cbo_nha_cc.SelectedItem == null)
                    MessageBox.Show("Bạn chưa chọn nhà cung cấp cho hóa đơn");
                else
                {

                }
            }
                
        }
    }
}
