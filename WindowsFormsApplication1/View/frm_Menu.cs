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
    public partial class frm_Menu : Form
    {
        private frm_QLHD frm_qlhd = new frm_QLHD();
        private frm_QLSP frm_qlsp = new frm_QLSP();
        private frm_QLNCC frm_qlncc = new frm_QLNCC();
        private frm_QLNV frm_qlnv = new frm_QLNV();
        private frm_TTCN frm_ttcn = new frm_TTCN();

        public frm_Menu()
        {
            InitializeComponent();
            UIBuilder.Border(this);
            UIBuilder.RenderButton(this);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            if (LoginController.UserRole == "True")
            {
                btn_QLNCC.Enabled = true;
                btn_QLNV.Enabled = true;
            }
            else
            {
                {
                    btn_QLNCC.Enabled = false;
                    btn_QLNV.Enabled = false;
                }
            }
            lb_Account.Text = LoginController.Account;
            lb_Name.Text = LoginController.Name;
            lb_Role.Text = (bool.Parse(LoginController.UserRole)?"Admin":"Nhân viên");
        }

        private void btn_QLHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_qlhd.ShowDialog();
            this.Show();
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_qlsp.ShowDialog();
            this.Show();
        }

        private void btn_QLNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_qlncc.ShowDialog();
            this.Show();
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_qlnv.ShowDialog();
            this.Show();
        }

        private void btn_ChangeInform_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ttcn.ShowDialog();
            this.Show();
        }

        private void btn_Exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
