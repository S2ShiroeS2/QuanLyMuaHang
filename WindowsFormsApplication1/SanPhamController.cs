using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class SanPhamController
    {
        DataClasses1DataContext data_SP = new DataClasses1DataContext();
        List<ListViewItem> list_SP = new List<ListViewItem>();
        //Đẩy sp vào list view

        //Load dữ liệu sản phẩm từ database lên
        public List<ListViewItem> Load_List_San_Pham()
        {
            list_SP.Clear();
            data_SP = new DataClasses1DataContext();
            var List_SanPham = from SP in data_SP.Products
                               join PC in data_SP.ProductCategories on SP.ProductCategoryID equals PC.ProductCategoryID
                               select new
                               {
                                   MaSP = SP.ProductID,
                                   TenSP = SP.ProductName,
                                   LoaiSP = SP.ProductType,
                                   DanhMucSP = PC.ProductCategoryName,
                                   SoLuong = SP.ProductQuantity,
                                   Gia = SP.ProductPrice,
                               };
            foreach (var SP in List_SanPham)
            {
                ListViewItem Items = new ListViewItem();
                Items.Text = SP.MaSP.ToString();
                Items.SubItems.Add(SP.TenSP);
                Items.SubItems.Add(SP.LoaiSP ? "Được bán" : "Không bán");
                Items.SubItems.Add(SP.DanhMucSP);
                Items.SubItems.Add(SP.Gia.ToString());
                list_SP.Add(Items);
            }
            return list_SP;
        }
        //Tìm kiếm sản phẩm
    }
}
