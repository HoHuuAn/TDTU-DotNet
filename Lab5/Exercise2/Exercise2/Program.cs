using System.Data.SqlClient;
using System.Xml.Linq;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=An\\SQLEXPRESS;Initial Catalog=Lab5;Integrated Security=True"))
            {
                connection.Open();

                InsertNewRecord(connection, 4, "Sarah Johnson", 28);

                UpdateRecord(connection, 1, "Ho Huu An", 31);

                RetrieveAndDisplayRecords(connection);

                connection.Close();
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

        private static void UpdateRecord(SqlConnection connection, int id, string name, int age)
        {
            string updateQuery = $"UPDATE [dbo].[user] SET Name = '{name}', Age = {age} WHERE ID = {id}";

            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 1 )
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
            string insertQuery = $"INSERT INTO [User] (ID, Name, Age) VALUES ({id}, '{name}', {age})";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
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
    }
}