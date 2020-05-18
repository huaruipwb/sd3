using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
   public class PC_info_DAL
    {
       public static List<PC_info> GetData(PC_info pf)
        {
            var swhere = "";

            if (pf.PC_id > 0)
            {
                swhere += string.Format(" and PC_id={0}", pf.PC_id);
            }
            string sql = string.Format(@"select * from PC_info where 1=1 {0}", swhere);

            SqlDataReader dr = DBHelper.MyExecuteReader(sql);

            List<PC_info> list = new List<PC_info>();

            while (dr.Read())
            {
                PC_info pc = new PC_info();
                if (dr["PC_id"] != DBNull.Value)
                    pc.PC_id = Convert.ToInt32(dr["PC_id"]);
                if (dr["PC_brand"] != DBNull.Value)
                    pc.PC_brand = dr["PC_brand"].ToString();
                if (dr["PC_type"] != DBNull.Value)
                    pc.PC_type = dr["PC_type"].ToString();
                if (dr["PC_model"] != DBNull.Value)
                    pc.PC_model = dr["PC_model"].ToString();
                if (dr["PC_size"] != DBNull.Value)
                    pc.PC_size = dr["PC_size"].ToString();
                if (dr["PC_cpu"] != DBNull.Value)
                    pc.PC_cpu = dr["PC_cpu"].ToString();
                if (dr["PC_ram"] != DBNull.Value)
                    pc.PC_ram = dr["PC_ram"].ToString();
                if (dr["PC_price"] != DBNull.Value)
                    pc.PC_price = Convert.ToInt32(dr["PC_price"]);
                list.Add(pc);
            }
            dr.Close();
            return list;
        }
        public static int Del(int id)
        {
            string sql = string.Format("delete PC_info where PC_id={0}", id);
            int count = DBHelper.MyExecuteNonQuery(sql);
            return count;
        }
    }
}
