using System;
using System.Text;

namespace FinalProjectLegalX
{
    public class Administration : Employee
    {
        public Administration(int empID, string firstName, string lastName) : base(empID, firstName, lastName)
        {

        }

        public string Role { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            output.AppendLine($"Job Title: {Role}");
            return output.ToString();
        }
    }
}
