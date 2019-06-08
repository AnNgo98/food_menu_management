using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        private string connectStr =
            @"Data Source=.;Initial Catalog=food_menu_managerment;Integrated Security=True";
        //private string connectStr =
        //    @"Data Source=localhost;Initial Catalog=QLMoHinhQuanCoffee;Integrated Security=True";

        public DAL()
        {
            connect = new SqlConnection(connectStr);
            cmd = connect.CreateCommand();
        }

        private SqlConnection openConnection()
        {
            if (connect.State == ConnectionState.Closed || connect.State == ConnectionState.Broken)
            {
                connect.Open();
            }
            return connect;
        }

        public DataSet ExecuteQuery(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            if (p != null)
            {
                foreach (SqlParameter pa in p)
                {
                    cmd.Parameters.Add(pa);
                }
            }
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            connect.Close();
            da.Fill(ds);
            return ds;
        }

        public string ExecuteNonQuery(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            string status = "";
            connect.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter pa in param)
            {
                cmd.Parameters.Add(pa);
            }

            try
            {
                cmd.ExecuteNonQuery();
                status = "Successful";
            }
            catch (Exception e)
            {
                status = e.Message;
            }
            finally
            {
                connect.Close();
            }
            return status;
        }
    }
}
