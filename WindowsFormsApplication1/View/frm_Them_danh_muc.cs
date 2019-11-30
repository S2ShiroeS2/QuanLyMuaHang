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
    public partial class frm_Them_danh_muc : Form
    {
        public frm_Them_danh_muc()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }

        SanPhamController sp_ctrl=new SanPhamController();

        private void frm_Them_danh_muc_Load(object sender, EventArgs e)
        {
            txt_ma_danh_muc.Text = sp_ctrl.load_ma_danh_muc_max().ToString();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(txt_Ten_danh_muc.Text.Length==0)
            {
                MessageBox.Show("Tên danh mục không thể để trống");
            }
            else
            {
                sp_ctrl.luu_danh_muc_moi(Convert.ToInt32(txt_ma_danh_muc.Text), txt_Ten_danh_muc.Text);
                this.Close();
            }
        }

        private void txt_Ten_danh_muc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
