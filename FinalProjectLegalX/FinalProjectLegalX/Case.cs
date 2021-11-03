using System;
using System.Text;

namespace FinalProjectLegalX
{
    public class Case
    {
        public int CaseID { get; set; }
        public int ClientID { get; set; }
        public int LawyerID { get; set; }
        public ECaseType CaseType { get; set; }
        public DateTime StartDate { get; set; }
        public decimal TotalCharges { get; set; }
        public string CaseDescription { get; set; }
        public string Comments { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Case ID: {CaseID}");
            output.AppendLine($"Client ID: {ClientID}");
            output.AppendLine($"Lawyer ID: {LawyerID}");
            output.AppendLine($"Case Type: {CaseType}");
            output.AppendLine($"Start Date: {StartDate.ToString("dd-MM-yyyy")}");
            output.AppendLine($"Total Charges: {TotalCharges}€");
            output.AppendLine($"Case Description: {CaseDescription}");
            output.AppendLine($"Comments: {Comments}");
            return output.ToString();
        }
    }
    public enum ECaseType
    {
        Unknown, Corporate, Criminal, Family,
    }
}
