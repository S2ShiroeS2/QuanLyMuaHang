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
    public partial class frm_PasswordChange : Form
    {
        private LoginController LC = new LoginController();

        public frm_PasswordChange()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }

        private void btn_ConfirmPassword_Click(object sender, EventArgs e)
        {
            if (LC.CheckPassword(LoginController.UserID, (txb_OldPassword.Text.GetHashCode().ToString()))) 
                if (txb_ConfirmPassword.Text == txb_NewPassword.Text)
                {
                    LC.ChangePassword(LoginController.UserID, txb_NewPassword.Text.GetHashCode().ToString());
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật mã nhập lại không trùng khớp");

                }
            else
                MessageBox.Show("Sai mật khẩu cũ");
        }
    }
}
