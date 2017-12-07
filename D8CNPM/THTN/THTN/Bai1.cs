using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THTN
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text);
                string s = "";
                //Tam giac tren
                for (int i = 1; i <= 2 * n - 1; i++)
                {
                    s = s + "*";
                }
                s = s + "\n";
                for (int i = 2; i <= n; i++)
                {
                    //Hàng i có i-1 dấu ' ', 2*n-2*i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (i - 1); j++)
                    {
                        s = s + " ";
                    }
                    for (int j = 1; j <= (2*n-2*i+1); j++)
                    {
                        //Chỉ hiển thị dấu * ở 2 viền (vị trí 1 và 2*i-1)
                        if (j == 1 || j == (2 * n - 2 * i + 1))
                            s = s + "*";
                        else
                            s = s + " ";
                    }
                    s = s + "\n";
                }
                //Tam giac duoi
                for (int i = 2; i <= n-1; i++)
                {
                    //Hàng i có i-1 dấu ' ', 2*n-2*i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (n - i); j++)
                    {
                        s = s + " ";
                    }
                    for (int j = 1; j <= (2 * i - 1); j++)
                    {
                        //Chỉ hiển thị dấu * ở 2 viền (vị trí 1 và 2*i-1)
                        if (j == 1 || j == (2 * i - 1))
                            s = s + "*";
                        else
                            s = s + " ";
                    }
                    s = s + "\n";
                }
                //Xét riêng hàng đáy
                for (int i = 1; i <= (2 * n - 1); i++)
                {
                    s = s + "*";
                }

                lbKQ.Text = s;

            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không đúng!");
            }
        }
    }
}
