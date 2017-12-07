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
    public partial class PhongMay : Form
    {
        public PhongMay()
        {
            InitializeComponent();
        }
        private SqlConnection conn = connectsql.Getconnect();

        private void PhongMay_Load(object sender, EventArgs e)
        {
            cmbloaiphong.SelectedValue = 0;
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;

            getcmbloaiphong();
            getdata();          
        }
        public void getdata()
        {
            string sql = "SELECT * FROM PhongMay";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgphongmay.DataSource = dt;
        }
        public void getcmbloaiphong()
        {
            string sql = "SELECT * FROM LoaiPhong";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"Loại phòng");
            cmbloaiphong.DataSource = ds.Tables["Loại phòng"];
            cmbloaiphong.DisplayMember = "TenLoaiPhong";
            cmbloaiphong.ValueMember = "MaLoaiP";
        }

        private void dgphongmay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtmaphong.Text = dgphongmay.Rows[row].Cells["MaPM"].Value.ToString();
                txttenphong.Text = dgphongmay.Rows[row].Cells["TenPM"].Value.ToString();
                numsomay.Value = decimal.Parse(dgphongmay.Rows[row].Cells["Soluongmay"].Value.ToString());
                txtdiadiem.Text = dgphongmay.Rows[row].Cells["DiaDiem"].Value.ToString();
                cmbtinhtrang.Text = dgphongmay.Rows[row].Cells["TinhTrang"].Value.ToString();
                cmbloaiphong.SelectedValue = dgphongmay.Rows[row].Cells["MaLoaiP"].Value.ToString();

                btnsua.Enabled = true;
                btnthem.Enabled = false;
                btnxoa.Enabled = true;
                txtmaphong.Enabled = false;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO PhongMay(MaPM, TenPM, Soluongmay, DiaDiem, TinhTrang, MaLoaiP ) VALUES (N'" + txtmaphong.Text.ToString() + "', N'" + txttenphong.Text + "', " + numsomay.Value + ", N'" + txtdiadiem.Text + "', N'" + cmbtinhtrang.Text.ToString() + "', '" + cmbloaiphong.SelectedValue.ToString() + "')";
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.ExecuteNonQuery();
            conn.Close();
            getdata();
            cleartext();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            cleartext();
        }
        public void cleartext()
        {
            txtmaphong.Text = "";
            txttenphong.Text = "";
            numsomay.Value = 0;
            txtdiadiem.Text = "";
            cmbtinhtrang.SelectedIndex = 0;
            cmbloaiphong.SelectedIndex = 0;

            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE PhongMay SET TenPM = N'" + txttenphong.Text + "', Soluongmay= " + numsomay.Value + ", DiaDiem= N'" + txtdiadiem.Text + "', TinhTrang= N'" + cmbtinhtrang.Text + "', MaLoaiP= '" + cmbloaiphong.SelectedValue.ToString() + "' WHERE MaPM = '" + txtmaphong.Text + "'";
                SqlCommand cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
                //conn.Close();
                getdata();
                cleartext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn thực sự muốn xóa?", "cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "Delete FROM PhongMay WHERE MaPM ='" + txtmaphong.Text + "'";
                SqlCommand cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
                getdata();
                cleartext();
                MessageBox.Show("Xóa thành công");
            }
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from PhongMay WHERE MaLoaiP IN(Select MaLoaiP From LoaiPhong WHERE TenLoaiPhong LIKE N'%" + txttimkiem.Text + "%') OR MaLoaiP LIKE N'%" + txttimkiem.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgphongmay.DataSource = dt;
        }
    }
}
