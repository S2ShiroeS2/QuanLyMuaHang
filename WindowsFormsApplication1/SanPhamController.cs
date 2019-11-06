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
                           where (vendor_product.ProductID == product_id)
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
                                   NhaSX = SP.Manufacture,
                               };
            foreach (var SP in List_SanPham)
            {
                ListViewItem Items = new ListViewItem();
                Items.Text = SP.MaSP.ToString();
                Items.SubItems.Add(SP.TenSP);
                Items.SubItems.Add(SP.LoaiSP ? "Được bán" : "Không bán");
                Items.SubItems.Add(SP.DanhMucSP);
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

        //Load danh mục sản phẩm
        public List<string> load_List_Category()
        {
            List<string> list_Load = new List<string>();
            var list_Category = from cate in data_SP.ProductCategories
                           select cate;
            foreach (var cate in list_Category)
                list_Load.Add(cate.ProductCategoryName);
            return list_Load;
        }
        //Thêm sản phẩm
        public void Insert_Product(ListViewItem lvi_sp,ListView.ListViewItemCollection list_ncc)
        {
            Product product = new Product();
            ProductCategory catagory_Product = new ProductCategory();
            VendorProduct vendor_Product = new VendorProduct();
            product.ProductID = Convert.ToInt32(lvi_sp.SubItems[0].Text);
            product.ProductName = lvi_sp.SubItems[1].Text;
            product.ProductType = lvi_sp.SubItems[2].Text == "Được bán" ? true : false;
            product.ProductCategoryID = data_SP.ProductCategories.First(x => x.ProductCategoryName == lvi_sp.SubItems[3].Text).ProductCategoryID;
            product.Manufacture = lvi_sp.SubItems[4].Text;
            data_SP.Products.InsertOnSubmit(product);
            data_SP.SubmitChanges();
            foreach (ListViewItem i in list_ncc)
            {
                vendor_Product.ProductID = product.ProductID;
                vendor_Product.VendorID = data_SP.Vendors.First(x => x.VendorName == i.Text).VendorID;
                data_SP.VendorProducts.InsertOnSubmit(vendor_Product);
                data_SP.SubmitChanges();
            }
        }

        //Sửa thông tin sản phẩm
        public void Edit_Poduct(ListViewItem lvi_products, ListView.ListViewItemCollection list_Vendors)
        {
            Product product = data_SP.Products.First(x => x.ProductID ==Convert.ToInt32( lvi_products.SubItems[0].Text));
            ProductCategory catagory_Product = new ProductCategory();
            
          
            product.ProductName = lvi_products.SubItems[1].Text;
            product.ProductType = lvi_products.SubItems[2].Text == "Được bán" ? true : false;
            product.ProductCategoryID = data_SP.ProductCategories.First(x => x.ProductCategoryName == lvi_products.SubItems[3].Text).ProductCategoryID;
            product.Manufacture = lvi_products.SubItems[4].Text;
            data_SP.SubmitChanges();
            foreach (ListViewItem i in list_Vendors)
            {
                VendorProduct vendor_Product = new VendorProduct();
                int vendor_id = data_SP.Vendors.First(x => x.VendorName == i.Text).VendorID;
                
                if(data_SP.VendorProducts.FirstOrDefault(x=>x.VendorID==vendor_id&&x.ProductID==product.ProductID)==null)
                {
                    vendor_Product.ProductID = product.ProductID;
                    vendor_Product.VendorID = data_SP.Vendors.First(x => x.VendorName == i.Text).VendorID;
                    data_SP.VendorProducts.InsertOnSubmit(vendor_Product);
                    data_SP.SubmitChanges();
                }
                
            }

        }

        public List<ListViewItem> Search_Product(String name_Product)
        {
            bool flag_Search = false; 
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
                                   NhaSX = SP.Manufacture,
                               };
            foreach (var SP in List_SanPham)
            {
                if(SP.TenSP == name_Product)
                {
                    ListViewItem Items = new ListViewItem();
                    Items.Text = SP.MaSP.ToString();
                    Items.SubItems.Add(SP.TenSP);
                    Items.SubItems.Add(SP.LoaiSP ? "Được bán" : "Không bán");
                    Items.SubItems.Add(SP.DanhMucSP);
                    Items.SubItems.Add(SP.NhaSX);
                    list_SP.Add(Items);
                    flag_Search = true;
                }
            }
            if(flag_Search == false)
            {
                if(name_Product.Length>0)
                    MessageBox.Show("Không tìm thấy!");
            }
            return list_SP;
        }

        public int load_ma_danh_muc_max()
        {
            var list_danh_muc = from dm in data_SP.ProductCategories
                                select dm.ProductCategoryID;
            
            return list_danh_muc.Max()+1;
        }

        public void luu_danh_muc_moi(int ma_dm,string ten_dm)
        {
            ProductCategory danh_muc_moi = new ProductCategory();
            if (data_SP.ProductCategories.FirstOrDefault(x => x.ProductCategoryName == ten_dm) == null)
            {
                danh_muc_moi.ProductCategoryID = ma_dm;
                danh_muc_moi.ProductCategoryName = ten_dm;
                data_SP.ProductCategories.InsertOnSubmit(danh_muc_moi);
                data_SP.SubmitChanges();
            }
            else
                MessageBox.Show("Đã tồn tại tên danh mục này");

        }
    }
}
