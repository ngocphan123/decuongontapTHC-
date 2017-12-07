using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Thư viện SqlDataProvider

namespace THTN
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            
        }

        public DataSet getData()
        {
            //B1: khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //B2: khởi tạo truy vấn
            string query = "select * from Luong Where Nam = " + nbNam.Value + "";
            //B3: thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khởi tạo DataSet
            DataSet ds = new DataSet();
            //B5: Đổ dữ liệu lên DataSet thông qua phương thức Fill()
            da.Fill(ds, "Luong");
            //B6: Hiển thị dữ liệu lên DataGridView
            //dgvLuong.DataSource = ds.Tables["Luong"];
            return ds;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportDataSource rpD = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", getData().Tables["Luong"]);
            this.reportViewer1.LocalReport.DataSources.Insert(0, rpD);

            this.reportViewer1.RefreshReport();
        }
    }
}
