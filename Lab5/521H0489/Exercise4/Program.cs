using System.Data;
using System.Data.SqlClient;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=An\\SQLEXPRESS;Initial Catalog=Lab5;Integrated Security=True"))
            {
                connection.Open();

                InsertNewRecord(connection, 8, "Nguyen Van A", 30);

                UpdateRecord(connection, 1, "Ho Huu An", 50);

                RetrieveAndDisplayRecords(connection);

                GetUsersByID(connection, 1);

                connection.Close();
            }

        }

        private static void UpdateRecord(SqlConnection connection, int id, string name, int age)
        {
            using (SqlCommand command = new SqlCommand("UpdateUser", connection))
            {
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
            }
        }

        private static void InsertNewRecord(SqlConnection connection, int id, string name, int age)
        {
            using (SqlCommand command = new SqlCommand("InsertUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 1)
                {
                    Console.WriteLine("New record inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to insert new record.");
                }
            }
        }

        private static void RetrieveAndDisplayRecords(SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("RetrieveUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Retrieved records:");

                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        string name = (string)reader["Name"];
                        int age = (int)reader["Age"];

                        Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
                    }
                }
            }
        }

        private static void GetUsersByID(SqlConnection connection, int id)
        {
            using (SqlCommand command = new SqlCommand("GetUsersByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Retrieved records:");

                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        int age = (int)reader["Age"];

                        Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
                    }
                }
            }
        }
    }
}