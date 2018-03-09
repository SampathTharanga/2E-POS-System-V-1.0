using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sun_Electrical
{
    class user
    {
        public void userRegister(string _un, string _pass, string _secQu, string _ans)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tblUsers VALUES('" + _un + "','" + _pass + "','" + _secQu + "','" + _ans + "')", ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader userLogin(string _userName, string _password)
        {
            SqlCommand com = new SqlCommand("SELECT * FROM tblUsers WHERE username='" + _userName + "' AND password='" + _password + "'", ConnectionDB.connection());
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
    }
}
