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
        TTCNController TTCNC = new TTCNController();
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
            txb_nv_id.Text = lvi_UserInformation[0].SubItems[0].Text;
            txb_ttcn_name.Text = lvi_UserInformation[0].SubItems[1].Text;
            txb_ttcn_account.Text = lvi_UserInformation[0].SubItems[2].Text;
            txb_ttcn_email.Text = lvi_UserInformation[0].SubItems[3].Text;
            txb_ttcn_phone.Text = lvi_UserInformation[0].SubItems[4].Text;
        }

        private void Enable(bool Active)
        {
            txb_ttcn_account.Enabled = txb_ttcn_email.Enabled = txb_ttcn_name.Enabled = txb_ttcn_phone.Enabled = Active;
        }
    }
}
