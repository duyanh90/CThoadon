using System.Data;
using System.Data.SqlClient;

namespace CThoadon
{
    public class database
    {
        public static string cs = @"Data Source=LAPTOP-N1U01T4S\MSSQLSERVER01;Initial Catalog=QLBanHang;Integrated Security=True";

        public static DataTable GetData(string sql)
        {
            SqlConnection c = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter(sql, c);

            DataTable t = new DataTable();
            da.Fill(t);

            c.Close();
            return t;
        }

        public static DataTable GetData(string sql, SqlParameter p)
        {
            SqlConnection c = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter(sql, c);

            if (p != null)
                da.SelectCommand.Parameters.Add(p);

            DataTable t = new DataTable();
            da.Fill(t);

            c.Close();
            return t;
        }
    }
}
