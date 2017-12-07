using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de5
{
    public partial class cau1 : Form
    {
        public cau1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 1; i <= 1000; i++)
            {
                if (checknguyen(i) == 1)
                {
                    s += " "+ i;
                }
            }
            lbso.Text = s;
        }
        public int checknguyen(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i != n && i != 1 && n % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
