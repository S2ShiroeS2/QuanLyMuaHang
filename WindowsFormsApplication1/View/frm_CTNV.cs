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
    public partial class frm_CTNV : Form
    {
        public frm_CTNV()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }
        public static ListViewItem lvi_them_nv { get; private set; } = new ListViewItem();
        private NhanVienController NVC = new NhanVienController();
        private ErrorProvider EP = new ErrorProvider();
        private LoginController LC = new LoginController();

        //Flag cho ErrorProvider
        private bool flag_1 = false;
        private bool flag_2 = false;
        private bool flag_3 = false;
        private bool flag_4 = false;

        //Enable textbox cần thiết
        private void Enable_txb(bool Active)
        {
            txb_NVName.Enabled = txb_NVEmail.Enabled = txb_NVPhone.Enabled =btn_NVSave.Enabled=btn_ResetPassword.Enabled= cmb_NVActivation.Enabled=cmb_NVRole.Enabled = Active;
        }


        private void btn_nv_update_Click(object sender, EventArgs e)
        {
            btn_NVUpdate.Enabled = false;
            Enable_txb(true);
            if (LoginController.Account == txb_NVAccount.Text)
                cmb_NVActivation.Enabled =cmb_NVRole.Enabled= false;
        }


        private void btn_nv_luu_Click(object sender, EventArgs e)
        {
            lvi_them_nv = new ListViewItem();
            lvi_them_nv.Text = txb_NVID.Text;
            lvi_them_nv.SubItems.Add(txb_NVName.Text);
            lvi_them_nv.SubItems.Add(txb_NVAccount.Text);
            lvi_them_nv.SubItems.Add(txb_NVEmail.Text);
            lvi_them_nv.SubItems.Add(txb_NVPhone.Text);
            lvi_them_nv.SubItems.Add(cmb_NVRole.Text);
            lvi_them_nv.SubItems.Add(cmb_NVActivation.Text);
            if (frm_QLNV.flag_nv)
            {
                NVC.NVAddNew(lvi_them_nv, "123".GetHashCode().ToString());
                MessageBox.Show("Password mặc định là: 123");
            }
            else
                NVC.UpdateNV(lvi_them_nv);

            MessageBox.Show("Lưu thành công");
            this.Close();
        }

        private void frm_CTNV_Load(object sender, EventArgs e)
        {
            if (frm_QLNV.flag_nv == false)
            {
                txb_NVID.Text = frm_QLNV.lvi_nv.SubItems[0].Text;
                txb_NVName.Text = frm_QLNV.lvi_nv.SubItems[1].Text;
                txb_NVAccount.Text = frm_QLNV.lvi_nv.SubItems[2].Text;
                txb_NVEmail.Text = frm_QLNV.lvi_nv.SubItems[3].Text;
                txb_NVPhone.Text = frm_QLNV.lvi_nv.SubItems[4].Text;
                cmb_NVRole.Text = frm_QLNV.lvi_nv.SubItems[5].Text;
                cmb_NVActivation.Text = frm_QLNV.lvi_nv.SubItems[6].Text;
                btn_NVUpdate.Enabled = true;
                btn_NVSave.Enabled = false;
                Enable_txb(false);

            }
            else
            {
                btn_NVUpdate.Enabled = false;
                int NextNVId = NVC.GetMaxNVID() + 1;
                txb_NVID.Text = NextNVId.ToString();
                cmb_NVActivation.SelectedItem = "Active";
                cmb_NVRole.SelectedItem = "Nhân viên";
                txb_NVAccount.Enabled = true;
            }
        }

        private void btn_nv_active_Click(object sender, EventArgs e)
        {
            btn_NVUpdate.Enabled = false;
            Enable_txb(true);
        }

        private void EnableSaveBtn()
        {
            if (flag_1==true && flag_2 == true && flag_3 == true && flag_4 == true )
                btn_NVSave.Enabled = true;
            else
                btn_NVSave.Enabled = false;
        }

        //Set ErrorProvider cho form
        private void txb_NVName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVName.Text))
            {

                txb_NVName.Focus();
                EP.SetError(txb_NVName, "Không được để trống");
                flag_1 = false;
                EnableSaveBtn();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_NVName.Text, "^[a-z A-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$"))//Regex cho nhập chữ Tiếng Việt
            {
                txb_NVName.Focus();
                EP.SetError(txb_NVName, "Chỉ được nhập chữ");
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

        private void txb_NVAccount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVAccount.Text))
            {
                txb_NVAccount.Focus();
                EP.SetError(txb_NVAccount, "Không được để trống");
                flag_2 = false;
                EnableSaveBtn();
            }
            else if (!NVC.CheckAccountExsits(txb_NVAccount.Text,Int32.Parse(txb_NVID.Text)))
            {
                txb_NVAccount.Focus();
                EP.SetError(txb_NVAccount, "Tài khoản đã có người sử dụng");
                flag_2 = false;
                EnableSaveBtn();
            }
            else
            {
                EP.SetError(txb_NVAccount, null);
                flag_2 = true;
                EnableSaveBtn();
            }
        }

        private void txb_NVEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVEmail.Text))
            {
                txb_NVEmail.Focus();
                EP.SetError(txb_NVEmail, "Không được để trống");
                flag_3 = false;
                EnableSaveBtn();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_NVEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))//Regex email
            {
                txb_NVEmail.Focus();
                EP.SetError(txb_NVEmail, "Email không hợp lệ");
                flag_3 = false;
                EnableSaveBtn();
            }
            else
            {
                EP.SetError(txb_NVEmail, null);
                flag_3 = true;
                EnableSaveBtn();
            }
        }

        private void txb_NVPhone_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_NVPhone.Text))
            {
                txb_NVPhone.Focus();
                EP.SetError(txb_NVPhone, "Không được để trống");
                flag_4 = false;
                EnableSaveBtn();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_NVPhone.Text, "^[+]?[0-9]+$"))// Regex cho chỉ nhập số
            {
                txb_NVPhone.Focus();
                EP.SetError(txb_NVPhone, "Số điện thoại không hợp lệ");
                flag_4 = false;
                EnableSaveBtn();
            }
            else
            {
                EP.SetError(txb_NVPhone, null);
                flag_4 = true;
                EnableSaveBtn();
            }
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            LC.ChangePassword(Int32.Parse(txb_NVID.Text), "123".GetHashCode().ToString());
            MessageBox.Show("Reset password thành công: 123");
        }

        private void cmb_NVActivation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txb_NVID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_NVRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
