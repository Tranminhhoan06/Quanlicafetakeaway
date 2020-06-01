using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlicafe
{
    public class DataProvider
    {
        public void login(string id, string pass)
        {
            fManager f = new fManager();
            if (id == "ADMIN" && pass == "1234")
                f.ShowDialog();
            else
                MessageBox.Show("Mật khẩu hoặc tài khoản không đúng.Mời nhập lại");
        }
        public int menu(string name)
        {
            int i = 0;
            switch (name)
            {
                case "Cà phê sữa":
                    i = 20000;
                    break;
                case "Cà phê đá":
                    i = 15000;
                    break;
                case "Sữa tươi":
                    i = 25000;
                    break;
                case "Trà chanh":
                    i = 10000;
                    break;
                case "Nước cam":
                    i = 15000;
                    break;
            }
            return i;
        }
    }
}
