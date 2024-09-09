namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "Data Source=An\\SQLEXPRESS;Initial Catalog=Lab5;Integrated Security=True";
            UserDAL userDAL = new UserDAL(connectionString);

            // Insert a new user
            userDAL.InsertUser(9, "Nguyen Van A", 30);

            // Update an existing user
            userDAL.UpdateUser(1, "Ho Huu An", 20);

            // Retrieve and display all users
            userDAL.RetrieveAndDisplayUsers();

            // Retrieve a user by ID
            userDAL.GetUserByID(1);

            // Delete a user by ID
            userDAL.DeleteUser(9);

            // Retrieve and display all users after deletion
            Console.WriteLine("Retrieve and display all users after deletion");
            userDAL.RetrieveAndDisplayUsers();
        }
    }
}