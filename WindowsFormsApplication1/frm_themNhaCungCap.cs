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
    public partial class frm_themNhaCungCap : Form
    {
        public frm_themNhaCungCap()
        {
            InitializeComponent();
        }
        List<ListViewItem> list_Ncc = new List<ListViewItem>();
        NhaCungCapController navigate_ncc = new NhaCungCapController();

        private void frm_themNhaCungCap_Load(object sender, EventArgs e)
        {
            list_Ncc = navigate_ncc.Load_Ncc();
            foreach(ListViewItem ncc in list_Ncc)
            {
                lstv_list_ncc_co.Items.Add(ncc);
            }
        }

        private void btn_add_one_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem a in lstv_list_ncc_co.SelectedItems)
            {
                if(lstv_list_ncc_co.SelectedItems.Count>0)
                {
                    ListViewItem tmp = new ListViewItem();
                    tmp.Text = a.Text;
                    lsvt_list_ncc_them.Items.Add(tmp);
                    lstv_list_ncc_co.Items.Remove(a);
                }
                
            }
        }
    }
}
