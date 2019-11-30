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
    public partial class frm_ChiTiet_NCC_SanPham : Form
    {
        public frm_ChiTiet_NCC_SanPham()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }

        public static ListView.ListViewItemCollection list;
        List<ListViewItem> list_Ncc_database = new List<ListViewItem>();
        public List<ListViewItem> list_Ncc_update = new List<ListViewItem>();
        NhaCungCapController navigate_ncc = new NhaCungCapController();
        public static bool flag { get; private set; } = false;
        
        private void frm_themNhaCungCap_Load(object sender, EventArgs e)
        {
            list_Ncc_database = navigate_ncc.Load_Ncc();
            lstv_list_ncc_them.Items.Clear();
            lstv_list_ncc_co.Items.Clear();
            foreach (ListViewItem ncc in frm_CTSP.list_Ncc)
            {
                lstv_list_ncc_them.Items.Add(ncc.Text);
            }
            foreach (ListViewItem ncc in list_Ncc_database)
            {
                if(lstv_list_ncc_them.FindItemWithText(ncc.Text)==null)
                    lstv_list_ncc_co.Items.Add(ncc.Text);
            }
            if(frm_CTSP.flag == false)
            {
                btn_delete.Enabled = false;
            }
        }

        private void btn_add_one_Click(object sender, EventArgs e)
        {
            list_Ncc_update = new List<ListViewItem>();
            foreach(ListViewItem a in lstv_list_ncc_co.SelectedItems)
            {
                if(lstv_list_ncc_co.SelectedItems.Count>0)
                {
                    ListViewItem tmp = new ListViewItem();
                    tmp.Text = a.Text;
                    list_Ncc_update.Add(tmp);
                    lstv_list_ncc_them.Items.Add(tmp);
                    lstv_list_ncc_co.Items.Remove(a);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem a in lstv_list_ncc_them.SelectedItems)
            {
                if (lstv_list_ncc_them.SelectedItems.Count > 0)
                {
                    ListViewItem tmp = new ListViewItem();
                    tmp.Text = a.Text;
                    list_Ncc_update.Remove(tmp);
                    lstv_list_ncc_co.Items.Add(tmp);
                    lstv_list_ncc_them.Items.Remove(a);
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            flag = true;
            if (lstv_list_ncc_them.Items.Count == 0)
                MessageBox.Show("Không được để trống nhà cung cấp!");
            else
            {
                list = null;
                list = lstv_list_ncc_them.Items;
                this.Close();
            }
        }



        private void lstv_list_ncc_them_MouseClick(object sender, MouseEventArgs e)
        {
            if (frm_QLSP.flag_sp == false)
            {
                if (navigate_ncc.Check_current_Ncc(lstv_list_ncc_them.SelectedItems[0].Text, frm_CTSP.id_sp) == false)
                    btn_delete.Enabled = true;
                else
                    btn_delete.Enabled = false;
            }
        }
    }
}
