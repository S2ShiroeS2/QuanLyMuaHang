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
    public partial class frm_TTCN : Form
    {
        private TTCNController TTCNC = new TTCNController();
        private ListViewItem lvi_nv = new ListViewItem();
        private NhanVienController NVC = new NhanVienController();

        public frm_TTCN()
        {
            InitializeComponent();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            frm_PasswordChange frmPassword = new frm_PasswordChange();
            frmPassword.ShowDialog();

        }

        private void frm_TTCN_Load(object sender, EventArgs e)
        {
            List<ListViewItem> lvi_UserInformation = TTCNC.TakeUserInformation();
            txb_ttcn_id.Text = lvi_UserInformation[0].SubItems[0].Text;
            txb_ttcn_name.Text = lvi_UserInformation[0].SubItems[1].Text;
            txb_ttcn_account.Text = lvi_UserInformation[0].SubItems[2].Text;
            txb_ttcn_email.Text = lvi_UserInformation[0].SubItems[3].Text;
            txb_ttcn_phone.Text = lvi_UserInformation[0].SubItems[4].Text;
            txb_ttcn_role.Text = lvi_UserInformation[0].SubItems[5].Text;
        }

        private void Enable(bool Active)
        {
            txb_ttcn_account.Enabled = txb_ttcn_email.Enabled = txb_ttcn_name.Enabled = txb_ttcn_phone.Enabled = Active;
        }

        private void btn_ChangeInform_Click(object sender, EventArgs e)
        {
            Enable(true);
            btn_SaveInform.Enabled = true;
        }

        private void btn_SaveInform_Click(object sender, EventArgs e)
        {
            lvi_nv = new ListViewItem();
            lvi_nv.Text = txb_ttcn_id.Text;
            lvi_nv.SubItems.Add(txb_ttcn_name.Text);
            lvi_nv.SubItems.Add(txb_ttcn_account.Text);
            lvi_nv.SubItems.Add(txb_ttcn_email.Text);
            lvi_nv.SubItems.Add(txb_ttcn_phone.Text);
            lvi_nv.SubItems.Add(txb_ttcn_role.Text);
            lvi_nv.SubItems.Add("Active");
            NVC.UpdateNV(lvi_nv);
            MessageBox.Show("Lưu thành công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Enable(false);
            btn_SaveInform.Enabled = false;
        }
    }
}
