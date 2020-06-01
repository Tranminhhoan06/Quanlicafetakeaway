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
            //int total = 0;
            //for (int i = 0; i < lsvBill.Items.Count; i++)
            //    total = total + int.Parse(lsvBill.Items[i].SubItems[2].Text);
            //textBox1.Text = total.ToString();
        }

    }
}
