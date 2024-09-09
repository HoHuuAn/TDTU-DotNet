using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class StudentDAL
    {
        private string connectionString;

        public StudentDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Displays a list of all students
        public void GetAllStudents()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SelectAllStudents", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("{0,-5}{1,-15}{2,-5}{3,-10}{4,-20}", "ID", "Name", "Age", "Score", "Email");
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            string name = (string)reader["name"];
                            int age = (int)reader["age"];
                            decimal score = (decimal)reader["score"];
                            string email = (string)reader["email"];

                            Console.WriteLine("{0,-5}{1,-15}{2,-5}{3,-10}{4,-20}", id, name, age, score, email);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while accessing the student data: " + ex.Message);
            }
        }

        //add a new student
        public void InsertStudent(int id, string name, int age, decimal score, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        SqlCommand command = new SqlCommand("InsertStudent", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Transaction = transaction;

                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@score", score);
                        command.Parameters.AddWithValue("@email", email);

                        command.ExecuteNonQuery();

                        transaction.Commit();

                        Console.WriteLine("Student inserted successfully.");                        
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("An error occurred while inserting the student: " + ex.Message);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while accessing the database: " + ex.Message);
            }
        }

        //Search for students by any criteria in that student's attributes
        public List<Student> SearchStudentsByCriteria(string searchCriteria)
        {
            List<Student> students = new List<Student>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SearchStudentsByCriteria", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@searchCriteria", searchCriteria);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            string name = (string)reader["name"];
                            int age = (int)reader["age"];
                            decimal score = (decimal)reader["score"];
                            string email = (string)reader["email"];

                            Student student = new Student(id, name, age, score, email);
                            students.Add(student);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while searching for students: " + ex.Message);
            }

            return students;
        }

        //Sort the student list by a certain criterion
        public void SortStudentsByCriterion(string criterion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SortStudentsByCriterion", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@criterion", criterion);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("{0,-5}{1,-15}{2,-5}{3,-10}{4,-20}", "ID", "Name", "Age", "Score", "Email");
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            string name = (string)reader["name"];
                            int age = (int)reader["age"];
                            decimal score = (decimal)reader["score"];
                            string email = (string)reader["email"];

                            Console.WriteLine("{0,-5}{1,-15}{2,-5}{3,-10}{4,-20}", id, name, age, score, email);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while sorting the students: " + ex.Message);
            }
        }

        //Delete a student by id
        public void DeleteStudentById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        SqlCommand command = new SqlCommand("DeleteStudentByID", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Transaction = transaction;

                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();

                        transaction.Commit();

                        Console.WriteLine("Student deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("An error occurred while deleting the student: " + ex.Message);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while accessing the database: " + ex.Message);
            }
        }

    }
}
