﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1
{
    class VendorController
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        
        List<ListViewItem> listVendor = new List<ListViewItem>();
        

        public List<ListViewItem> VendorList() {
            listVendor.Clear();
            data = new DataClasses1DataContext();
            var VendorVar = from V in data.Vendors
                            select V;
            foreach (var V in VendorVar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = V.VendorID.ToString();
                lvi.SubItems.Add(V.VendorName);
                lvi.SubItems.Add(V.VendorAddress);
                lvi.SubItems.Add(V.VAT.ToString());
                lvi.SubItems.Add(V.VendorEmail);
                lvi.SubItems.Add(V.VendorPhone);
                lvi.SubItems.Add(V.VendorAvailable.ToString());
                listVendor.Add(lvi);
            }
            return listVendor;
        }
        public List<ListViewItem> VendorListSearch(string SearchNameData)
        {
            listVendor.Clear();
            //List<string> SearchName = new List<string>();
            var VendorVar = from V in data.Vendors
                            where (V.VendorName.Contains(SearchNameData))
                            select V;
            ListViewItem lvi = new ListViewItem();

            foreach (var V in VendorVar)
            {
                lvi.Text = V.VendorID.ToString();
                lvi.SubItems.Add(V.VendorName);
                lvi.SubItems.Add(V.VendorAddress);
                lvi.SubItems.Add(V.VAT.ToString());
                lvi.SubItems.Add(V.VendorEmail);
                lvi.SubItems.Add(V.VendorPhone);
                lvi.SubItems.Add(V.VendorAvailable.ToString());
                listVendor.Add(lvi);
            }
            return listVendor;
        }

        public int Get_Max_Vendor_id() {
            var list_ncc_id = from V_id in data.Vendors
                              select V_id.VendorID;
            int Max_Vendor_id = list_ncc_id.Max();
            return Max_Vendor_id;
        }

        public void VendorAddNew(ListViewItem lvi_vendor)
        {
            //Insert Ncc trong databse
            Vendor V = new Vendor();

            V.VendorID = Int32.Parse(lvi_vendor.Text);
            V.VendorName = lvi_vendor.SubItems[1].Text;
            V.VendorAddress = lvi_vendor.SubItems[2].Text;
            V.VAT = Int64.Parse(lvi_vendor.SubItems[3].Text);
            V.VendorEmail = lvi_vendor.SubItems[5].Text;
            V.VendorPhone = lvi_vendor.SubItems[4].Text;
            V.VendorAvailable = bool.Parse(lvi_vendor.SubItems[6].Text);
            data.Vendors.InsertOnSubmit(V);
            data.SubmitChanges();
        }

        public void SuaNcc(ListViewItem lvi_vendor) //Update Vendor trong database
        {
            data = new DataClasses1DataContext();
            Vendor VD = data.Vendors.First(x => x.VendorID.ToString() == lvi_vendor.Text);
            VD.VendorName = lvi_vendor.SubItems[1].Text;
            VD.VendorAddress = lvi_vendor.SubItems[2].Text;
            VD.VAT = Int64.Parse(lvi_vendor.SubItems[3].Text);
            VD.VendorPhone = lvi_vendor.SubItems[4].Text;
            VD.VendorEmail = lvi_vendor.SubItems[5].Text;
          //  VD.VendorAvailable = bool.Parse(lvi_vendor.SubItems[6].Text);
            
            data.SubmitChanges();
        }

        public List<ListViewItem> GetVendor(int ID) {
            
            var VendorListFromData= from V in data.Vendors
                            where V.VendorID == ID
                            select V;
            ListViewItem lvi = new ListViewItem();
            foreach (var V in VendorListFromData)
            {
                lvi.Text = V.VendorID.ToString();
                lvi.SubItems.Add(V.VendorName);
                lvi.SubItems.Add(V.VendorAddress);
                lvi.SubItems.Add(V.VAT.ToString());
                lvi.SubItems.Add(V.VendorEmail);
                lvi.SubItems.Add(V.VendorPhone);
                lvi.SubItems.Add(V.VendorAvailable.ToString());
                listVendor.Add(lvi);
            }
            return listVendor;
        }
    }
}
