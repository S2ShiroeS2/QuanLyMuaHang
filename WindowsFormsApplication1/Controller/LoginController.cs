﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1
{
    class LoginController
    {
        private DataClasses1DataContext data = new DataClasses1DataContext();
        private NhanVienController NVC = new NhanVienController();
        public static string UserRole { get; private set; }
        public static int UserID { get; private set; }
        public static string Name { get; private set; }
        public static string Account { get; private set; }

        public bool CheckAccount(string account, string password)//Kiểm tra account có tồn tại trong database kèm theo pass của account đó
        {
            data = new DataClasses1DataContext();
            UserRole = null;
            UserID = -1;
            Name = "";
            Account = "";
            var N = from VarNhanVien in data.NVs
                    where VarNhanVien.userAccount == account
                    select VarNhanVien;
            if (N.Count() < 1)
                return false;
            else
            {
                foreach (NV NhanVien in N)
                    if (NhanVien.userPassword == password && NhanVien.activation == true)
                    {
                        UserRole = NhanVien.role.ToString();
                        UserID = NhanVien.userID;
                        Name = NhanVien.userName;
                        Account = NhanVien.userAccount;
                        return true;
                    }
                return false;
            }
        }

        public void ChangePassword(int id, string password)
        {
            NVC.ChangePassword(id, password);
        }

        public bool CheckPassword(int id, string password)
        {
            return NVC.Checkpassword(id, password);
        }

        public void LogOut()
        {
            UserID = -1;
        }
    }
}
