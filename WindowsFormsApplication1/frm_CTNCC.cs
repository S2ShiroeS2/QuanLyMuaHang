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
    public partial class frm_CTNCC : Form
    {
        public frm_CTNCC()
        {
            InitializeComponent();
        }

        public static ListViewItem lvi_them_ncc { get; private set; } = new ListViewItem();
        private VendorController Vc = new VendorController();
        private ErrorProvider EP = new ErrorProvider();
        private bool flag_1 = false;
        private bool flag_2 = false;
        private bool flag_3 = false;
        private bool flag_4 = false;

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
            if (frm_QLNCC.flag_ncc == false)
            {
                txb_VendorID.Text = frm_QLNCC.lvi_ncc.SubItems[0].Text;
                txb_VendorName.Text = frm_QLNCC.lvi_ncc.SubItems[1].Text;
                txb_VendorAddress.Text = frm_QLNCC.lvi_ncc.SubItems[2].Text;
                nbb_Vat.Value = int.Parse(frm_QLNCC.lvi_ncc.SubItems[3].Text);
                txb_VendorEmail.Text = frm_QLNCC.lvi_ncc.SubItems[4].Text;
                txb_Phone.Text = frm_QLNCC.lvi_ncc.SubItems[5].Text;
                txb_Available.Text = frm_QLNCC.lvi_ncc.SubItems[6].Text;
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
            if (frm_QLNCC.flag_ncc)
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

        private void EnableSaveBtn()
        {
            if (flag_1 == true && flag_2 == true && flag_3 == true && flag_4 == true )
                btn_SaveVendor.Enabled = true;
            else
                btn_SaveVendor.Enabled = false;
        }

        //Set ErrorPRovider cho txb_VendorName
        private void txb_ten_ncc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_VendorName.Text))
            {
                e.Cancel = true;
                txb_VendorName.Focus();
                EP.SetError(txb_VendorName, "Không được để trống");
                flag_1 = false;
                EnableSaveBtn();
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_VendorName, null);
                flag_1 = true;
                EnableSaveBtn();
            }
        }


        private void txb_VendorAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_VendorAddress.Text))
            {
                e.Cancel = true;
                txb_VendorAddress.Focus();
                EP.SetError(txb_VendorAddress, "Không được để trống");
                flag_3 = false;
                EnableSaveBtn();
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_VendorAddress, null);
                flag_3 = true;
                EnableSaveBtn();
            }
        }

        private void txb_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Phone.Text))
            {
                e.Cancel = true;
                txb_Phone.Focus();
                EP.SetError(txb_Phone, "Không được để trống");
                flag_4 = false;
                EnableSaveBtn(); 
            }else
                if(!System.Text.RegularExpressions.Regex.IsMatch(txb_Phone.Text, "^[0-9]+$"))//Regex cho nhập chữ Tiếng Việt
                {
                e.Cancel = true;
                txb_Phone.Focus();
                EP.SetError(txb_Phone, "Số điện thoại không hợp lệ");
                flag_4 = false;
                EnableSaveBtn();
            }
                else
                {
                    e.Cancel = false;
                    EP.SetError(txb_Phone, null);
                    flag_4 = true;
                    EnableSaveBtn();
                }
        }

        private void txb_VendorEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_VendorEmail.Text))
            {
                e.Cancel = true;
                txb_VendorEmail.Focus();
                EP.SetError(txb_VendorEmail, "Không được để trống");
                flag_2 = false;
                EnableSaveBtn();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txb_VendorEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))//Regex email
            {
                e.Cancel = true;
                txb_VendorEmail.Focus();
                EP.SetError(txb_VendorEmail, "Email không hợp lệ");
                flag_3 = false;
                EnableSaveBtn();
            }
            else
            {
                e.Cancel = false;
                EP.SetError(txb_VendorEmail, null);
                flag_2 = true;
                EnableSaveBtn();
            }
        }
    }
}
