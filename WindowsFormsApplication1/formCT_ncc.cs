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

        public static ListViewItem lvi_them_ncc = new ListViewItem();
        VendorController Vc = new VendorController();

        private void Enable_txb(bool Active)
        {
            tb_dia_chi.Enabled = tb_dt.Enabled=tb_NccEmail.Enabled=tb_ten_ncc.Enabled=Active;
        }

        private void formCT_ncc_Load(object sender, EventArgs e)
        {
            tb_dia_chi.Clear();
            tb_dt.Clear();
            tb_NccEmail.Clear();
            tb_NccID.Clear();
            tb_ten_ncc.Clear();

            if (Form_QLNCC.flag_ncc == false)
            {
                tb_NccID.Text = Form_QLNCC.lvi_ncc.SubItems[0].Text;
                tb_ten_ncc.Text = Form_QLNCC.lvi_ncc.SubItems[1].Text;
                tb_dia_chi.Text = Form_QLNCC.lvi_ncc.SubItems[2].Text;
                tb_dt.Text = Form_QLNCC.lvi_ncc.SubItems[3].Text;
                tb_NccEmail.Text = Form_QLNCC.lvi_ncc.SubItems[4].Text;
                bt_tao_ncc.Enabled = false;
                bt__sua_ncc.Enabled = true;

                Enable_txb(false);
            }
            else {
                bt_tao_ncc.Enabled = true;
                bt__sua_ncc.Enabled = false;
                int Next_Vendor_Id = Vc.Get_Max_Vendor_id()+1;
                tb_NccID.Text = Next_Vendor_Id.ToString();
            }

        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            
            lvi_them_ncc.Text = tb_NccID.Text;
            lvi_them_ncc.SubItems.Add(tb_ten_ncc.Text);
            lvi_them_ncc.SubItems.Add(tb_dia_chi.Text);
            lvi_them_ncc.SubItems.Add(tb_dt.Text);
            lvi_them_ncc.SubItems.Add(tb_NccEmail.Text);
            lvi_them_ncc.SubItems.Add(false.ToString());

            if (Form_QLNCC.flag_ncc)
                Vc.VendorAddNew(lvi_them_ncc);
            else
                Vc.SuaNcc(lvi_them_ncc);

            MessageBox.Show("Lưu thành công");
        }

        private void bt__sua_ncc_Click(object sender, EventArgs e)
        {
            Enable_txb(true);
        }
    }
}
