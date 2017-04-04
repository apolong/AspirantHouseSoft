using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AspirantHouseSoft.DAL
{
    public class BaseDAL
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=192.168.1.29;Initial Catalog=AspirantHouseSoft;Persist Security Info=True;User ID=sa; Password=bonaventura");
        }
        public DataTable GetDataTable(string sql)
        {
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
