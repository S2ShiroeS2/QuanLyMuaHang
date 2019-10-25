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
        private VendorController Vc = new VendorController();
        private ErrorProvider EP = new ErrorProvider();

        private void Enable_txb(bool Active)
        {
            txb_VendorAddress.Enabled = txb_Phone.Enabled=txb_VendorEmail.Enabled=txb_VendorName.Enabled=nbb_Vat.Enabled=Active;
        }

        private void formCT_ncc_Load(object sender, EventArgs e)
        {
            txb_VendorAddress.Clear();
            txb_Phone.Clear();
            txb_VendorEmail.Clear();
            txb_VendorID.Clear();
            txb_VendorName.Clear();
            txb_Available.Clear();
            if (Form_QLNCC.flag_ncc == false)
            {
                txb_VendorID.Text = Form_QLNCC.lvi_ncc.SubItems[0].Text;
                txb_VendorName.Text = Form_QLNCC.lvi_ncc.SubItems[1].Text;
                txb_VendorAddress.Text = Form_QLNCC.lvi_ncc.SubItems[2].Text;
                nbb_Vat.Value = int.Parse(Form_QLNCC.lvi_ncc.SubItems[3].Text);
                txb_VendorEmail.Text = Form_QLNCC.lvi_ncc.SubItems[4].Text;
                txb_Phone.Text = Form_QLNCC.lvi_ncc.SubItems[5].Text;
                txb_Available.Text = Form_QLNCC.lvi_ncc.SubItems[6].Text;
                btn_UpdateVendor.Enabled = true;

                Enable_txb(false);
            }
            else {
                btn_UpdateVendor.Enabled = false;
                txb_Available.Text = "False";
                int Next_Vendor_Id = Vc.Get_Max_Vendor_id()+1;
                txb_VendorID.Text = Next_Vendor_Id.ToString();
            }

        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            ListViewItem lvi_them_ncc = new ListViewItem();
            lvi_them_ncc.Text = txb_VendorID.Text;
            lvi_them_ncc.SubItems.Add(txb_VendorName.Text);
            lvi_them_ncc.SubItems.Add(txb_VendorAddress.Text);
            lvi_them_ncc.SubItems.Add(nbb_Vat.Value.ToString());
            lvi_them_ncc.SubItems.Add(txb_Phone.Text);
            lvi_them_ncc.SubItems.Add(txb_VendorEmail.Text);
            lvi_them_ncc.SubItems.Add(false.ToString());
            lvi_them_ncc.SubItems.Add(txb_Available.Text);
            if (Form_QLNCC.flag_ncc)
                Vc.VendorAddNew(lvi_them_ncc);
            else
                Vc.SuaNcc(lvi_them_ncc);

            MessageBox.Show("Lưu thành công");
            this.Close();
            
        }

        private void bt__sua_ncc_Click(object sender, EventArgs e)
        {
            Enable_txb(true);
        }

        //Set ErrorPRovider cho txb_VendorName
        private void txb_ten_ncc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_VendorName.Text))
            {
                e.Cancel = true;
                txb_VendorName.Focus();
                EP.SetError(txb_VendorName, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_VendorName, null);
            }
        }

        private void nbb_Vat_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nbb_Vat.Value.ToString()))
            {
                e.Cancel = true;
                nbb_Vat.Focus();
                EP.SetError(nbb_Vat, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(nbb_Vat, null);
            }
        }

        private void txb_VendorAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_VendorAddress.Text))
            {
                e.Cancel = true;
                txb_VendorAddress.Focus();
                EP.SetError(txb_VendorAddress, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_VendorAddress, null);
            }
        }

        private void txb_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Phone.Text))
            {
                e.Cancel = true;
                txb_Phone.Focus();
                EP.SetError(txb_Phone, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_Phone, null);
            }
        }

        private void txb_VendorEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_VendorEmail.Text))
            {
                e.Cancel = true;
                txb_VendorEmail.Focus();
                EP.SetError(txb_VendorEmail, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_VendorEmail, null);
            }
        }
    }
}
