using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validRegistration.DAL
{
     class LoginDalCommands
    {
        public bool have = false;
        public String message = "";
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;

        public bool checkLogin(String username, String password)
        {
            cmd.CommandText = "select * from tableName where email = @username and password = @password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                cmd.Connection = con.conection();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    have = true;
                }
            }
            catch (SqlException)
            {

                this.message = "Error on database!";
            }
            return have;
        }
    }
}
