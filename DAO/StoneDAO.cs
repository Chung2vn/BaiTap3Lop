using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class StoneDAO
    {
        public string ConString = @"Data Source=GF75-THIN-9RCX\SQLEXPRESS;Initial Catalog=database_moi;User ID=sa;Password=000000";
        
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();

        public DataTable Read()
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM InfinityStones; ", con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        public DataTable Read(Int16 Id)
        {
            con.ConnectionString= ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from InfinityStones where StoneID= " + Id + "", con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt ;
            }
            catch 
            {
                throw;
            }

        }
    }
}
