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
    public partial class frmLoaiNhanVien : Form
    {
        public frmLoaiNhanVien()
        {
            InitializeComponent();
        }

        private void frmLoaiNhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            //B1: khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //B2: khởi tạo truy vấn
            string query = "select * from LoaiNhanVien Order by TenLoaiNV ASC";
            //B3: thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khởi tạo DataSet
            DataSet ds = new DataSet();
            //B5: Đổ dữ liệu lên DataSet thông qua phương thức Fill()
            da.Fill(ds, "LoaiNhanVien");
            //B6: Hiển thị dữ liệu lên DataGridView
            dgvLoaiNhanVien.DataSource = ds.Tables["LoaiNhanVien"];

        }
    }
}
