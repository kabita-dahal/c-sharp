using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabitaLabwork
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string email, int salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
        public void displayEmployee() {
            Console.WriteLine("Name: {0}, Email: {1}, Salary: {2}", Name, Email, Salary);
        }
    }
    class Lab2Q1
    {
        /*static void Main(string[] args)
        {
            Employee e = new Employee("Kabita","kabita1@gmail.com",100000);
            e.displayEmployee();
            Console.ReadKey();
        }*/
    }
}
