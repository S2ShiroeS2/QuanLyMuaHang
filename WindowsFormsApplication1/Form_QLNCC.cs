﻿using System;
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
    public partial class Form_QLNCC : Form
    {
        public Form_QLNCC()
        {
            InitializeComponent();
        }
        List<ListViewItem> list_vendor = new List<ListViewItem>();
        VendorController VC = new VendorController();
        public static ListViewItem lvi_ncc = new ListViewItem();
        public static bool flag_ncc = true;

        private void Form_QLNCC_Load(object sender, EventArgs e)
        {
            list_vendor.Clear();
            lv_list_ncc.Items.Clear();
            list_vendor = VC.VendorList();

            foreach (ListViewItem V in list_vendor)
                lv_list_ncc.Items.Add(V);
        }


        private void bt_tim_kiem_NCC_Click(object sender, EventArgs e)
        {
            list_vendor.Clear();
            lv_list_ncc.Items.Clear();
            list_vendor = VC.VendorListSearch(tb_tim_kiem_NCC.Text.ToString());

            foreach (ListViewItem V in list_vendor)
                lv_list_ncc.Items.Add(V);
        }

        private void bt_tao_moi_NCC_Click(object sender, EventArgs e)
        {
            flag_ncc = true;
            formCT_ncc formCT_ncc = new formCT_ncc();
            formCT_ncc.Show();
        }

        private void lv_list_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_list_ncc.SelectedItems.Count > 0)
                lvi_ncc = lv_list_ncc.SelectedItems[0];
        }

        private void bt_sua_ncc_Click(object sender, EventArgs e)
        {
            flag_ncc = false;
            if (lv_list_ncc.SelectedItems.Count > 0)
            {
                formCT_ncc formCT_ncc = new formCT_ncc();
                formCT_ncc.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 nhà cung cấp");
        }
    }
}
