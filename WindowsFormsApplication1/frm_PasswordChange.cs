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
        }

        private void btn_ConfirmPassword_Click(object sender, EventArgs e)
        {
            if (LC.CheckPassword(1, txb_OldPassword.Text)) // Thay 1 = LC.userID khi hoàn thành
                if (txb_ConfirmPassword.Text == txb_NewPassword.Text)
                {
                    LC.ChangePassword(1, txb_NewPassword.Text);// Thay 1 = LC.userID khi hoàn thành
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật mã nhập lại không trùng khớp");

                }
            else
                MessageBox.Show("Sai mật khẩu");
        }
    }
}
