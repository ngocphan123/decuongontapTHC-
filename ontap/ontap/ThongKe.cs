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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongkediem.Diem' table. You can move, or remove it, as needed.
            this.DiemTableAdapter.Fill(this.thongkediem.Diem, "2017");
            this.reportViewer1.RefreshReport();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.DiemTableAdapter.Fill(this.thongkediem.Diem, numnamhoc.Value.ToString());
            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
