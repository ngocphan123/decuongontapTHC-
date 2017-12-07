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

namespace de5
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private SqlConnection conn = connectsql.Getconnect();

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NguoiDung WHERE TaiKhoan='" + txttendn.Text.ToString() + "' AND MatKhau='" + txtmk.Text.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Hide();
                cau2 c2 = new cau2();
                c2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                txttendn.Text = "";
                txtmk.Text = "";
                txttendn.Focus();
            }
        }
    }
}
