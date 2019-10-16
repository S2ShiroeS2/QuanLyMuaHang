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

        public static ListViewItem lvi_them_ncc { get; private set; } = new ListViewItem();
        VendorController Vc = new VendorController();

        private void Enable_txb(bool Active)
        {
            txb_dia_chi.Enabled = txb_dt.Enabled=txb_NccEmail.Enabled=txb_ten_ncc.Enabled=txb_VAT.Enabled=Active;
        }

        private void formCT_ncc_Load(object sender, EventArgs e)
        {
            txb_dia_chi.Clear();
            txb_dt.Clear();
            txb_NccEmail.Clear();
            txb_NccID.Clear();
            txb_ten_ncc.Clear();
            txb_Available.Clear();
            if (Form_QLNCC.flag_ncc == false)
            {
                txb_NccID.Text = Form_QLNCC.lvi_ncc.SubItems[0].Text;
                txb_ten_ncc.Text = Form_QLNCC.lvi_ncc.SubItems[1].Text;
                txb_dia_chi.Text = Form_QLNCC.lvi_ncc.SubItems[2].Text;
                txb_VAT.Text = Form_QLNCC.lvi_ncc.SubItems[3].Text;
                txb_NccEmail.Text = Form_QLNCC.lvi_ncc.SubItems[4].Text;
                txb_dt.Text = Form_QLNCC.lvi_ncc.SubItems[5].Text;
                txb_Available.Text = Form_QLNCC.lvi_ncc.SubItems[6].Text;
                bt_tao_ncc.Enabled = false;
                bt__sua_ncc.Enabled = true;

                Enable_txb(false);
            }
            else {
                bt_tao_ncc.Enabled = true;
                bt__sua_ncc.Enabled = false;
                int Next_Vendor_Id = Vc.Get_Max_Vendor_id()+1;
                txb_NccID.Text = Next_Vendor_Id.ToString();
            }

        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            ListViewItem lvi_them_ncc = new ListViewItem();
            lvi_them_ncc.Text = txb_NccID.Text;
            lvi_them_ncc.SubItems.Add(txb_ten_ncc.Text);
            lvi_them_ncc.SubItems.Add(txb_dia_chi.Text);
            lvi_them_ncc.SubItems.Add(txb_VAT.Text);
            lvi_them_ncc.SubItems.Add(txb_dt.Text);
            lvi_them_ncc.SubItems.Add(txb_NccEmail.Text);
            lvi_them_ncc.SubItems.Add(false.ToString());
            lvi_them_ncc.SubItems.Add(txb_Available.Text);
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
