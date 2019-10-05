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
        
        List<ListViewItem> lvi1 = new List<ListViewItem>();//The nay a?
        //uk

        public List<ListViewItem> VendorList() {
            
            var VendorVar = from V in data.Vendors
                            select V;
            foreach (var V in VendorVar)
            {
                ListViewItem lvi = new ListViewItem();//hay vcl :D
                lvi.Text = V.VendorID.ToString();
                lvi.SubItems.Add(V.VendorName);
                lvi.SubItems.Add(V.VendorAddress);
                lvi.SubItems.Add(V.VendorPhone);
                lvi.SubItems.Add(V.VendorEmail);
                lvi1.Add(lvi);
            }
            
            return lvi1;
        }
    }
}
