using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var data_hd = from hd in data.OrderTables
                          join cthd in data.OrderDetails on hd.orderID equals cthd.orderID
                          join vd in data.Vendors on hd.VendorID equals vd.VendorID
                          join nv in data.NVs on hd.userID equals nv.userID
                          select new
                          {
                              mahd= hd.orderID,
                              ngay_dat=hd.orderDate,
                              nha_cc= vd.VendorName,
                              ten_nv=nv.userName,
                              tinh_trang=hd.status,
                              tax=hd.tax,
                              tong_tien=hd.total
                          };
            foreach(var a in data_hd)
            {
                ListViewItem hd = new ListViewItem();// thông tin 1 hóa đơn được lưu trong một listviewitem
                hd.Text = a.mahd.ToString();
                hd.SubItems.Add(a.ngay_dat.ToString());
                hd.SubItems.Add(a.nha_cc.ToString());
                hd.SubItems.Add(a.ten_nv.ToString());
                hd.SubItems.Add(a.tinh_trang.ToString());
                hd.SubItems.Add(a.tax.ToString());
                hd.SubItems.Add(a.tong_tien.ToString());
                list_lvi_hd.Add(hd);
            }
            return list_lvi_hd;
        }

    }
}
