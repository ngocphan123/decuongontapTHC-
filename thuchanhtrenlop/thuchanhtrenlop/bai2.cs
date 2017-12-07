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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap frm = new dangnhap();
            frm.Show();
        }

        private void quảnLýLoạiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loainhanvien frm = new Loainhanvien();
            frm.ShowDialog();
        }

        private void quảnLýLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong frm = new Luong();
            frm.ShowDialog();
        }
    }
}
