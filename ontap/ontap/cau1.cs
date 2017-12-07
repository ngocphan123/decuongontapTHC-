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
           /* for (int i = 0; i < h; i++)
            {
                if (i == 0 || i == h - 1)
                {
                    for (int j = 0; j < h; j++)
                    {
                        s += "* \t\t\t";                   
                    }
                }
                else if (i % 2 == 0)
                {
                    for (int j = 0; j < h; j++)
                    {
                        if (i == j)
                        {
                            s += "* \t\t\t";
                        }
                        else
                        {
                            s += "  \t\t\t";
                        }
                        
                    }
                }
                else
                {
                    for (int j = 0; j < h; j++)
                    {
                        if (j % 2 != 0)
                        {
                            s += "* \t\t\t";
                        }
                        else
                        {
                            s += "  \t\t\t";
                        }
                    }
                }
                s += "\n";
            }*/
            //Tam giác trên
            /*   for (int i = 1; i <= h; i++)
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
               }*/

            //Hình thoi của đề 2
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h; j++)
                {
                    if (j - 1 >= h / 2 - i + 1 && i + h / 2 >= j && i <= j + h / 2 && j - h / 2 <= h - i + 1)
                    {
                        s += " * ";
                            
                    }


                    else s += "   ";
                }
                s += "\n";
            }
            //
            label1.Text = s;
            
        }
        public int checkchan(int so)
        {
            if (so == 0 || so %2 == 0) return 1;
            return 0;
        }
    }
}
