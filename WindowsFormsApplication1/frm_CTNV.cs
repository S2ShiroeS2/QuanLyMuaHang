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
        private NhanVienController NVC = new NhanVienController();
        private ErrorProvider EP = new ErrorProvider();
        private bool flag_1 = false;
        private bool flag_2 = false;
        private bool flag_3 = false;
        private bool flag_4 = false;
        private bool flag_5 = true;


        private void Enable_txb(bool Active)
        {
            txb_NVName.Enabled = txb_NVEmail.Enabled = txb_NVAccount.Enabled = txb_NVPhone.Enabled = btn_NVActive.Enabled = Active;
        }

        private void btn_nv_update_Click(object sender, EventArgs e)
        {
            Enable_txb(true);
        }

        private void btn_nv_luu_Click(object sender, EventArgs e)
        {
            lvi_them_nv = new ListViewItem();
            lvi_them_nv.Text = txb_NVID.Text;
            lvi_them_nv.SubItems.Add(txb_NVName.Text);
            lvi_them_nv.SubItems.Add(txb_NVAccount.Text);
            lvi_them_nv.SubItems.Add(txb_NVEmail.Text);
            lvi_them_nv.SubItems.Add(txb_NVPhone.Text);
            lvi_them_nv.SubItems.Add(txb_NVRole.Text);
            lvi_them_nv.SubItems.Add(txb_NVActivation.Text);
            if (Form_QLNV.flag_nv)
            {
                NVC.NVAddNew(lvi_them_nv, "123");
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
                txb_NVID.Text = Form_QLNV.lvi_nv.SubItems[0].Text;
                txb_NVName.Text = Form_QLNV.lvi_nv.SubItems[1].Text;
                txb_NVAccount.Text = Form_QLNV.lvi_nv.SubItems[2].Text;
                txb_NVEmail.Text = Form_QLNV.lvi_nv.SubItems[3].Text;
                txb_NVPhone.Text = Form_QLNV.lvi_nv.SubItems[4].Text;
                txb_NVRole.Text = Form_QLNV.lvi_nv.SubItems[5].Text;
                txb_NVActivation.Text = Form_QLNV.lvi_nv.SubItems[6].Text;
                btn_NVUpdate.Enabled = true;
                btn_NVActive.Enabled = true;
                if (txb_NVActivation.Text == "Active")
                    btn_NVActive.Text = "Deactive";
                else
                    btn_NVActive.Text = "Active";
                Enable_txb(false);

            }
            else
            {
                btn_NVUpdate.Enabled = false;
                txb_NVActivation.Text = "Active";
                int NextNVId = NVC.GetMaxNVID() + 1;
                txb_NVID.Text = NextNVId.ToString();
            }
        }

        private void btn_nv_active_Click(object sender, EventArgs e)
        {
            if (btn_NVActive.Text == "Active")
            {
                txb_NVActivation.Text = "Active";
                btn_NVActive.Text = "Deactive";
            }
            else
            {
                txb_NVActivation.Text = "Deactive";
                btn_NVActive.Text = "Active";
            }
        }

        private void EnableSaveBtn()
        {
            if (flag_1==true && flag_2 == true && flag_3 == true && flag_4 == true && flag_5 == true)
                btn_NVSave.Enabled = true;
            else
                btn_NVSave.Enabled = false;
        }

        //Set ErrorProvider cho form
        private void txb_NVAccount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVAccount.Text))
            {
                e.Cancel = true;
                txb_NVAccount.Focus();
                EP.SetError(txb_NVAccount, "Không được để trống");
                flag_2 = false;
                EnableSaveBtn();
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_NVAccount, null);
                flag_2 = true;
                EnableSaveBtn();
            }
        }
        
        private void txb_NVEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVEmail.Text) && System.Text.RegularExpressions.Regex.IsMatch(txb_NVEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"))
            {
                e.Cancel = true;
                txb_NVEmail.Focus();
                EP.SetError(txb_NVEmail, "Không được để trống");
                flag_3 = false;
                EnableSaveBtn();
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_NVEmail, null);
                flag_3 = true;
                EnableSaveBtn();
            }
        }

        private void txb_NVPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVPhone.Text))
            {
                e.Cancel = true;
                txb_NVPhone.Focus();
                EP.SetError(txb_NVPhone, "Không được để trống");
                flag_4 = false;
                EnableSaveBtn();
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_NVPhone, null);
                flag_4 = true;
                EnableSaveBtn();
            }
        }

        private void txb_NVRole_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVRole.Text))
            {
                e.Cancel = true;
                txb_NVRole.Focus();
                EP.SetError(txb_NVRole, "Không được để trống");
                flag_5 = false;
                EnableSaveBtn();
            }
            else if(string.Compare("nhân viên",txb_NVRole.Text,true)!=0 && string.Compare("admin", txb_NVRole.Text,true) != 0)
                {
                e.Cancel = true;
                txb_NVRole.Focus();
                EP.SetError(txb_NVRole, "Chỉ dược nhập \"Nhân viên\" hoặc \"Admin\"!");
                flag_5 = false;
                EnableSaveBtn();
            }
                else
                {
                    e.Cancel = false;
                    EP.SetError(txb_NVRole, null);
                    flag_5 = true;
                    EnableSaveBtn();
                }
        }


        private void txb_NVName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVName.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txb_NVName.Text,"^[a-zA-Z ]"))
            {

                txb_NVName.Focus();
                EP.SetError(txb_NVName, "Không được để trống");
                flag_1 = false;
                EnableSaveBtn();
            }
            else
            {
                EP.SetError(txb_NVName, null);
                flag_1 = true;
                EnableSaveBtn();
            }
        }

        
    }
}
