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
    public partial class frm_CTNV : Form
    {
        public frm_CTNV()
        {
            InitializeComponent();
        }
        public static ListViewItem lvi_them_nv { get; private set; } = new ListViewItem();
        NhanVienController NVC = new NhanVienController();

        private void Enable_txb(bool Active)
        {
            txb_nv_name.Enabled = txb_nv_email.Enabled  = txb_nv_account.Enabled = txb_nv_phone.Enabled =btn_nv_active.Enabled= Active;
        }
        private void btn_nv_update_Click(object sender, EventArgs e)
        {
            Enable_txb(true);
        }

        private void btn_nv_luu_Click(object sender, EventArgs e)
        {
            lvi_them_nv = new ListViewItem();
            lvi_them_nv.Text = txb_nv_id.Text;
            lvi_them_nv.SubItems.Add(txb_nv_name.Text);
            lvi_them_nv.SubItems.Add(txb_nv_account.Text);
            lvi_them_nv.SubItems.Add(txb_nv_email.Text);
            lvi_them_nv.SubItems.Add(txb_nv_phone.Text);
            lvi_them_nv.SubItems.Add(txb_nv_role.Text);
            lvi_them_nv.SubItems.Add(txb_nv_active.Text);
            if (Form_QLNV.flag_nv)
            {
                NVC.NVAddNew(lvi_them_nv,"123");
                MessageBox.Show("Password mặc định là: 123");
            }
            else
                NVC.UpdateNV(lvi_them_nv);

            MessageBox.Show("Lưu thành công");
            this.Close();
        }

        private void frm_CTNV_Load(object sender, EventArgs e)
        {
            if (Form_QLNV.flag_nv == false)
            {
                txb_nv_id.Text = Form_QLNV.lvi_nv.SubItems[0].Text;
                txb_nv_name.Text = Form_QLNV.lvi_nv.SubItems[1].Text;
                txb_nv_account.Text = Form_QLNV.lvi_nv.SubItems[2].Text;
                txb_nv_email.Text = Form_QLNV.lvi_nv.SubItems[3].Text;
                txb_nv_phone.Text = Form_QLNV.lvi_nv.SubItems[4].Text;
                txb_nv_role.Text = Form_QLNV.lvi_nv.SubItems[5].Text;
                txb_nv_active.Text = Form_QLNV.lvi_nv.SubItems[6].Text;
                btn_nv_update.Enabled = true;
                btn_nv_active.Enabled = true;
                if (txb_nv_active.Text == "Active")
                    btn_nv_active.Text = "Deactive";
                else
                    btn_nv_active.Text = "Active";
                Enable_txb(false);
                
            }
            else
            {
                btn_nv_update.Enabled = false;
                txb_nv_active.Text = "Active";
                int NextNVId = NVC.GetMaxNVID() + 1;
                txb_nv_id.Text = NextNVId.ToString();
            }
        }

        private void btn_nv_active_Click(object sender, EventArgs e)
        {
            if (btn_nv_active.Text == "Active")
            {
                txb_nv_active.Text = "Active";
                btn_nv_active.Text = "Deactive";
            }
            else
            {
                txb_nv_active.Text = "Deactive";
                btn_nv_active.Text = "Active";
            }
        }
    }
}
