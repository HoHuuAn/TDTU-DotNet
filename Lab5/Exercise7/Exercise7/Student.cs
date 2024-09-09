using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Score { get; set; }
        public string Email { get; set; }

        public Student(int id, string name, int age, decimal score, string email)
        {
            Id = id;
            Name = name;
            Age = age;
            Score = score;
            Email = email;
        }
    }
}
