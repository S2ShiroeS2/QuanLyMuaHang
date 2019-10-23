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
            this.Show();
            
        }




        private void frm_QLHD_Load(object sender, EventArgs e)
        {
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
                hd_id = Convert.ToInt16(lstv_list_HD.SelectedItems[0].SubItems[0].Text);
        }
    }
}
