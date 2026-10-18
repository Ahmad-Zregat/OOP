
using System;

namespace EmployeeManagementSystem
{
    internal abstract class Employee
    {



        public Employee(string name, int iD)
        {
            Name = name;
            Id = iD;
        }
        private int _salary;

        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary
        {
            get { return _salary; }
            protected set { _salary = value; }
        }

        

        public abstract int CalculateSalary();

        public void DisplayInfo()
        {
            Salary = CalculateSalary();


            Console.WriteLine($"ID: {Id}, Name: {Name}");
            Console.WriteLine($"Salary: {Salary} JOD");
            Console.WriteLine("--------------------");
        }
    }
}
