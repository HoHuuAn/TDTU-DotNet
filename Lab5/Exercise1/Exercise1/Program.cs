using System.Data.SqlClient;
using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=An\\SQLEXPRESS;Initial Catalog=Lab5;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT * FROM [User]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["ID"];
                            string name = (string)reader["Name"];
                            int age = (int)reader["Age"];

                            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}