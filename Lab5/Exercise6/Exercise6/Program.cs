namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction = new Transaction("Data Source=An\\SQLEXPRESS;Initial Catalog=Lab5;Integrated Security=True");

            transaction.InsertUser(1, "Nguyen Van B", 40);
            // throw exception
            // The duplicate key value is (1)

            transaction.InsertUser(10, "Nguyen Van B", 40);

            transaction.UpdateUser(2, "Nguyen Van Tung", 50, 6);
            // throw exception
            // The duplicate key value is (2).

            transaction.UpdateUser(11, "Nguyen Van B", 40, 10);

            transaction.DeleteUser(11);

        }
    }
}