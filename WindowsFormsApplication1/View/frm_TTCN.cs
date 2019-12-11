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

        //Flag cho ErrorProvider
        private bool flag_1 = false;
        private bool flag_2 = false;
        private bool flag_3 = false;
        private bool flag_4 = false;

        public frm_TTCN()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
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
            btn_SaveInform.Enabled = false;
            if (lvi_UserInformation[0].SubItems[5].Text == "True")
                txb_Role.Text = "Admin";
            else
                txb_Role.Text = "Nhân viên";
        }
        //Kích hoạt textbox
        private void Enable(bool Active)
        {
             txb_Email.Enabled = txb_Name.Enabled = txb_Phone.Enabled = Active;
        }
        
        //Nút kích hoạt textbox để sửa
        private void btn_ChangeInform_Click(object sender, EventArgs e)
        {
            Enable(true);
            btn_SaveInform.Enabled = true;
            btn_ChangeInform.Enabled = false;
        }

        private void EnableSaveBtn()
        {
            if (flag_1 == true && flag_2 == true && flag_3 == true && flag_4 == true)
                btn_SaveInform.Enabled = true;
            else
                btn_SaveInform.Enabled = false;
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
        private void txb_Name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Name.Text))
            {

                txb_Name.Focus();
                EP.SetError(txb_Name, "Không được để trống");
                flag_1 = false;
                EnableSaveBtn();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_Name.Text, "^[a-z A-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$"))//Regex cho nhập chữ Tiếng Việt
            {
                txb_Name.Focus();
                EP.SetError(txb_Name, "Chỉ được nhập chữ");
                flag_1 = false;
                EnableSaveBtn();
            }
            else
            {
                EP.SetError(txb_Name, null);
                flag_1 = true;
                EnableSaveBtn();
            }
        }

        private void txb_Account_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Account.Text))
            {
                txb_Account.Focus();
                EP.SetError(txb_Account, "Không được để trống");
                flag_2 = false;
                EnableSaveBtn();
            }
            else if (!NVC.CheckAccountExsits(txb_Account.Text, Int32.Parse(txb_ID.Text)))
            {
                txb_Account.Focus();
                EP.SetError(txb_Account, "Tài khoản đã có người sử dụng");
                flag_2 = false;
                EnableSaveBtn();
            }
            else
            {
                EP.SetError(txb_Account, null);
                flag_2 = true;
                EnableSaveBtn();
            }
        }


        private void txb_Email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Email.Text))
            {
                txb_Email.Focus();
                EP.SetError(txb_Email, "Không được để trống");
                flag_3 = false;
                EnableSaveBtn();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_Email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))//Regex email
            {
                txb_Email.Focus();
                EP.SetError(txb_Email, "Email không hợp lệ");
                flag_3 = false;
                EnableSaveBtn();
            }
            else
            {
                EP.SetError(txb_Email, null);
                flag_3 = true;
                EnableSaveBtn();
            }
        }

        private void txb_Phone_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Phone.Text))
            {
                txb_Phone.Focus();
                EP.SetError(txb_Phone, "Không được để trống");
                flag_4 = false;
                EnableSaveBtn();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_Phone.Text, "^[+]?[0-9]+$"))// Regex cho chỉ nhập số
            {
                txb_Phone.Focus();
                EP.SetError(txb_Phone, "Số điện thoại không hợp lệ");
                flag_4 = false;
                EnableSaveBtn();
            }
            else
            {
                EP.SetError(txb_Phone, null);
                flag_4 = true;
                EnableSaveBtn();
            }
        }


        //
    }
}
