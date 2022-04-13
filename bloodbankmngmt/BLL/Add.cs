using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloodbankmngmt.BLL
{
    public class Add
    {
        public int CreateUser(string Name,string Father_Name,string Mother_Name,string Date_of_Birth,double Mobile_No,string Gender,string Email,string Blood_group,string City,string Address)
        {
                string sql = "insert into tbldonor values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Name),
                 new SqlParameter("@b",Father_Name),
                 new SqlParameter("@c",Mother_Name),
                 new SqlParameter("@d",Date_of_Birth),
                 new SqlParameter("@e",Mobile_No),
                 new SqlParameter("f",Gender),
                 new SqlParameter("@g",Email),
                 new SqlParameter("h",Blood_group),
                 new SqlParameter("@i",City),
                 new SqlParameter("@j",Address),
               };
            return Connect.IUD(sql, param);
        }
        public DataTable GetAllUser()
        {
            string sql = "select *from tbldonor";
            return Connect.GetTable(sql,null);

        }
        public DataTable GetById(int New_Donor_Id)
        {
            string sql = "select * from tbldonor where New_Donor_Id=@a";
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@a",New_Donor_Id),
            };
            return Connect.GetTable(sql, param);
            
        }
        public int UpdateUser(string Name,string Father_Name,string Mother_Name,string Date_of_Birth,double Mobile_No,string Gender,string Email,string Blood_group,string City,string Address,int New_Donor_Id)
        {
            string sql = "update tbldonor set Name=@a,Father_Name=@b,Mother_Name=@c,Date_of_Birth=@d,Mobile_No=@e,Gender=@f,Email=@g,Blood_group=@h,City=@i,Address=@j where New_Donor_Id=@k";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Name),
                new SqlParameter("@b",Father_Name),
                new SqlParameter("@c",Mother_Name),
                new SqlParameter("@d",Date_of_Birth),
                new SqlParameter("@e",Mobile_No),
                new SqlParameter("@f",Gender),
                new SqlParameter("@g",Email),
                new SqlParameter("@h",Blood_group),
                new SqlParameter("@i",City),
                new SqlParameter("@j",Address),
                new SqlParameter("@k",New_Donor_Id),
            };
            return Connect.IUD(sql, param);
        }
        public int DeleteUser(int New_Donor_Id)
        {
            string sql = "delete from tbldonor where New_Donor_Id=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",New_Donor_Id),
            };
            return Connect.IUD(sql, param);
        }
        public DataTable SearchByAddress(string Address)
        {
            string sql = "select * from tbldonor where Address=@a";
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@a",Address),
            };
            return Connect.GetTable(sql, param);
           
        }
        public DataTable SearchbyBlood( string Blood_group)
        {
            string sql = "select * from tbldonor where Blood_group=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Blood_group),
            };
           return Connect.GetTable(sql, param);
        }
    }
}
