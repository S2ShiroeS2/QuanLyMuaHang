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
    public partial class frm_QLNV : Form
    {
        public frm_QLNV()
        {
            InitializeComponent();
        }

        List<ListViewItem> list_NV = new List<ListViewItem>();
        NhanVienController NVC = new NhanVienController();
        public static bool flag_nv { get; private set; } = true;
        public static ListViewItem lvi_nv { get; private set; } = new ListViewItem();

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
            frm_CTNV frm_CtNv = new frm_CTNV();
            frm_CtNv.ShowDialog();
            lam_moi();
        }

        private void lam_moi()
        {
            list_NV.Clear();
            lv_list_NV.Items.Clear();
            list_NV = NVC.NhanVienList();

            foreach (ListViewItem V in list_NV)
                lv_list_NV.Items.Add(V);
        }

        private void lv_list_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_list_NV.SelectedItems.Count > 0)
                lvi_nv = lv_list_NV.SelectedItems[0];
        }

        private void lv_list_NV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            flag_nv = false;
            frm_CTNV frm_CtNv = new frm_CTNV();
            frm_CtNv.ShowDialog();
            lam_moi();
        }
    }
}
