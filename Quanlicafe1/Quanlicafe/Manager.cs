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
            DataProvider d = new DataProvider();
            //d.menu(cbCafe.Text);
            string[] arr = new string[3];
            ListViewItem item;
            arr[0] = cbCafe.Text;
            arr[1] = numericUpDown1.Value.ToString();
            arr[2] = (numericUpDown1.Value * d.menu(cbCafe.Text)).ToString();
            item = new ListViewItem(arr);
            lsvBill.Items.Add(item);
        }

    }
}
