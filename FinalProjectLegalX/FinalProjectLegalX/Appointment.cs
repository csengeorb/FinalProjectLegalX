using System;
using System.Text;

namespace FinalProjectLegalX
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int ClientID { get; set; }
        public int LawyerID { get; set; }
        public ECaseType CaseType { get; set; }
        public DateTime AppointmentTime { get; set; }
        public EMeetingRoom MeetingRoom { get; set; }
        public string ShortDescription { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Appointment ID: {AppointmentID}");
            output.AppendLine($"Client ID: {ClientID}");
            output.AppendLine($"Type of Case: {CaseType}");
            output.AppendLine($"Lawyer ID: {LawyerID}");
            output.AppendLine($"Meeting Date: {AppointmentTime.ToString("dd-MM-yyyy")}");
            output.AppendLine($"Location: {MeetingRoom} Meeting Room");
            output.AppendLine($"Description: {ShortDescription}");
            return output.ToString();
        }
    }
    public enum EMeetingRoom
    {
        Unknown, Warrior, SOS, Cube, Cave,
    }
}
