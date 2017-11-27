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
    public partial class SinhVienC2 : Form
    {
        public SinhVienC2()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monhocMenu_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.ShowDialog();
        }

        private void diemMenu_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem();
            diem.ShowDialog();
        }

        private void thongkeMenu_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
        }
    }
}
