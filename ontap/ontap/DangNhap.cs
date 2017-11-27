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

namespace ontap
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            using (var conn = connectsql.GetConnection())
            {

                SqlCommand sqlCmd = new SqlCommand("select * from NguoiDung where TaiKhoan='" + txtusername.Text + "' and MatKhau='" + txtpassword.Text + "'", conn);
                SqlDataAdapter sqlAdap = new SqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sqlAdap.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    SinhVienC2 dlg2 = new SinhVienC2();
                    dlg2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                    txtusername.Text = txtpassword.Text = "";
                    txtusername.Focus();
                }
                conn.Close();
            }
        }
    }
}
