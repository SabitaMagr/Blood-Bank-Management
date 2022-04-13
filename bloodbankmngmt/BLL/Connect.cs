using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloodbankmngmt.BLL
{
    public static class Connect
    {
        public static string strcon = ConfigurationManager.ConnectionStrings["bloodbankmngmt.Properties.Settings.bloodbankConnectionString"].ConnectionString;
        public static SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection(strcon);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }
        public static int IUD(string sql, SqlParameter[] param)
        {
            using (SqlConnection con = Connect.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        public static DataTable GetTable(string sql,SqlParameter[]param)
        {
            using (SqlConnection con = CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
          
            }
        }

    }
}
