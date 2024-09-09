using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class UserDAL
    {
        private string connectionString;

        public UserDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void UpdateUser(int id, string name, int age)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
        }

        public void InsertUser(int id, string name, int age)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
        }

        public void RetrieveAndDisplayUsers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
        }

        public void GetUserByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
