using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age  { get; set; }
        public decimal  Salary { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{FirstName}\t{LastName}\t{Gender}\t{Age}\t{Salary}";
        }
    }
}
