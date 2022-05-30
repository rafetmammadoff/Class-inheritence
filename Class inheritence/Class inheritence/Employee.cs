using System;
using System.Collections.Generic;
using System.Text;

namespace Class_inheritence
{
    internal class Employee : Human
    {
        public Employee(string fullName) : base(fullName)
        {

        }
        public int Salary;
        public string Position;
    }
}
