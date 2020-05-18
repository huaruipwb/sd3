using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
   public class DBHelper
    {
        public static string constr = "server=.;database=jsj;uid=sa;pwd=123";
        public static int MyExecuteNonQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                int count = cmd.ExecuteNonQuery();

                return count;
            }
        }
        public static SqlDataReader MyExecuteReader(string sql)
        {

            SqlConnection con = new SqlConnection(constr);

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            return dr;

        }
    }
}
