using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanhtrenlop
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtn.Text);
                string s = "";

                /* for (int i = 1; i <= n; i++)
                 {
                 * //Hàng i có i dấu * và 1 dấu \n
                     for (int j = 1; j <= i; j++)
                     {
                         s += "*";
                     }
                     s += "\n";
                 }
                 lbketqua.Text = s;
                 */
              /*  for (int i = 1; i <= n; i++)
                {
               * //Hàng i có n+1-i dấu * và 1 dấu \n
                    for (int j = 1; j <= (n+1-i); j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }
                lbketqua.Text = s;
                */
               /* for (int i = 1; i <= n; i++)
                {
                    //Hàng i có n-i dấu cách, i dấu * và 1 dấu \n
                    for (int j = 1; j <= (n - i); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }
                lbketqua.Text = s;
                */
                /*for (int i = 1; i <= n; i++)
                {
                    //Hàng i có i-1 dấu cách, n+1-i dấu * và 1 dấu \n
                    for (int j = 1; j <= (i-1); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= (n+1-i); j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }
                lbketqua.Text = s;
                */
               /* for (int i = 1; i <= n; i++)
                {
                    //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (n - 1); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= (2*i-1); j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }
                lbketqua.Text = s;
                */
              /*  for (int i = 1; i < n; i++)
                {
                    //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (n - i); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= (2 * i - 1); j++)
                    {
                        //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2*i-1)
                        if (j == 1 || j == (2 * i - 1))
                            s += "*";
                        else
                            s += " ";
                    }
                    s += "\n";
                }
                //xét riêng hàng lấy
                for (int i = 1; i <=(2*n-1); i++)
                {
                    s += "*";
                }
                lbketqua.Text = s;
                */
                //tam giác trên
              /*  for(int i= 1; i<= 2*n-1;i++)
                {
                    s += "*";
                }
                s += "\n";
                for (int i = 2; i <= n; i++)
                {
                    //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (i-1); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= (2*n-2 * i + 1); j++)
                    {
                        //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2*i-1)
                        if (j == 1 || j == (2 * n - 2 * i + 1))
                            s += "*";
                        else
                            s += " ";
                    }
                    s += "\n";
                }
                lbketqua.Text = s;

                //tam giacs dưới
                for (int i = 2; i < n; i++)
                {
                    //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (n - i); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= (2 * i - 1); j++)
                    {
                        //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2*i-1)
                        if (j == 1 || j == (2 * i - 1))
                            s += "*";
                        else
                            s += " ";
                    }
                    s += "\n";
                }
                //xét riêng hàng lấy
                for (int i = 1; i <= (2 * n - 1); i++)
                {
                    s += "*";
                }
                lbketqua.Text = s;
                */
                for (int i = 1; i <= n; i++)
                {
                    //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (i-1); j++)
                    {
                        s += "0";
                    }
                    for (int j = 1; j <= (n + 1 - i); j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }
                for (int i = 2; i <= n; i++)
                {
                    //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= n-1; j++)
                    {
                        s += "0";
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }             
                lbketqua.Text = s;
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng");
            }
            
        }
    }
}
