using System;

namespace EmployeeManagementSystem
{
    internal class PartTimeEmployee : Employee, IWorkable
    {
        private int _workingHours;
        private int _hourlyRate;

        public PartTimeEmployee(string name, int id, int workingHours, int hourlyRate)
            : base(name, id)
        {
            _workingHours = workingHours;
            _hourlyRate = hourlyRate;
        }
        
        public override int CalculateSalary()
        {
            return _workingHours * _hourlyRate;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working part-time.");
        }
    }
}



