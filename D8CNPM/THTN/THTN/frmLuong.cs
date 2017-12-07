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
    public partial class frmLuong : Form
    {
        public frmLuong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            getData();
            getCmb();
            cmbThang.SelectedIndex = 0;
            cmbNam.SelectedIndex = 0;
        }

        public void getData()
        {
            //B1: khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //B2: khởi tạo truy vấn
            string query = "select * from Luong Order By Nam DESC, Thang DESC";
            //B3: thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khởi tạo DataSet
            DataSet ds = new DataSet();
            //B5: Đổ dữ liệu lên DataSet thông qua phương thức Fill()
            da.Fill(ds, "Luong");
            //B6: Hiển thị dữ liệu lên DataGridView
            dgvLuong.DataSource = ds.Tables["Luong"];

        }

        public void getCmb()
        {
            //B1: khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //B2: khởi tạo truy vấn
            string query = "select * from NhanVien";
            //B3: thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khởi tạo DataSet
            DataSet ds = new DataSet();
            //B5: Đổ dữ liệu lên DataSet thông qua phương thức Fill()
            da.Fill(ds, "NhanVien");
            //B6: Hiển thị dữ liệu lên Combobox
            cmbNhanVien.DataSource = ds.Tables["NhanVien"];
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //select * from Luong where MaNV in (select MaNV from NhanVien where MaLoaiNV in (select MaLoaiNV from LoaiNhanVien where TenLoaiNV like '%' + N'Nhân' + '%')) Order by Nam DESC, Thang DESC
            //B1: khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //B2: khởi tạo truy vấn
            string query = "select * from Luong where MaNV in (select MaNV from NhanVien where MaLoaiNV in (select MaLoaiNV from LoaiNhanVien where TenLoaiNV like '%' + N'" + txtTimKiem.Text + "' + '%' or MaLoaiNV like '%' + N'" + txtTimKiem.Text + "' + '%')) Order by Nam DESC, Thang DESC";
            //B3: thực thi truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khởi tạo DataSet
            DataSet ds = new DataSet();
            //B5: Đổ dữ liệu lên DataSet thông qua phương thức Fill()
            da.Fill(ds, "Luong");
            //B6: Hiển thị dữ liệu lên DataGridView
            dgvLuong.DataSource = ds.Tables["Luong"];
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cmbNhanVien.SelectedValue = dgvLuong.Rows[row].Cells["MaNV"].Value.ToString();
                nbLuongChinh.Value = decimal.Parse(dgvLuong.Rows[row].Cells["LuongChinh"].Value.ToString());
                nbPhuCap.Value = decimal.Parse(dgvLuong.Rows[row].Cells["PhuCap"].Value.ToString());
                cmbThang.Text = dgvLuong.Rows[row].Cells["Thang"].Value.ToString();
                cmbNam.Text = dgvLuong.Rows[row].Cells["Nam"].Value.ToString();
                cmbNhanVien.Enabled = false;
                cmbThang.Enabled = false;
                cmbNam.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
        }


        public void ClearText()
        {
            nbLuongChinh.Value = 0;
            nbPhuCap.Value = 0;
            cmbNhanVien.Enabled = true;
            cmbThang.Enabled = true;
            cmbNam.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            //Bước 1: Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //Bước 2: Mở kết nối
            conn.Open();
            //Bước 3: Khởi tạo truy vấn
            //Insert into Luong (MaNV, LuongChinh,PhuCap,Thang,Nam)VALUES(N'NV001', 10000000, 200000, 4, 2017)
            string query = "Insert into Luong (MaNV, LuongChinh,PhuCap,Thang,Nam)VALUES(N'" + cmbNhanVien.SelectedValue.ToString() + "', " + nbLuongChinh.Value + ", " + nbPhuCap.Value + ", " + cmbThang.Text + ", " + cmbNam.Text + ")";
            SqlCommand cmd = new SqlCommand(query, conn);
            //Bước 4: Thực thi truy vấn
            cmd.ExecuteNonQuery();
            //Bước 5: Đóng kết nối
            conn.Close();
            //Bước 6: Load lại dữ liệu
            MessageBox.Show("Thêm mới thành công!");
            getData();
            ClearText();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            //Bước 1: Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //Bước 2: Mở kết nối
            conn.Open();
            //Bước 3: Khởi tạo truy vấn
            //Update Luong set LuongChinh = 2000000, PhuCap = 160000 where MaNV = N'NV003' and Thang = 4 and Nam = 2017
            string query = "Update Luong set LuongChinh = "+nbLuongChinh.Value+", PhuCap = "+nbPhuCap.Value+" where MaNV = N'"+cmbNhanVien.SelectedValue+"' and Thang = "+cmbThang.Text+" and Nam = "+cmbNam.Text+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            //Bước 4: Thực thi truy vấn
            cmd.ExecuteNonQuery();
            //Bước 5: Đóng kết nối
            conn.Close();
            //Bước 6: Load lại dữ liệu
            MessageBox.Show("Sửa thành công!");
            getData();
            ClearText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            //Bước 1: Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //Bước 2: Mở kết nối
            conn.Open();
            //Bước 3: Khởi tạo truy vấn
            //Delete from Luong where MaNV = N'NV003' and Thang = 4 and Nam = 2017
            string query = "Delete from Luong where MaNV = N'" + cmbNhanVien.SelectedValue + "' and Thang = " + cmbThang.Text + " and Nam = " + cmbNam.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            //Bước 4: Thực thi truy vấn
            cmd.ExecuteNonQuery();
            //Bước 5: Đóng kết nối
            conn.Close();
            //Bước 6: Load lại dữ liệu
            MessageBox.Show("Xóa thành công!");
            getData();
            ClearText();
        }
    }
}
