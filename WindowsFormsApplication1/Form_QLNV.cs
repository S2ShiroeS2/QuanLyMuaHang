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
    public partial class Form_QLNV : Form
    {
        public Form_QLNV()
        {
            InitializeComponent();
        }

        List<ListViewItem> list_NV = new List<ListViewItem>();
        NhanVienController NVC = new NhanVienController();
        public static bool flag_nv { get; private set; } = true;

        private void Form_QLNV_Load(object sender, EventArgs e)
        {
            list_NV = NVC.NhanVienList();

            foreach (ListViewItem Nv in list_NV)
                lv_list_NV.Items.Add(Nv);
        }

        private void bt_tim_kiem_NCC_Click(object sender, EventArgs e)
        {
            list_NV.Clear();
            lv_list_NV.Items.Clear();
            list_NV = NVC.NVListSearch(tb_tim_kiem_nv.Text.ToString());

            foreach (ListViewItem V in list_NV)
                lv_list_NV.Items.Add(V);
        }

        private void bt_tao_moi_NCC_Click(object sender, EventArgs e)
        {
            flag_nv = true;
            frm_CTNV frm_ct_nv = new frm_CTNV();
            frm_ct_nv.Show();
        }
    }
}
