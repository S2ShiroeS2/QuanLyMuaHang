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
    public partial class frm_CTHD : Form
    {
        public frm_CTHD()
        {
            InitializeComponent();
        }

        private void MS_sua_HD_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
        }

        private void MS_xoa_HD_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }


        //
        // Hàm dùng để điều khiển các control trong form
        //
        private void enable_control(bool flag)
        {
            btn_luu.Enabled =cbo_nha_cc.Enabled= flag;
            btn_sua.Enabled = !flag;
        }

        private void frm_CTHD_Load(object sender, EventArgs e)
        {
           if(frm_QLHD.flag==true)
            {
                enable_control(frm_QLHD.flag);
            }
           else
            {
                enable_control(frm_QLHD.flag);
            }
        }
    }
}
