using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
namespace first_project_in_postgresql
{
    class employee
    {
        public static string getConnectionString()
        {
            string host = "server=localhost;";
            string port = "Port=5432;";
            string db = "Database=MvcCRUDDB;";
            string user = "Username=postgres;";
            string pass = "Password=postgres;";
            string conString = string.Format("{0}{1}{2}{3}{4}",host,port,db,user,pass);
            return conString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default (NpgsqlCommand);
        public static string sql = string.Empty;
        public static DataTable emp_details(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();
            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured: "+ex.Message,"Perform operation failed",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);
                dt = null;

            }
            return dt;
            
        }


    }
}
