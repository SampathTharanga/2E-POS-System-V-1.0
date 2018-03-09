using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sun_Electrical
{
    class ConnectionDB
    {
        public static SqlConnection connection()
        {

            //tryF:\Enjoy my Lfie\My Kindom\Software Development\SUN ELECTRICAL\Sun Electrical System - RELEASE ONE\SETUP 02\Sun_Electrical\Sun_Electrical\ConnectionDB.cs
            //{
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //process.StartInfo.FileName = @"net start .\SQLEXPRESS";
            //process.Start();
            //string connectionString = @"Server = .\SQLEXPRESS; Database = sun_electrical; User Id = TeamDCFXC; Password = TeamDCFXC;Connect Timeout=45; pooling=false"; 

            string connectionString = @"Data Source=DESKTOP-QANEGN2;Initial Catalog=sun_electrical;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
    }
}