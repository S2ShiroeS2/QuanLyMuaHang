using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class NhanVienController
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        List<ListViewItem> listNV = new List<ListViewItem>();


        public List<ListViewItem> NhanVienList()
        {

            var NhanVienVar = from V in data.NVs
                              select V;
            foreach (var V in NhanVienVar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = V.userID.ToString();
                lvi.SubItems.Add(V.userName);
                lvi.SubItems.Add(V.userAccount);
                lvi.SubItems.Add(V.userEmail);
                lvi.SubItems.Add(V.userPhone);
                listNV.Add(lvi);
            }

            return listNV;
        }

        public List<ListViewItem> NVListSearch(string SearchNameData)
        {
            listNV.Clear();
            //List<string> SearchName = new List<string>();
            var VendorVar = from V in data.NVs
                            where (V.userName.Contains(SearchNameData))
                            select V;
            foreach (var V in VendorVar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = V.userID.ToString();
                lvi.SubItems.Add(V.userName);
                lvi.SubItems.Add(V.userAccount);
                lvi.SubItems.Add(V.userPhone);
                lvi.SubItems.Add(V.userEmail);
                listNV.Add(lvi);
            }
            return listNV;

        }
    }
}
