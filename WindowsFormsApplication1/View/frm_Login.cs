﻿using System;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
            //this.InitBorder();
        }
        

        public static string LoginAccount { get; private set; }
        public static string LoginPassword { get; private set; }
        private LoginController LC = new LoginController();
        private frm_Menu frm_menu= new frm_Menu();
        private void bt_Login_Click(object sender, EventArgs e)
        {
            LoginAccount = txb_Account.Text;
            LoginPassword = txb_Password.Text.GetHashCode().ToString();
            if (LC.CheckAccount(LoginAccount, LoginPassword))
            {
                this.Hide();
                frm_menu.ShowDialog();
                txb_Password.Clear();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_Password.Clear();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
