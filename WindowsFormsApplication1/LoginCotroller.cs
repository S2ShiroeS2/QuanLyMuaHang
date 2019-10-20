using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class LoginCotroller
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        private string LoginAccount = frm_Login.LoginAccount;
        private string LoginPassword = frm_Login.LoginPassword;
        public static string UserRole { get; private set; }
        public static int UserID { get; private set; }

        public bool CheckAccount(string account,string password)
        {
            UserRole = null;
            UserID = -1;
            var N = from VarNhanVien in data.NVs
                    where VarNhanVien.userAccount == account
                    select VarNhanVien;
            if (N.Count() < 1)
                return false;
            else
            {
                foreach (NV NhanVien in N)
                    if (NhanVien.userPassword == password && NhanVien.activation==true)
                    {
                        UserRole=NhanVien.role.ToString();
                        UserID = NhanVien.userID;
                        return true;
                    }
                return false;
            }    
        }

    }
}
