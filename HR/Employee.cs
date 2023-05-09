using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRForms
{
    public class Employee
    {
        public int EmployeCode { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Department { get; }

        public Employee(int EmployeCode, string FirstName, string LastName, string Department)
        {
            this.EmployeCode = EmployeCode;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Department = Department;
        }
    }
}
