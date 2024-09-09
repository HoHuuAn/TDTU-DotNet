using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise6
{
    public class Transaction
    {
        private string connectionString;

        public Transaction(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertUser( int id, string name, int age)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = null;
                try
                {
                    transaction = connection.BeginTransaction();

                    SqlCommand command = new SqlCommand("InsertUser", connection);
           
                    command.Connection = connection;
                    command.Transaction = transaction;


                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Age", age);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        Console.WriteLine("Record updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to update record.");
                    }
                    

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred. Rolling back the transaction.");

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        Console.WriteLine("Rollback failed: " + rollbackEx.Message);
                    }

                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
        public void UpdateUser(int newId, string name, int age, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = null;
                try
                {
                    transaction = connection.BeginTransaction();

                    SqlCommand command = new SqlCommand($"UPDATE [dbo].[user] SET ID = @NewID, Name = @Name, Age = @Age WHERE ID = @ID", connection);

                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.Parameters.AddWithValue("@NewID", newId);
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Age", age);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        Console.WriteLine("Record updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to update record.");
                    }


                    transaction.Commit();


                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred. Rolling back the transaction.");

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        Console.WriteLine("Rollback failed: " + rollbackEx.Message);
                    }

                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void DeleteUser(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DeleteUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        Console.WriteLine("Record deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete record.");
                    }
                }
            }
        }
    }
}
