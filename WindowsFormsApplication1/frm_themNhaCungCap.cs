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
        public delegate void SendMessage(List<ListViewItem> value);
        public SendMessage send;
        public frm_themNhaCungCap()
        {
            InitializeComponent();
        }

        public frm_themNhaCungCap(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        List<ListViewItem> list_Ncc = new List<ListViewItem>();
        public List<ListViewItem> list_Ncc_update = new List<ListViewItem>();
        NhaCungCapController navigate_ncc = new NhaCungCapController();
        public static bool flag { get; private set; } = true;
        private void frm_themNhaCungCap_Load(object sender, EventArgs e)
        {
            list_Ncc = navigate_ncc.Load_Ncc();
            foreach (ListViewItem a in list_Ncc_update)
            {
                ListViewItem tmp = new ListViewItem();
                tmp.Text = a.Text;
                lsvt_list_ncc_them.Items.Add(tmp);
                var itemToRemove = list_Ncc.Single(r => r.Text == a.Text);
                list_Ncc.Remove(itemToRemove);
                
            }
            foreach (ListViewItem ncc in list_Ncc)
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
                    list_Ncc_update.Add(tmp);
                    lsvt_list_ncc_them.Items.Add(tmp);
                    lstv_list_ncc_co.Items.Remove(a);
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            this.send(list_Ncc_update);
            this.Close();
        }
    }
}
