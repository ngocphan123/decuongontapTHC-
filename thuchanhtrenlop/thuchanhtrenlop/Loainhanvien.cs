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
    public partial class Loainhanvien : Form
    {
        public Loainhanvien()
        {
            InitializeComponent();
        }

        private void Loainhanvien_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdata()
        {
            //Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //Khởi tạo truy vấn
            string query = "SELECT * FROM LoaiNhanVien ORDER BY TenLoaiNV ASC";
            //thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //Khởi tạo dataset
            DataSet ds = new DataSet();
            //Đổ dữ liệu lên data set qua phương thức fill
            da.Fill(ds, "Loại nhân viên");
            //Hiển thị dữ liệu lên datagridview
            dgvloainv.DataSource = ds.Tables["Loại nhân viên"];
        }
    }
}
