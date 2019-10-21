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

        private void frm_CTHD_Load(object sender, EventArgs e)
        {
           
        }
    }
}
