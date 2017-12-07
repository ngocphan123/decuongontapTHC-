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
    public partial class Diem : Form
    {
        public Diem()
        {
            InitializeComponent();
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            cmbsv();
            loadmonhoc();
            getdata();
            cmnam.SelectedIndex = 0;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }
        public void getdata()
        {
            using( var conn = connectsql.GetConnection())
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM Diem",conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlA = new SqlDataAdapter(sql);
                sqlA.Fill(dt);
                dgdiem.DataSource = dt;
            }
        }
        public void cmbsv()
        {
            using(var conn = connectsql.GetConnection())
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM SinhVien", conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sqld = new SqlDataAdapter(sql);
                sqld.Fill(ds,"Sinh viên");

                cmmasv.DataSource = ds.Tables["Sinh viên"];
                cmmasv.DisplayMember = "TenSV";
                cmmasv.ValueMember = "MaSV";

                
            }
        }
        public void loadmonhoc()
        {
            using (var conn = connectsql.GetConnection())
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM MonHoc", conn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(ds, "Môn học");
                cmbmonhoc.DataSource = ds.Tables["Môn học"];
                cmbmonhoc.DisplayMember = "TenMH";
                cmbmonhoc.ValueMember = "MaMH";
                
            }
        }
        private void dgdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgdiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cmmasv.SelectedValue = dgdiem.Rows[row].Cells["MaSV"].Value.ToString();
                cmbmonhoc.SelectedValue = dgdiem.Rows[row].Cells["MaMH"].Value.ToString();
                numdiem.Value = decimal.Parse(dgdiem.Rows[row].Cells["DiemTK"].Value.ToString());
                cmnam.Text = dgdiem.Rows[row].Cells["NamHoc"].Value.ToString();
                numky.Value = decimal.Parse(dgdiem.Rows[row].Cells["Ky"].Value.ToString());

                cmmasv.Enabled = false;
                cmbmonhoc.Enabled = false;
                cmnam.Enabled = false;
                numky.Enabled = false;

                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = false;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            using (var conn = connectsql.GetConnection())
            {
                string sql = "INSERT INTO Diem (MaSV,MaMH,DiemTK,NamHoc,Ky) VALUES (" + cmmasv.SelectedValue.ToString() + ", " + cmbmonhoc.SelectedValue.ToString() + ", " + numdiem.Value.ToString() + ", " + cmnam.Text.ToString() + ", " + numky.Value.ToString() + ")";
                SqlCommand sqc = new SqlCommand(sql, conn);
                sqc.ExecuteNonQuery();
                conn.Close();
                cmbsv();
                loadmonhoc();
                getdata();
                cmnam.SelectedIndex = 0;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Enabled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (var conn = connectsql.GetConnection())
            {
                string sql = "UPDATE Diem SET DiemTK= " + numdiem.Value.ToString() + " WHERE  MaSV = " + cmmasv.SelectedValue.ToString() + " and MaMH = " + cmbmonhoc.SelectedValue.ToString() + " and NamHoc= " + cmnam.Text.ToString() + " and Ky=" + numky.Value.ToString() + "";
                SqlCommand sqlc = new SqlCommand(sql, conn);
                sqlc.ExecuteNonQuery();
                conn.Close();
                cmbsv();
                loadmonhoc();
                getdata();
                cmnam.SelectedIndex = 0;
                numky.Value = 0;
                numdiem.Value = 0;

                cmmasv.Enabled = true;
                cmbmonhoc.Enabled = true;
                cmnam.Enabled = true;
                numky.Enabled = true;

                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Enabled = true;
                MessageBox.Show("Sửa thành công");
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartext();
        }
        public void cleartext()
        {
            cmnam.SelectedIndex = 0;
            cmmasv.SelectedIndex = 0;
            cmbmonhoc.SelectedIndex = 0;
            numky.Value = 0;
            numdiem.Value = 0;


            cmmasv.Enabled = true;
            cmbmonhoc.Enabled = true;
            cmnam.Enabled = true;
            numky.Enabled = true;

            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            using(var conn = connectsql.GetConnection())
            {
                string sql = "DELETE FROM Diem WHERE  MaSV = " + cmmasv.SelectedValue.ToString() + " and MaMH = " + cmbmonhoc.SelectedValue.ToString() + " and NamHoc= " + cmnam.Text.ToString() + " and Ky=" + numky.Value.ToString() + "";
                SqlCommand sqlc = new SqlCommand(sql, conn);
                sqlc.ExecuteNonQuery();
                conn.Close();
                cmbsv();
                loadmonhoc();
                getdata();
                cleartext();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = connectsql.GetConnection())
            {
                string sql = "SELECT * FROM Diem WHERE MaSV IN (SELECT MaSV FROM SinhVien WHERE MaLop IN (SELECT MaLop FROM Lop WHERE TenLop LiKE N'%" + txttimkiem.Text + "%'))";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgdiem.DataSource = dt;
            }
        }
    }
}
