using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlicafe
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbCafe.Text != "")
            {
                DataProvider d = new DataProvider();
                string name = cbCafe.Text;
                string num = numericUpDown1.Value.ToString();
                textBox1.Text = d.them(name, num, lsvBill).ToString();

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (lsvBill.Items.Count != 0)
                if (MessageBox.Show("Xác nhận đơn hàng. \n Tổng đơn: " + textBox1.Text, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Đã lưu đơn hàng");
                    lsvBill.Items.Clear();
                    numericUpDown1.Value = 1;
                    cbCafe.Text = "";
                    textBox1.Text = "";
                }
        }

        private void cbCafe_TextChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
        }


    }
}
