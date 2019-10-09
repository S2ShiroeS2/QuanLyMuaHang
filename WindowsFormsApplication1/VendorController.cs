using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class VendorController
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        
        List<ListViewItem> listVendor = new List<ListViewItem>();
        

        public List<ListViewItem> VendorList() {
            listVendor.Clear();
            var VendorVar = from V in data.Vendors
                            select V;
            foreach (var V in VendorVar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = V.VendorID.ToString();
                lvi.SubItems.Add(V.VendorName);
                lvi.SubItems.Add(V.VendorAddress);
                lvi.SubItems.Add(V.VendorPhone);
                lvi.SubItems.Add(V.VendorEmail);
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
            foreach (var V in VendorVar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = V.VendorID.ToString();
                lvi.SubItems.Add(V.VendorName);
                lvi.SubItems.Add(V.VendorAddress);
                lvi.SubItems.Add(V.VendorPhone);
                lvi.SubItems.Add(V.VendorEmail);
                listVendor.Add(lvi);
            }
            return listVendor;

        }
    }
}
