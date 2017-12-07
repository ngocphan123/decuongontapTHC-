using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace de5
{
    class connectsql
    {
    public static SqlConnection Getconnect()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-VBL1SRR\SQLEXPRESS;Initial Catalog=PhongMay;Integrated Security=True");

            cn.Open();
            return cn;
        }
    }
}
