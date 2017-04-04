using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AspirantHouseSoft.BOL;

namespace AspirantHouseSoft.DAL
{
    public class TestDataDAL:BaseDAL
    {
        public TestData TestDataIDataReader(IDataReader Reader)
        {
            TestData obj = new TestData();
            obj.Email = (Reader["Email"] is DBNull) ? string.Empty : (string)Reader["Email"];
            obj.Email = (Reader["Password"] is DBNull) ? string.Empty : (string)Reader["Password"];
            obj.MaQuyenHan = (Reader["MaQuyenHan"] is DBNull) ? int.MinValue : (int)Reader["MaQuyenHan"];
            return obj;
        }
        public int ThemTaiKhoan(TestData obj)
        {
            using (SqlConnection conn = getConnect())
            {
                conn.Open();
                SqlCommand myCommand = new SqlCommand("Insert into TaiKhoan values(N'" + obj.Email + "',N'" + obj.Password + "',N'" + obj.MaQuyenHan + "')",conn);
                myCommand.CommandType = CommandType.Text;
                myCommand.ExecuteNonQuery();
                conn.Close();
            }
            return 1;
        }
    }
}
