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
    public partial class Form1 : Form
    {
        public Form1()
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
            for (int i = 0; i < h; i++)
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
            }
            label1.Text = s;
        }
    }
}
