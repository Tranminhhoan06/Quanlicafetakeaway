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
        public int them(string name, string num,ListView a)
        {
            DataProvider d = new DataProvider();
            string[] arr = new string[3];
            ListViewItem item;
            int k = 0;
            if (int.Parse(num) != 0)
                {
                    for (int i = 0; i < a.Items.Count; i++)
                        if (name == a.Items[i].SubItems[0].Text)
                        {
                            if ((int.Parse(a.Items[i].SubItems[1].Text) + int.Parse(num)) > 50)
                            {
                                MessageBox.Show("Quá số lượng cho phép");
                                k = 1;
                            }
                            else
                            {
                                a.Items[i].SubItems[1].Text = (int.Parse(a.Items[i].SubItems[1].Text) + int.Parse(num)).ToString();
                                a.Items[i].SubItems[2].Text = (int.Parse(a.Items[i].SubItems[1].Text) * d.menu(name)).ToString();
                                k = 1;
                            }
                    }
                    if (k == 0)
                    {
                        arr[0] = name;
                        arr[1] = num;
                        arr[2] = (int.Parse(num) * d.menu(name)).ToString();
                        item = new ListViewItem(arr);
                        a.Items.Add(item);
                    }
                    for (int i = 0; i < a.Items.Count; i++)
                        if (int.Parse(a.Items[i].SubItems[1].Text) <= 0)
                        {
                            a.Items[i].Remove();
                            i--;
                        }
                }
            int tong = tongtien(a);
            return tong;
        }
        public int tongtien(ListView a)
        {
            int total = 0;
            for (int i = 0; i < a.Items.Count; i++)
                total = total + int.Parse(a.Items[i].SubItems[2].Text);
            return total;
        }

    }
}
