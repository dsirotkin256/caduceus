using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Database_API
{
    public class API_DB : IDisposable
    {
        private static string connetionString = "Server=localhost;"+
                                                "Database=Database;" +
                                                "Trusted_Connection=True";

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private readonly SqlTransaction transaction;
        private SqlConnection connection = 
            new SqlConnection(connetionString);
        protected static SqlDataAdapter adapter;
        private SqlCommand command;

        volatile bool HAS_TRANSACTION;

        public API_DB(bool has_transaction)
        {
            HAS_TRANSACTION = has_transaction;

            try
            {
                connection.Open();

                if (has_transaction)
                {
                    transaction = connection.BeginTransaction();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(1);
            }

        }

        public void Close()
        {
            try
            {
                connection.Close();
                connection.Dispose();

                if (HAS_TRANSACTION)
                {
                    transaction.Dispose();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop); 
                Environment.Exit(1);
            }
        }


        public int CreateReturnID(String query)
        {
            try
            {
                if (HAS_TRANSACTION) command.Connection.BeginTransaction();

                command = new SqlCommand(query, connection);
                command.Transaction = transaction;

                int id = (int)command.ExecuteScalar();

                if (HAS_TRANSACTION) command.Transaction.Commit();

                return id;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (HAS_TRANSACTION) command.Transaction.Rollback();

                return 0;
            }
            catch (NullReferenceException)
            {
                if (HAS_TRANSACTION) command.Transaction.Commit();

                return 0;
            }

        }

        public bool Create(string query)
        {

            try
            {
                if (HAS_TRANSACTION) command.Connection.BeginTransaction();

                command = new SqlCommand(query, connection);
                command.Transaction = transaction;

                command.ExecuteNonQuery();

                if (HAS_TRANSACTION) command.Transaction.Commit();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (HAS_TRANSACTION) command.Transaction.Rollback();

                return false;
            }
            catch (NullReferenceException)
            {
                if (HAS_TRANSACTION) command.Transaction.Commit();

                return false;
            }
        }

        public DataSet Retrieve(String query)
        {
            var DataSet = new DataSet();

            try
            {

                adapter =
                    new SqlDataAdapter(query, connection);

                adapter.Fill(DataSet);

                return DataSet;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

        public bool Update(String query)
        {
            return Create(query);
        }

        public bool Delete(String query)
        {
            return Create(query);
        }

        public DataTable FillDataTable(String selectQuery)
        {
            try 
            {
                adapter = new SqlDataAdapter(selectQuery, connection);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message + "\n\n" + selectQuery);

                Application.Exit();
             
                return null;
                
            }
        }
    }
}
