using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontap
{
    public partial class cau1 : Form
    {
        public cau1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            int h = Int32.Parse(txtchieucao.Text);
            string s = "";
            //Tam giác trên
            for (int i = 1; i <= h; i++)
            {
                //Hàng i có i-1 dấu cách, 2n-2i+1 dấu * và 1 dấu \n
                for (int j = 1; j <= (i - 1); j++)
                {
                    s += " ";
                }
                for (int j = 1; j <= (2*h + 1 - 2*i); j++)
                {
                    //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2 * h + 1 - 2 * i)
                    if (i==1 || j == 1 || j == (2 * h + 1 - 2 * i))
                        s += "*";
                    else
                        s += " ";
                }
                s += "\n";
            }
            //Tam giác dưới
            for (int i = 2; i <= h; i++)
            {
                //Hàng i có i-1 dấu cách, 2n-2i+1 dấu * và 1 dấu \n
                for (int j = 1; j <= (h-i); j++)
                {
                    s += " ";
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2 * i - 1)
                    if (i == h || j == 1 || j == (2 * i - 1))
                        s += "*";
                    else
                        s += " ";
                }
                s += "\n";
            }
            label1.Text = s;
        }
    }
}
