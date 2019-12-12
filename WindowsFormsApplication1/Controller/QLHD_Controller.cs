using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;
namespace WindowsFormsApplication1
{
    // <summary>
    // QLHD_Controller cung cấp các phương thức để trả về dữ liệu cho frm_QLHD và kết nối với database để xử lí dữ liệu
    // </summary>

    class QLHD_Controller
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        // <summary>
        // trả về một danh sách listviewitem của list view hóa đơn
        // </summary>

        public List<ListViewItem> load_list_hd()
        {
            List<ListViewItem> list_lvi_hd = new List<ListViewItem>(); // Mảng lưu trữ thông tin của danh sách hóa đơn
            var data_hd = from hd in data.OrderTables                                           // biến lấy danh sách các hóa đơn trong database
                          join vd in data.Vendors on hd.VendorID equals vd.VendorID
                          join nv in data.NVs on hd.userID equals nv.userID
                          join od in data.OrderDetails on hd.orderID equals od.orderID
                          group od by new { hd.orderID, hd.orderDate, vd.VendorName, nv.userName, hd.status } into g
                          select new
                          {
                              mahd = g.Key.orderID,
                              ngay_dat = g.Key.orderDate,
                              nha_cc = g.Key.VendorName,
                              ten_nv = g.Key.userName,
                              tinh_trang = g.Key.status,
                              tong_tien = g.Sum(x => x.orderQuantity * x.UnitPrice * (1 + x.tax / 100))
                          };
            foreach(var a in data_hd)
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                string tinh_trang = "";
                ListViewItem hd = new ListViewItem();// thông tin 1 hóa đơn được lưu trong một listviewitem
                hd.Text = a.mahd.ToString();
                hd.SubItems.Add(a.ngay_dat.ToShortDateString());
                hd.SubItems.Add(a.nha_cc.ToString());
                hd.SubItems.Add(a.ten_nv.ToString());
                if (a.tinh_trang == 1)
                    tinh_trang = "Đang yêu cầu";
                else if (a.tinh_trang == 2)
                    tinh_trang = "Đã nhận hàng";
                else
                    tinh_trang = "Đã hủy";
                hd.SubItems.Add(tinh_trang);
                hd.SubItems.Add(a.tong_tien.ToString("#,0.00", nfi));
                list_lvi_hd.Add(hd);
            }
            return list_lvi_hd;
        }

        public void thay_doi_tinh_trang_HD(int id,string a)
        {
            OrderTable hd_sp = data.OrderTables.First(x => x.orderID == id);
            hd_sp.status = a == "Đang yêu cầu" ? 0 : 1;
            data.SubmitChanges();
            
        }
    }
}
