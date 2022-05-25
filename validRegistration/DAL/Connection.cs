using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validRegistration.DAL
{
    public class Connection
    {
        SqlConnection con = new SqlConnection();

        public Connection()
        {
            con.ConnectionString = @"Data Source=DESKTOP-7O6596M;Initial Catalog=validRegistration;Integrated Security=True";
        }
        public SqlConnection conect()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void unconect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        internal SqlConnection conection()
        {
            throw new NotImplementedException();
        }
    }
}
