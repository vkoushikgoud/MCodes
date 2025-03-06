using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tues
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Age = 25;
        }

        public void setAge(int age)
        {
            if (age < 0)
            {
                throw new AgeException("Age can not be negative");
            }
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine("Id: " + Id + " Name: " + Name + " Age: " + Age);
        }
    }
}
