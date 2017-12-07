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
    public partial class cau2 : Form
    {
        public cau2()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.ShowDialog();
        }

        private void phòngMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongMay pm = new PhongMay();
            pm.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
        }
    }
}
