using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlicafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string pass = txbPassword.Text;
            //string query = "SELECT * FROM dbo.TAIKHOAN WHERE UNAME = '" + username + "' and PASS = '" + pass + "'";
            //DataProvider provider = new DataProvider();
            //DataTable da = provider.Execute(query);
            //login.kiemtra(username, pass);
            DataProvider d = new DataProvider();
            d.login(username, pass);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txbUserName.Text = "ADMIN";
            txbPassword.Text = "1234";
        }

    }
}
