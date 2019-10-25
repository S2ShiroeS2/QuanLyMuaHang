﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //
    //  Class dùng để nhận dữ liệu từ form chi tiết hóa đơn và kết nối với database để lấy dữ liệu trả về
    //
    class CTHD_controller
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        public List<ListViewItem> load_list_lvi_cthd(int i)
        {
            List<ListViewItem> list_cthd = new List<ListViewItem>();
            var list_database_cthd = from hd in data.OrderTables
                                     join cthd in data.OrderDetails on hd.orderID equals cthd.orderID
                                     join vd in data.Vendors on hd.VendorID equals vd.VendorID
                                     join vdpro in data.VendorProducts on cthd.ProductID equals vdpro.ProductID
                                     join product in data.Products on vdpro.ProductID equals product.ProductID
                                     where hd.orderID == i
                                     where vdpro.VendorID == hd.VendorID
                                     select new
                                     {
                                         ma_cthd = cthd.orderID,
                                         ten_sp = product.ProductName,
                                         so_luong = cthd.orderQuantity,
                                         don_gia = product.ProductPrice,
                                         thue = cthd.tax
                                     };
            foreach (var tmp in list_database_cthd)
            {
                ListViewItem cthd = new ListViewItem();
                cthd.Text = tmp.ma_cthd.ToString();
                cthd.SubItems.Add(tmp.ten_sp);
                cthd.SubItems.Add(tmp.so_luong.ToString());
                cthd.SubItems.Add(tmp.don_gia.ToString());
                cthd.SubItems.Add(tmp.thue.ToString());
                cthd.SubItems.Add((tmp.so_luong * tmp.don_gia).ToString());
                list_cthd.Add(cthd);
            }


            return list_cthd;
        }

        public List<string> load_list_ncc()
        {
            List<string> a = new List<string>();
            var list_ncc = from ncc in data.Vendors
                    select ncc;
            foreach (var ncc in list_ncc)
                a.Add(ncc.VendorName);
            return a;
        }

        public int tao_ma_hd_moi()
        {
            var id=from hd in data.OrderTables
                   select hd.orderID;
            return id.Max()+1;
        }

        public List<string> load_list_sp(string ncc)
        {
            List<string> a = new List<string>();
            var list_sp = from sp in data.Products
                          join vd_p in data.VendorProducts on sp.ProductID equals vd_p.ProductID
                          join vd in data.Vendors on vd_p.VendorID equals vd.VendorID
                          where vd.VendorName==ncc
                           select sp.ProductName;
            foreach (var sp in list_sp)
                a.Add(sp);
            return a;
        }

        public double load_gia_tien_sp(string ten_sp)
        {
           double giasp=0;
           var i = from p in data.Products
                  where p.ProductName == ten_sp
                  select p;
            foreach (var sp in i)
            {
                giasp = sp.ProductPrice;
                break;
            }
            return giasp;
        }
    }
}
