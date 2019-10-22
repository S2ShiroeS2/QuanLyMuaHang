using System;
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
                                     where hd.orderID==i
                                     select new
                                     {
                                         ma_cthd=cthd.orderID,
                                         ten_sp=product.ProductName,
                                         so_luong=cthd.orderQuantity,
                                         don_gia=cthd.unitPrice,
                                         
                                     };
            foreach(var tmp in list_cthd)
            {

            }


            return list_cthd;
        }

    }
}
