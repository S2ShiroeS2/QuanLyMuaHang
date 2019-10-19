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

        private void form_CTSP_Load(object sender, EventArgs e)
        {
            txt_ma_sp.Text = Form_QLSP.sanPham.SubItems[0].Text;
            //txt_ten_sp.Text = Form_QLSP.sanPham.SubItems[1].Text;
            //cbo_loai_sp.Text = Form_QLSP.sanPham.SubItems[2].Text;
            //cbo_danh_muc_sp.Text = Form_QLSP.sanPham.SubItems[3].Text;
            //txt_so_luong_sp.Text = Form_QLSP.sanPham.SubItems[4].Text;
            //txt_gia_sp.Text = Form_QLSP.sanPham.SubItems[5].Text;
        }
    }
}
