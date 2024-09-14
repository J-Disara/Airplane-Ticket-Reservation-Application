using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Airplane_Reservation_System
{


    internal class SQL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        public SQL()
        {
            con = new SqlConnection("");
        }

        public double insert_update_delete(string query)
        {
            con.Open();
            cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public DataTable view(string query)
        {
            con.Open();
            sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            return dt;
        }
    }
}
