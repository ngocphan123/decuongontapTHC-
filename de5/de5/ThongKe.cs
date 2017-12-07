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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dslich.LichDangKy' table. You can move, or remove it, as needed.
            this.LichDangKyTableAdapter.Fill(this.dslich.LichDangKy,2016);
            this.reportViewer1.RefreshReport();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.LichDangKyTableAdapter.Fill(this.dslich.LichDangKy, int.Parse(txtnam.Text.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
