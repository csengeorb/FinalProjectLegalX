using System;
using System.Text;

namespace FinalProjectLegalX
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Street { get; set; }
        public string StreetNr { get; set; }
        public string ZIP { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Client ID: {ClientID}");
            output.AppendLine($"Client Name: {FirstName} {MiddleName} {LastName}");
            output.AppendLine($"Date of Birth: {DOB.ToString("dd-MM-yyyy")}");
            output.AppendLine($"Address:\n{Street} {StreetNr} \n{ZIP} {City}");
            return output.ToString();
        }
    }
}
