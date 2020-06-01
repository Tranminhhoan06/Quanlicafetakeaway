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
        int total = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbCafe.Text != "")
            {
                DataProvider d = new DataProvider();
                string name = cbCafe.Text;
                string num = numericUpDown1.Value.ToString();
                d.them(name, num, lsvBill);
                //int k = 0;
                //if (int.Parse(num) != 0)
                //{
                //    for (int i = 0; i < lsvBill.Items.Count; i++)
                //        if (name == lsvBill.Items[i].SubItems[0].Text)
                //        {
                //            lsvBill.Items[i].SubItems[1].Text = (int.Parse(lsvBill.Items[i].SubItems[1].Text) + int.Parse(num)).ToString();
                //            arr[2] = (int.Parse(num) * d.menu(name)).ToString();
                //            k = 1;
                //        }
                //    if (k == 0)
                //        lsvBill.Items.Add(d.them(name, num));
                //}
                //textBox1.Text = d.tongtien(lsvBill).ToString();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //int total = 0;
            //for (int i = 0; i < lsvBill.Items.Count; i++)
            //    total = total + int.Parse(lsvBill.Items[i].SubItems[2].Text);
            //textBox1.Text = total.ToString();
        }

    }
}
