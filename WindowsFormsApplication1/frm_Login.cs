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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        public static string LoginAccount { get; private set; }
        public static string LoginPassword { get; private set; }
        private LoginController LC = new LoginController();

        private void bt_Login_Click(object sender, EventArgs e)
        {
            LoginAccount = txb_Account.Text;
            LoginPassword = txb_Password.Text;
            if (LC.CheckAccount(LoginAccount, LoginPassword))
                //Put next form here, gonna put a messagebox to fix this gasp
                MessageBox.Show("Đăng nhập thành công!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_Password.Clear();
            }
        }
    }
}
