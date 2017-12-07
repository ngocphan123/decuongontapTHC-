using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace thuchanhtrenlop
{
    public partial class Thongke2 : Form
    {
        public Thongke2()
        {
            InitializeComponent();
        }

        private void Thongke2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Insert(0, new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", getdata().Tables["DataTable1"]));
            this.reportViewer1.RefreshReport();
        }
        public DataSet getdata()
        {
            //Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //Khởi tạo truy vấn
            string query = "SELECT * FROM Luong WHERE Nam = "+mumthongke.Value+" ORDER BY Nam, Thang";
            //thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //Khởi tạo dataset
            DataSet ds = new DataSet();
            //Đổ dữ liệu lên data set qua phương thức fill
            da.Fill(ds, "DataTable1");
            return ds;
        }
    }
}
