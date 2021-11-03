using System;
using System.Text;

namespace FinalProjectLegalX
{
    public class Lawyer : Employee
    {
        public Lawyer(int empID, string firstName, string lastName) : base(empID, firstName, lastName)
        {

        }

        public DateTime DOB { get; set; }
        public ESeniority Seniority { get; set; }
        public ESpecialization Specialization { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            output.AppendLine($"Date of Birth: {DOB.ToString("dd-MM-yyyy")}");
            output.AppendLine($"Seniority: {Seniority}");
            output.AppendLine($"Specialization: {Specialization}");
            return output.ToString();
        }
    }
    public enum ESeniority
    {
        Unknown, Senior, Junior,
    }
    public enum ESpecialization
    {
        Unknown, Corporate, Criminal, Family,
    }
}
