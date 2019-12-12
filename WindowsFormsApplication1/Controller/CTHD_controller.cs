using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1
{
    //
    //  Class dùng để nhận dữ liệu từ form chi tiết hóa đơn và kết nối với database để lấy dữ liệu trả về
    //
    class CTHD_controller
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public static ListViewItem sp_moi = new ListViewItem();

        public List<ListViewItem> load_list_lvi_cthd(int i)
        {
            List<ListViewItem> list_cthd = new List<ListViewItem>();
            var list_database_cthd = from cthd in data.OrderDetails
                                     join hd in data.OrderTables on cthd.orderID equals hd.orderID
                                     join vd in data.Vendors on hd.VendorID equals vd.VendorID
                                     join vdpro in data.VendorProducts on cthd.ProductID equals vdpro.ProductID
                                     join product in data.Products on vdpro.ProductID equals product.ProductID
                                     where hd.orderID == i
                                     where vdpro.VendorID == hd.VendorID
                                     select new
                                     {
                                         ma_cthd = cthd.orderDetailID,
                                         ten_sp = product.ProductName,
                                         so_luong = cthd.orderQuantity,
                                         don_gia = cthd.UnitPrice,
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
            if (id.Count() >0)
                return id.Max() + 1;
            else
                return 1;
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




        /*  public void Them_SP_vao_HD(ListViewItem lvi_SP)
          {
              OrderDetail cthd = new OrderDetail();
              cthd.orderDetailID = data.OrderDetails.Max(x => x.orderDetailID) + 1;
              cthd.orderID = Convert.ToInt32( frm_CTHD.ma_hd);
              cthd.ProductID = data.Products.First(x=>x.ProductName==lvi_SP.SubItems[0].Text).ProductID ;
              cthd.orderQuantity= Convert.ToInt32(lvi_SP.SubItems[1].Text); 
              cthd.tax=Convert.ToDouble(lvi_SP.SubItems[2].Text);
              data.OrderDetails.InsertOnSubmit(cthd);
              data.SubmitChanges();
          }
          */
        public ListViewItem Them_SP(ListViewItem lvi_SP)
        {
            ListViewItem lvi_ctsp = new ListViewItem();
            if (data.OrderDetails.Select(X => X.orderDetailID).ToList().Count > 0)
            {
                lvi_ctsp.Text = (data.OrderDetails.Max(x => x.orderDetailID) + 1).ToString();
            }
            else
                lvi_ctsp.Text = "1";
            lvi_ctsp.SubItems.Add(lvi_SP.SubItems[0]);
            lvi_ctsp.SubItems.Add(lvi_SP.SubItems[1]);
            lvi_ctsp.SubItems.Add(lvi_SP.SubItems[2]);
            lvi_ctsp.SubItems.Add(lvi_SP.SubItems[3]);
            lvi_ctsp.SubItems.Add(lvi_SP.SubItems[4]);
            return lvi_ctsp;
        }

        public ListViewItem Sua_SP(ListViewItem lvi_SP)
        {
            ListViewItem lvi_ctsp = new ListViewItem();
            lvi_ctsp = lvi_SP;
            return lvi_ctsp;
        }
        public ListViewItem load_ctsp()
        {
            return frm_CTHD.selected_SP;
        }


        public void Luu_HD(ListView.ListViewItemCollection list_cthd,string mahd,string ncc, DateTimePicker ngay_dat_hang)
        {
            OrderTable hd = new OrderTable();
            

            hd.orderID = Convert.ToInt32( mahd);
            hd.userID = 1;
           // hd.userID = data.NVs.First(x=>x.userAccount==frm_Login.LoginAccount).userID;
            //Them User ID sau
            hd.status = 1;
            hd.orderDate = Convert.ToDateTime(ngay_dat_hang.Value.ToShortDateString());
            hd.VendorID =data.Vendors.First(x => x.VendorName == ncc).VendorID;
            data.OrderTables.InsertOnSubmit(hd);
            data.SubmitChanges();
            foreach (ListViewItem lvi in list_cthd)
            {
                if(lvi.Text!="Thêm sản phẩm")
                {
                    OrderDetail cthd = new OrderDetail();
                    cthd.orderDetailID = Convert.ToInt32(lvi.SubItems[0].Text);
                    cthd.orderID = hd.orderID;
                    cthd.ProductID = data.Products.First(x => x.ProductName == lvi.SubItems[1].Text).ProductID;
                    cthd.tax = Convert.ToDouble(lvi.SubItems[4].Text);
                    cthd.UnitPrice = Convert.ToInt32(lvi.SubItems[3].Text);
                    cthd.orderQuantity = Convert.ToInt32(lvi.SubItems[2].Text);
                    data.OrderDetails.InsertOnSubmit(cthd);
                    data.SubmitChanges();
                }          
            }
        }
    }
}
