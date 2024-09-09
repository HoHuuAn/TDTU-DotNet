using System.Data.SqlClient;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=An\\SQLEXPRESS;Initial Catalog=Lab5;Integrated Security=True"))
            {
                connection.Open();

                InsertNewRecord(connection, "7", "Anthony Smith", "30");

                UpdateRecord(connection, "1", "Ho Huu An", "20");

                RetrieveAndDisplayRecords(connection);

                connection.Close();
            }
        }

        /* Demonstrate the use of parameterized queries with different data types
         * When using AddWithValue, the value added to the SQL query will be automatically converted to the corresponding data type.
         * Not need to worry about specifying specific data types for query parameters.
         * 
         * For below example with UpdateRecord and InsertNewRecord, 
         * ID and age in database are int, but the values added to SQL query is String
         * AddWithValue automatically convert to Int
        */
        private static void UpdateRecord(SqlConnection connection, String id, string name, String age)
        {
            string updateQuery = $"UPDATE [dbo].[user] SET Name = @Name, Age = @Age WHERE ID = @ID";

            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@ID", id);
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

        private static void InsertNewRecord(SqlConnection connection, String id, string name, String age)
        {
            string insertQuery = "INSERT INTO [User] (ID, Name, Age) VALUES (@ID, @Name, @Age)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
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
            string selectQuery = "SELECT * FROM [User]";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
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
    }
}