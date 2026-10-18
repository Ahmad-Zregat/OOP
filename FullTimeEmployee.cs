
using System;

namespace EmployeeManagementSystem
{
    internal class FullTimeEmployee : Employee, IWorkable
    {
        private int _monthlySalary;

        public FullTimeEmployee(string name, int id, int monthlySalary)
            : base(name, id)
        {
            _monthlySalary =monthlySalary;
        }

        public override int CalculateSalary()
        {
            return _monthlySalary;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working full-time.");
        }
    }
}
