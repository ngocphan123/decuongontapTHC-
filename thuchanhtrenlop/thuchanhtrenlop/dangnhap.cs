using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Để kết nối với cơ sở dữ liệu: thư viện 

namespace thuchanhtrenlop
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //SELECT COUNT(*) FROM Nguoidung WHERE TaiKhoan = 'admin' AND MatKhau='123'
            //b1: Khởi tạo kết nối
            //Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True
            SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=NhanVien;Integrated Security=True");
            //b2: Mở kết nối
            conn.Open();
            //b3: Thực thi truy vấn
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Nguoidung WHERE TaiKhoan = '" + txttendangnhap.Text + "' AND MatKhau='" + txtmatkhau.Text + "'", conn);
            /*
             Có 3 phương thức thực thi:
             + Excute NonQuery : không trả về giá trị:update, insert
             + EXcute scalar: trả về  1 giá  trị
             + excute reader: trả về nhiều giá trị
             */
            int soluong = (int)cmd.ExecuteScalar();         
            conn.Close();
            //b4: Đóng kết nối
            //B5:Kiểm tra
            if (soluong == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                bai2 frm = new bai2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
