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
    public partial class LoaiPhong : Form
    {
        public LoaiPhong()
        {
            InitializeComponent();
        }
        private SqlConnection conn = connectsql.Getconnect();
        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdata()
        {
            string sql = "SELECT * FROM LoaiPhong ORDER BY TenLoaiPhong ASC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgloaiphong.DataSource = dt;
        }
    }
}
