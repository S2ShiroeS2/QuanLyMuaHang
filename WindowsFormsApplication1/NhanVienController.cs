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
    }
}
