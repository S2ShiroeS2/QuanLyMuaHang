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
        private ErrorProvider EP = new ErrorProvider();

        public frm_TTCN()
        {
            InitializeComponent();
        }

        //Nút đổi mật khẩu
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            frm_PasswordChange frmPassword = new frm_PasswordChange();
            frmPassword.ShowDialog();

        }
        
        //Load dữ liệu lên form
        private void frm_TTCN_Load(object sender, EventArgs e)
        {
            List<ListViewItem> lvi_UserInformation = TTCNC.TakeUserInformation();
            txb_ID.Text = lvi_UserInformation[0].SubItems[0].Text;
            txb_Name.Text = lvi_UserInformation[0].SubItems[1].Text;
            txb_Account.Text = lvi_UserInformation[0].SubItems[2].Text;
            txb_Email.Text = lvi_UserInformation[0].SubItems[3].Text;
            txb_Phone.Text = lvi_UserInformation[0].SubItems[4].Text;
            txb_Role.Text = lvi_UserInformation[0].SubItems[5].Text;
        }
        //Kích hoạt textbox
        private void Enable(bool Active)
        {
            txb_Account.Enabled = txb_Email.Enabled = txb_Name.Enabled = txb_Phone.Enabled = Active;
        }
        
        //Nút kích hoạt textbox để sửa
        private void btn_ChangeInform_Click(object sender, EventArgs e)
        {
            Enable(true);
            btn_SaveInform.Enabled = true;
        }

        //Lưu thông tin đã nhập
        private void btn_SaveInform_Click(object sender, EventArgs e)
        {
            lvi_nv = new ListViewItem();
            lvi_nv.Text = txb_ID.Text;
            lvi_nv.SubItems.Add(txb_Name.Text);
            lvi_nv.SubItems.Add(txb_Account.Text);
            lvi_nv.SubItems.Add(txb_Email.Text);
            lvi_nv.SubItems.Add(txb_Phone.Text);
            lvi_nv.SubItems.Add(txb_Role.Text);
            lvi_nv.SubItems.Add("Active");
            NVC.UpdateNV(lvi_nv);
            MessageBox.Show("Lưu thành công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Enable(false);
            btn_SaveInform.Enabled = false;
        }

        
        //Set ErrorProvider cho trường dữ liệu

        //Set ErrorProvider cho txb_Name
        private void txb_Name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Name.Text))
            {
                e.Cancel = true;
                txb_Name.Focus();
                EP.SetError(txb_Name, "Không được để trống");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_Name.Text, "^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$"))//Regex cho nhập chữ Tiếng Việt
            {
                txb_Name.Focus();
                EP.SetError(txb_Name, "Chỉ được nhập chữ");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_Name, null);
            }
        }

        private void txb_Account_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Account.Text))
            {
                e.Cancel = true;
                txb_Account.Focus();
                EP.SetError(txb_Account, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_Account, null);
            }
        }

        private void txb_Email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Email.Text))
            {
                e.Cancel = true;
                txb_Email.Focus();
                EP.SetError(txb_Email, "Không được để trống");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_Email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))//Regex email
            {
                e.Cancel = true;
                txb_Email.Focus();
                EP.SetError(txb_Email, "Email không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_Email, null);
            }
        }

        private void txb_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Phone.Text))
            {
                e.Cancel = true;
                txb_Phone.Focus();
                EP.SetError(txb_Phone, "Không được để trống");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_Phone.Text, "^[0-9]+$"))// Regex cho chỉ nhập số
            {
                e.Cancel = true;
                txb_Phone.Focus();
                EP.SetError(txb_Phone, "Số điện thoại không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_Phone, null);
            }
        }


        //
    }
}
