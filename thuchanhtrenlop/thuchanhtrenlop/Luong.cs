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
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            getdata();
            getcmb();
            cmbthang.SelectedIndex = 0;
            cmbnam.SelectedIndex = 0;
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        public void getdata()
        {
            //Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //Khởi tạo truy vấn
            string query = "SELECT * FROM Luong ORDER BY Nam, Thang";
            //thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //Khởi tạo dataset
            DataSet ds = new DataSet();
            //Đổ dữ liệu lên data set qua phương thức fill
            da.Fill(ds, "Lương");
            //Hiển thị dữ liệu lên datagridview
            dgluong.DataSource = ds.Tables["Lương"];
        }

        public void getcmb()
        {
            //Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //Khởi tạo truy vấn
            string query = "SELECT * FROM NhanVien";
            //thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //Khởi tạo dataset
            DataSet ds = new DataSet();
            //Đổ dữ liệu lên data set qua phương thức fill
            da.Fill(ds, "Nhân viên");
            //Hiển thị dữ liệu lên combobox
            cmbmanv.DataSource = ds.Tables["Nhân viên"];
            cmbmanv.DisplayMember = "TenNV";
            cmbmanv.ValueMember = "MaNV";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //SELECT * FROM Luong WHERE MaNV IN (Select MaNV FRom NhanVien WHERE MaLoaiNV IN (SELECT MaLoaiNV FROM LoaiNhanVien WHERE TenLoaiNV Like '%'+N'Giám'+'%')) ORDER BY Nam, Thang
            //Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //Khởi tạo truy vấn
            string query = "SELECT * FROM Luong WHERE MaNV IN (Select MaNV FRom NhanVien WHERE MaLoaiNV IN (SELECT MaLoaiNV FROM LoaiNhanVien WHERE TenLoaiNV Like '%'+N'" + txttimkiem.Text + "'+'%'  OR MaLoaiNV Like '%'+N'" + txttimkiem.Text + "'+'%' )) ORDER BY Nam, Thang";
            //thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //Khởi tạo dataset
            DataSet ds = new DataSet();
            //Đổ dữ liệu lên data set qua phương thức fill
            da.Fill(ds, "Lương");
            //Hiển thị dữ liệu lên datagridview
            dgluong.DataSource = ds.Tables["Lương"];
        }

        private void dgluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cmbmanv.SelectedValue = dgluong.Rows[row].Cells["MaNV"].Value.ToString();
                numluong.Value = decimal.Parse(dgluong.Rows[row].Cells["LuongChinh"].Value.ToString());
                numphucap.Value = decimal.Parse(dgluong.Rows[row].Cells["PhuCap"].Value.ToString());
                cmbthang.Text = dgluong.Rows[row].Cells["Thang"].Value.ToString();
                cmbnam.Text = dgluong.Rows[row].Cells["Nam"].Value.ToString();
                cmbmanv.Enabled = false;
                cmbnam.Enabled = false;
                cmbthang.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cmbmanv.SelectedValue = 0;
            numluong.Value = 0;
            numphucap.Value = 0;
            cmbthang.SelectedIndex = 0;
            cmbnam.SelectedIndex = 0;
            cmbmanv.Enabled = false;
            cmbnam.Enabled = false;
            cmbthang.Enabled = false;
            btnthem.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //b1: Khởi tạo kết nối
            //Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //b2: Mở kết nối
            conn.Open();
            //b3: Thực thi truy vấn
            string sql = "INSERT INTO Luong(MaNV,LuongChinh,PhuCap ,Thang,Nam)VALUES(N'" + cmbmanv.SelectedValue.ToString() + "'," + numluong.Value + "," + numphucap.Value + "," + cmbthang.SelectedValue.ToString() + "," + cmbnam.SelectedValue.ToString() + ")";
            SqlCommand cmd = new SqlCommand(sql, conn);
            /*
             Có 3 phương thức thực thi:
             + Excute NonQuery : không trả về giá trị:update, insert
             + EXcute scalar: trả về  1 giá  trị
             + excute reader: trả về nhiều giá trị
             */
            cmd.ExecuteNonQuery();
            conn.Close();
            getdata();
            getcmb();
        }

        private void dgluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }
    }
}
