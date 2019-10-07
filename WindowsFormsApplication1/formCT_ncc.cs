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
    public partial class formCT_ncc : Form
    {
        public formCT_ncc()
        {
            InitializeComponent();
        }

        private void formCT_ncc_Load(object sender, EventArgs e)
        {
            tb_dia_chi.Clear();
            tb_dt.Clear();
            tb_NccEmail.Clear();
            tb_NccID.Clear();
            tb_ten_ncc.Clear();
            
        }
    }
}
