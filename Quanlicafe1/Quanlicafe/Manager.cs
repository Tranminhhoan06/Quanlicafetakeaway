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
                lsvBill.Items.Add(d.them(name, num));
            }
        }

    }
}
