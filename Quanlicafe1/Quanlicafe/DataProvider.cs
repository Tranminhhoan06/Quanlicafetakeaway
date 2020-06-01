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
    }
}
