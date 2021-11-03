using System;
using System.Text;

namespace FinalProjectLegalX
{
    public abstract class Employee
    {
        public Employee(int empID, string firstName, string lastName)
        {
            EmployeeID = empID;
            FirstName = firstName;
            LastName = lastName;
        }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinedOn { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Employee ID: {EmployeeID}");
            output.AppendLine($"Name: {FirstName} {LastName}");
            output.AppendLine($"Start Date: {JoinedOn.ToString("dd-MM-yyyy")}");
            return output.ToString();
        }
    }
}
