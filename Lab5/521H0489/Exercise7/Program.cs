using System.Data.SqlClient;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String connectionString = "Data Source=An\\SQLEXPRESS;Initial Catalog=Lab5_Ex7;Integrated Security=True";
            StudentDAL studentDAL = new StudentDAL(connectionString);
            studentDAL.GetAllStudents();

            while (true)
            {
                Console.WriteLine("\n**************************************************************************");
                Console.WriteLine("|    1. Displays a list of all students                                  |");
                Console.WriteLine("|    2. Add a new student                                                |");
                Console.WriteLine("|    3. Search for students by any criteria in that student's attributes |");
                Console.WriteLine("|    4. Sort the student list by a certain criterion                     |");
                Console.WriteLine("|    5. Delete a student by id                                           |");
                Console.WriteLine("|    6. Exit                                                             |");
                Console.WriteLine("**************************************************************************\n");

                int number = 0;
                bool isValidNumber = false;

                while (!isValidNumber)
                {
                    Console.Write("Choose number from 1 to 6: ");
                    string choose = Console.ReadLine();

                    if (int.TryParse(choose, out number))
                    {
                        isValidNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                switch (number)
                {
                    case 1:
                        studentDAL.GetAllStudents();
                        break;
                    case 2:
                        Console.Write("\nEnter attribute of Student (id, name, age, score, email) respectively: \n");

                        Console.Write("ID: ");
                        string temp = Console.ReadLine();
                        int id;

                        while (string.IsNullOrWhiteSpace(temp))
                        {
                            Console.WriteLine("ID is required. Please enter a valid ID.");
                            Console.Write("ID: ");
                            temp = Console.ReadLine();
                        }

                        id = int.Parse(temp);

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        while (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Name is required. Please enter a valid name.");
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                        }

                        Console.Write("Age: ");
                        temp = Console.ReadLine();
                        int age;

                        while (string.IsNullOrWhiteSpace(temp))
                        {
                            Console.WriteLine("Age is required. Please enter a valid age.");
                            Console.Write("Age: ");
                            temp = Console.ReadLine();
                        }

                        age = int.Parse(temp);

                        Console.Write("Score: ");
                        temp = Console.ReadLine();
                        decimal score;

                        while (string.IsNullOrWhiteSpace(temp))
                        {
                            Console.WriteLine("Score is required. Please enter a valid score.");
                            Console.Write("Score: ");
                            temp = Console.ReadLine();
                        }

                        score = decimal.Parse(temp);

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        while (string.IsNullOrWhiteSpace(email))
                        {
                            Console.WriteLine("Email is required. Please enter a valid email.");
                            Console.Write("Email: ");
                            email = Console.ReadLine();
                        }

                        studentDAL.InsertStudent(id, name, age, score, email);
                        break;
                    case 3:
                        Console.Write("\nEnter Criteria: ");
                        String criteria = Console.ReadLine();
                        List<Student> students = studentDAL.SearchStudentsByCriteria(criteria);
                        Console.WriteLine("{0,-5}{1,-15}{2,-5}{3,-10}{4,-20}", "ID", "Name", "Age", "Score", "Email");
                        foreach (Student student in students)
                        {
                            Console.WriteLine("{0,-5}{1,-15}{2,-5}{3,-10}{4,-20}", student.Id, student.Name, student.Age, student.Score, student.Email);
                        }
                        break;
                    case 4:
                        Console.Write("\nEnter criterion of Student (id, name, age, score, email): ");
                        string criterion = Console.ReadLine();
                        Console.WriteLine();
                        if (criterion == "id" || criterion == "name" || criterion == "age" || criterion == "score" || criterion == "email")
                        {
                            studentDAL.SortStudentsByCriterion(criterion);
                        }
                        else
                        {
                            Console.WriteLine("Invalid criterion entered. Please enter one of the valid options.");
                        }
                        break;
                    case 5:
                        Console.Write("\nEnter id of Student needed to be deleted: ");
                        String delete = Console.ReadLine();
                        int deleteID ;
                        while (string.IsNullOrWhiteSpace(delete))
                        {
                            Console.WriteLine("ID is required. Please enter a valid ID.");
                            Console.Write("ID: ");
                            delete = Console.ReadLine();
                        }
                        deleteID = int.Parse(delete);

                        studentDAL.DeleteStudentById(deleteID);
                        break;
                    case 6:
                        Console.WriteLine("Good bye");
                        return;
                    default:
                        Console.WriteLine("Please choose number from 1 to 6");
                        break;
                }
            } 
        }
    }
}