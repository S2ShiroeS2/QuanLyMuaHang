﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1
{
    class NhaCungCapController
    {
        DataClasses1DataContext data_ncc = new DataClasses1DataContext();
        List<ListViewItem> listview_Ncc = new List<ListViewItem>();

        //Load dữ liệu sản phẩm từ database lên
        public List<ListViewItem> Load_Ncc()
        {
            listview_Ncc.Clear();
            data_ncc = new DataClasses1DataContext();
            var list_ncc = from Vendor in data_ncc.Vendors
                           select new
                           {
                               ten_ncc = Vendor.VendorName
                           };
            foreach (var ncc in list_ncc)
            {
                ListViewItem lvi_tmp = new ListViewItem();
                lvi_tmp.Text = ncc.ten_ncc.ToString();
                listview_Ncc.Add(lvi_tmp);
            }
            return listview_Ncc;
        }
        //Đẩy sp vào list view

        public bool Check_current_Ncc(string Ncc_selected,int id_sp)
        {
            int vendor_id = data_ncc.Vendors.Single(x => x.VendorName == Ncc_selected).VendorID;
            VendorProduct check = data_ncc.VendorProducts.SingleOrDefault(x => x.VendorID == vendor_id&&x.ProductID==id_sp);
            if (check == null)
                return false;
            else
                return true;
        }

        public string load_ten_sp(int id)
        {
            if( data_ncc.Products.SingleOrDefault(x => x.ProductID == id)!=null)
                return data_ncc.Products.SingleOrDefault(x => x.ProductID == id).ProductName;
            return "";
        }
    }
}
