using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h = int.Parse(txtchieucao.Text);
            string s = "";
            int n= h/2+1;
            int k = 1;
            for (int i = 1; i <= h; i++)
            {
                //2i-1 dấu * và n-1 dấu cách
                int dem = 1;
                for (int j = 1; j <= h; j++)
                {
                    if (j <= n - k)
                    {
                        s += " ";
                    }
                    else if (dem <= 2 * k - 1)
                    {
                        if(dem>1 && dem<2*k-1) 
                        {
                            s += " ";
                        }
                        else
                        {
                            s += "*";
                        }
                        
                        dem++;
                    }
                }
                if (i < n)
                {
                    k++;
                }
                else if(i==n)
                {
                    k = h%n;
                }
                else
                {
                    k--;
                }
                s += "\n";
            }
            lbht.Text = s;
        }
    }
}
