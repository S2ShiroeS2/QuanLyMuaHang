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
        List<ListViewItem> listview_Ncc = new List<ListViewItem>();
        //Load dữ liệu sản phẩm từ database lên
        public List<ListViewItem> Load_List_Ncc(int product_id)
        {
            listview_Ncc.Clear();
            data_SP = new DataClasses1DataContext();
            var list_ncc = from product in data_SP.Products
                           join vendor_product in data_SP.VendorProducts on product.ProductID equals vendor_product.ProductID
                           join vendor in data_SP.Vendors on vendor_product.VendorID equals vendor.VendorID
                           where (vendor_product.ProductID== product_id)
                           select new
                           {
                               ten_ncc=vendor.VendorName
                           };
            foreach (var a in list_ncc)
            {
                ListViewItem b=new ListViewItem();
                b.Text= a.ten_ncc.ToString();
                listview_Ncc.Add(b);
            }
                
            return listview_Ncc;
        }
        //Đẩy sp vào list view
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
                                   NhaSX = SP.Manufacture,
                               };
            foreach (var SP in List_SanPham)
            {
                ListViewItem Items = new ListViewItem();
                Items.Text = SP.MaSP.ToString();
                Items.SubItems.Add(SP.TenSP);
                Items.SubItems.Add(SP.LoaiSP ? "Được bán" : "Không bán");
                Items.SubItems.Add(SP.DanhMucSP);
                Items.SubItems.Add(SP.SoLuong.ToString());
                Items.SubItems.Add(SP.Gia.ToString());
                Items.SubItems.Add(SP.NhaSX);
                list_SP.Add(Items);
            }
            return list_SP;
        }
        //Lấy ID sản phẩm lớn nhất
        public int GetMax_ProductID()
        {
            var list_SP = from Product in data_SP.Products
                       select Product.ProductID;
            return list_SP.Max();
        }
        public int GetMax_ProductCategoryID()
        {
            var list_ProductCategoryID = from Product in data_SP.ProductCategories
                          select Product.ProductCategoryID;
            return list_ProductCategoryID.Max();
        }
        //Thêm sản phẩm
        public Product Insert_Product(ListViewItem lvi_sp)
        {
            Product SP = new Product();
            SP.ProductID = Convert.ToInt32(lvi_sp.SubItems[0].Text);
            SP.ProductName = lvi_sp.SubItems[1].Text;
            SP.ProductType = lvi_sp.SubItems[2].Text == "Được bán" ? true : false;
            
            return SP;
        }
        //public void Insert_Product(ListViewItem lvi_sp)
        //{
        //    var SanPham_List = (from SP in data_SP.Products
        //                        where SP.ProductID.ToString() == lvi_sp.Text
        //                        select SP);
        //    foreach(Product SanPham in SanPham_List)
        //    {
        //        SanPham.ProductName = lvi_sp.SubItems[0].Text;
        //        SanPham.ProductType = lvi_sp.SubItems[1].Text == "Được bán" ? true : false;
        //        SanPham.ProductQuantity = Convert.ToInt32(lvi_sp.SubItems[2].Text);
        //        SanPham.ProductPrice = Convert.ToDouble(lvi_sp.SubItems[3].Text);
        //        SanPham.Manufacture = lvi_sp.SubItems[4].Text;
        //    }
        //}
    }
}
