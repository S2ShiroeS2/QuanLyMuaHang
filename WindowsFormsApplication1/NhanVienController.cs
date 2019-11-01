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
        private DataClasses1DataContext data = new DataClasses1DataContext();

        private List<ListViewItem> listNV = new List<ListViewItem>();

        // Thêm thông tin 1 nv vào listviewitem
        public ListViewItem AddLviItem(NV V)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = V.userID.ToString();
            lvi.SubItems.Add(V.userName);
            lvi.SubItems.Add(V.userAccount);
            lvi.SubItems.Add(V.userEmail);
            lvi.SubItems.Add(V.userPhone);
            lvi.SubItems.Add(V.role ? "Admin" : "Nhân viên");
            lvi.SubItems.Add(V.activation ? "Active" : "Deactive");
            return lvi;
        }

        //Lay danh sach tat ca nhan vien
        public List<ListViewItem> NhanVienList()
        {
            listNV.Clear();
            data = new DataClasses1DataContext();
            var NhanVienVar = from V in data.NVs
                              select V;
            foreach (NV V in NhanVienVar)
                listNV.Add(AddLviItem(V));
            return listNV;
        }

        public List<ListViewItem> NVListSearch(string SearchNameData)
        {
            listNV.Clear();

            var VendorVar = from V in data.NVs
                            where (V.userName.Contains(SearchNameData))
                            select V;
            foreach (var V in VendorVar)
                listNV.Add(AddLviItem(V));
            return listNV;

        }

        public int GetMaxNVID()
        {
            var list = from NV_id in data.NVs
                       select NV_id.userID;
            return list.Max();
        }

        public NV AddNVInV(ListViewItem lvi_nv, string password)
        {
            NV V = new NV();

            V.userID = Int32.Parse(lvi_nv.Text);
            V.userName = lvi_nv.SubItems[1].Text;
            V.userAccount = lvi_nv.SubItems[2].Text;
            V.userPassword = password;
            V.userEmail = lvi_nv.SubItems[3].Text;
            V.userPhone = lvi_nv.SubItems[4].Text;
            if (lvi_nv.SubItems[5].Text == "Nhân viên")
                V.role = false;
            else
                V.role = true;
            if (lvi_nv.SubItems[6].Text == "Active")
                V.activation = true;
            else
                V.activation = false;
            return V;
        }

        public void NVAddNew(ListViewItem lvi_nv, string password)
        {
            //Insert Ncc trong databse voi password 
            data.NVs.InsertOnSubmit(AddNVInV(lvi_nv, password));
            data.SubmitChanges();
        }

        public void UpdateNV(ListViewItem lvi_nv) //Update NhanVien trong database(Khong doi password duoc)
        {
            var NhanVienList = (from a in data.NVs
                                where a.userID.ToString() == lvi_nv.Text
                                select a);
            foreach (NV V in NhanVienList)
            {
                V.userName = lvi_nv.SubItems[1].Text;
                V.userAccount = lvi_nv.SubItems[2].Text;
                V.userEmail = lvi_nv.SubItems[3].Text;
                V.userPhone = lvi_nv.SubItems[4].Text;
                if (lvi_nv.SubItems[5].Text == "Nhân viên")
                    V.role = false;
                else
                    V.role = true;
                if (lvi_nv.SubItems[6].Text == "Active")
                    V.activation = true;
                else
                    V.activation = false;
            }
            data.SubmitChanges();
        }

        //Kiem tra account co ton tai trong database
        public bool CheckAccountExsits(string account)
        {
            var listNV = from nhanvien in data.NVs
                         where nhanvien.userAccount == account
                         select nhanvien;
            if (listNV.Count() > 1)
                return false;
            return true;
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

        public void ChangePassword(int id, string password)//Thay đổi password
        {
            var varnv = from v in data.NVs
                        where v.userID == id
                        select v;
            foreach (NV nv in varnv)
            {
                nv.userPassword = password;
            }
            data.SubmitChanges();
        }

        public bool Checkpassword(int id, string password)
        {
            var varnv = from v in data.NVs
                        where v.userID == id
                        select v;
            foreach (NV nv in varnv)
            {
                if (nv.userPassword == password)
                    return true;
            }
            return false;
        }

    }
}
