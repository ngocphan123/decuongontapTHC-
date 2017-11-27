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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            using (var conn = connectsql.GetConnection())
            {

                SqlCommand sqlCmd = new SqlCommand("SELECT TenMH, DVHT FROM MONHOC", conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlAdap = new SqlDataAdapter(sqlCmd);
                sqlAdap.Fill(dt);
                dgmonhoc.DataSource = dt;
                conn.Close();
            }
        }
    }
}
