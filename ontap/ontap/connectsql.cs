using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ontap
{
    class connectsql
    {
        private const string CONNECTION_STRING = @"server=DESKTOP-VBL1SRR\SQLEXPRESS;uid=sa;pwd=123456;database=QL_SV_01";
        private connectsql() { }

        public static SqlConnection GetConnection()
        {
            SqlConnection ret = new SqlConnection(CONNECTION_STRING);
            ret.Open();
            return ret;
        }
    }
}
