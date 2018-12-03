using System;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DataAccess
    {
        private string ConnectionString = @"Server=MVPRO; User Id=sa;  Password=2015; Database=TESTE; Integrated Security = False; Persist Security Info = True";

        public DataSet ExecuteQuery(string Query)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                DataSet ds = new DataSet();
                SqlCommand command = new SqlCommand();
                SqlDataAdapter da;
                
                connection.Open();

                command.Connection = connection;
                command.CommandText = Query;
                command.CommandType = CommandType.Text;

                da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (Exception) { return new DataSet(); }
            finally { connection.Dispose(); }
        }

        public bool ExecuteNonQuery(string Query)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand();

                connection.Open();

                command.Connection = connection;
                command.CommandText = Query;
                command.CommandType = CommandType.Text;
                
                if (command.ExecuteNonQuery() > 0) { return true; }
                else { return false; }
            }
            catch (Exception) { return false; }
            finally { connection.Dispose(); }
        }
    }
}