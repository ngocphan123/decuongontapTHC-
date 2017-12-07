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
    public partial class DangNhap : Form
    {
        public DangNhap()
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //select count(*) from Nguoidung where TaiKhoan = 'admin' and MatKhau = 'admin1'
            //B1 : khởi tạo kết nối
            //Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True
            SqlConnection conn = new SqlConnection(@"Data Source=VIETFORUM\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //B2: Mở kết nối
            conn.Open();
            //B3: Tạo truy vấn
            SqlCommand cmd = new SqlCommand("select count(*) from Nguoidung where TaiKhoan = '" + txtTaiKhoan.Text + "' and MatKhau = '" + txtMatKhau.Text + "'", conn);
            //B4: Thực thi truy vấn
            int SoLuong = (int)cmd.ExecuteScalar();
            //B5: Đóng kết nối
            conn.Close();
            //B6: Kiểm tra số lượng
            if (SoLuong == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                HeThong frm = new HeThong();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
