using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class TTCNController
    {
        private DataClasses1DataContext data = new DataClasses1DataContext();
        private NhanVienController NVC = new NhanVienController();
        private LoginController LC = new LoginController();
        public List<ListViewItem> UserInformation { get; private set; } = new List<ListViewItem>();

        public List<ListViewItem> TakeUserInformation()
        {
            return UserInformation = NVC.GetNV(1);//Thay 1 = Lc.userID khi hoàn thành
        }
    }
        
}
