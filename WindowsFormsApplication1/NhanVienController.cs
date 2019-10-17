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
                if (V.role)
                    lvi.SubItems.Add("Admin");
                else
                    lvi.SubItems.Add("Nhân viên");
                lvi.SubItems.Add(V.activation.ToString());
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
                lvi.SubItems.Add(V.userEmail);
                lvi.SubItems.Add(V.userPhone);
                if (V.role)
                    lvi.SubItems.Add("Admin");
                else
                    lvi.SubItems.Add("Nhân viên");
                lvi.SubItems.Add(V.activation.ToString());
                listNV.Add(lvi);
            }
            return listNV;

        }

        public int GetMaxNVID()
        {
            var list = from NV_id in data.NVs
                              select NV_id.userID;
            return list.Max();
        }

        public void NVAddNew(ListViewItem lvi_nv)
        {
            //Insert Ncc trong databse
            NV V = new NV();

            V.userID = Int32.Parse(lvi_nv.Text);
            V.userName = lvi_nv.SubItems[1].Text;
            V.userAccount = lvi_nv.SubItems[2].Text;
            V.userEmail = lvi_nv.SubItems[3].Text;
            V.userPhone = lvi_nv.SubItems[5].Text;
            V.role= bool.Parse(lvi_nv.SubItems[6].Text);
            V.activation = bool.Parse(lvi_nv.SubItems[7].Text);

            data.NVs.InsertOnSubmit(V);
            data.SubmitChanges();
        }

        public void UpdateNV(ListViewItem lvi_nv) //Update Vendor trong database
        {
            data = new DataClasses1DataContext();
            var NhanVienList = (from a in data.NVs
                              where a.userID.ToString() == lvi_nv.Text
                              select a);
            foreach (NV V in NhanVienList)
            {
                V.userID = Int32.Parse(lvi_nv.Text);
                V.userName = lvi_nv.SubItems[1].Text;
                V.userAccount = lvi_nv.SubItems[2].Text;
                V.userEmail = lvi_nv.SubItems[3].Text;
                V.userPhone = lvi_nv.SubItems[5].Text;
                V.role = bool.Parse(lvi_nv.SubItems[6].Text);
                V.activation = bool.Parse(lvi_nv.SubItems[7].Text);
            }
            data.SubmitChanges();
        }

        //Lay thong tin NV qua ID cua nv do
        public List<ListViewItem> GetNV(int ID)
        {

            var NVListFromData = from V in data.NVs
                                     where V.userID == ID
                                     select V;
            ListViewItem lvi = new ListViewItem();
            foreach (var V in NVListFromData)
            {
                lvi.Text = V.userID.ToString();
                lvi.SubItems.Add(V.userName);   
                lvi.SubItems.Add(V.userAccount);
                lvi.SubItems.Add(V.userEmail);
                lvi.SubItems.Add(V.userPhone);
                lvi.SubItems.Add(V.role.ToString());
                lvi.SubItems.Add(V.activation.ToString());
                listNV.Add(lvi);
            }
            return listNV;
        }
    }
}
