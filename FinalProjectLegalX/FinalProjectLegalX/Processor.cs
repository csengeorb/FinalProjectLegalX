using System;
using System.Collections.Generic;

namespace FinalProjectLegalX
{
    public class Processor
    {
        int caseID = 1;
        int appID = 1;
        int clientID = 1;

        List<Client> clients = new List<Client>();
        List<Appointment> appointments = new List<Appointment>();
        List<Case> cases = new List<Case>();
        List<Lawyer> allLawyers = new List<Lawyer>();
        List<Lawyer> matchedLawyer = new List<Lawyer>();

        public void MainMenu()
        {
            Console.WriteLine("==============================================================\n");
            Console.WriteLine("Welcome to LegalX System! \n");
            Console.WriteLine("Please select your role to continue");
            Console.WriteLine("Press 1 for Lawyer");
            Console.WriteLine("Press 2 for Admin");
            Console.WriteLine("Press 3 for Receptionist");
            Console.WriteLine("Press 0 to Exit");
            Console.WriteLine("\n==============================================================\n");

            string input = Console.ReadLine();
            Console.WriteLine($"You have selected option number {input}");

            switch (input)
            {
                case "1":
                    LawyerLogIn();
                    break;
                case "2":
                    AdminLogIn();
                    break;
                case "3":
                    ReceptionistLogIn();
                    break;
                case "0":
                    Console.WriteLine("You are exiting the program now \n");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        private void LawyerLogIn()
        {
            string username = "Lawyer";
            string password = "1234";
            bool isValidated = false;

            do
            {
                Console.WriteLine("Please provide your username:");
                string enteredusername = Console.ReadLine();
                Console.WriteLine("Please provide your password:");
                string enteredpassword = Console.ReadLine();

                if (username == enteredusername && password == enteredpassword)
                {
                    isValidated = true;
                    DisplayLawyerMenu();
                }
                else
                {
                    Console.WriteLine("You entered a wrong username or password, please try again");
                }
            }
            while (isValidated == false);
        }
        private void AdminLogIn()
        {
            string username = "Admin";
            string password = "1234";
            bool isValidated = false;

            do
            {
                Console.WriteLine("Please provide your username:");
                string enteredusername = Console.ReadLine();
                Console.WriteLine("Please provide your password:");
                string enteredpassword = Console.ReadLine();

                if (username == enteredusername && password == enteredpassword)
                {
                    isValidated = true;
                    DisplayAdminMenu();
                }
                else
                {
                    Console.WriteLine("You entered a wrong username or password, please try again");
                }
            }
            while (isValidated == false);
        }
        private void ReceptionistLogIn()
        {
            string username = "Reception";
            string password = "1234";
            bool isValidated = false;

            do
            {
                Console.WriteLine("Please provide your username:");
                string enteredusername = Console.ReadLine();
                Console.WriteLine("Please provide your password:");
                string enteredpassword = Console.ReadLine();

                if (username == enteredusername && password == enteredpassword)
                {
                    isValidated = true;
                    DisplayReceptionistMenu();
                }
                else
                {
                    Console.WriteLine("You entered a wrong username or password, please try again");
                }
            }
            while (isValidated == false);
        }

        private void DisplayLawyerMenu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("================== Welcome to the Lawyer Section ==================\n");
                Console.WriteLine("Here you can choose between the following options:");
                Console.WriteLine("Press 1 to add a new case");
                Console.WriteLine("Press 2 to list all cases");
                Console.WriteLine("Press 3 to list all appointments");
                Console.WriteLine("Press 0 to log out");
                Console.WriteLine("\n===================================================================\n");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewCase();
                        break;
                    case "2":
                        ListCases();
                        break;
                    case "3":
                        ListAppointments();
                        break;
                    case "0":
                        Console.WriteLine("You have successfully logged out.");
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (choice != "0");
        }
        private void DisplayAdminMenu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("============= Welcome to the Administration Section =============\n");
                Console.WriteLine("Here you can choose between the following options:");
                Console.WriteLine("Press 1 to list all cases");
                Console.WriteLine("Press 2 to list all appointments");
                Console.WriteLine("Press 0 to log out");
                Console.WriteLine("\n==================================================================\n");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListCases();
                        break;
                    case "2":
                        ListAppointments();
                        break;
                    case "0":
                        Console.WriteLine("You have successfully logged out.");
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (choice != "0");
        }
        private void DisplayReceptionistMenu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("============== Welcome to the Receptionist Section ==============\n");
                Console.WriteLine("Here you can choose between the following options:");
                Console.WriteLine("Press 1 to add a new client");
                Console.WriteLine("Press 2 to add a new appointment");
                Console.WriteLine("Press 3 to list all clients");
                Console.WriteLine("Press 4 to list all appointments");
                Console.WriteLine("Press 0 to log out");
                Console.WriteLine("\n==================================================================\n");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewClient();
                        break;
                    case "2":
                        AddNewAppointment();
                        break;
                    case "3":
                        ListClients();
                        break;
                    case "4":
                        ListAppointments();
                        break;
                    case "0":
                        Console.WriteLine("You have successfully logged out.");
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (choice != "0");
        }

        private void AddNewClient()
        {
            Client newclient = new Client();
            Console.WriteLine("================= Welcome to the add client section =================");
            Console.WriteLine("Please enter the client's first name:");
            newclient.FirstName = Console.ReadLine();
            if (string.IsNullOrEmpty(newclient.FirstName))
            {
                Console.WriteLine("First Name cannot be empty, please enter first name again:");
                newclient.FirstName = Console.ReadLine();
            }
            Console.WriteLine("Please enter the client's middle name:");
            newclient.MiddleName = Console.ReadLine();
            Console.WriteLine("Please enter the client's last name:");
            newclient.LastName = Console.ReadLine();
            if (string.IsNullOrEmpty(newclient.LastName))
            {
                Console.WriteLine("Last Name cannot be empty, please enter last name again:");
                newclient.LastName = Console.ReadLine();
            }
            Console.WriteLine("Please enter the client's date of birth in format DD-MM-YYYY:");
            newclient.DOB = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            Console.WriteLine("Please enter the street name:");
            newclient.Street = Console.ReadLine();
            Console.WriteLine("Please enter the street number:");
            newclient.StreetNr = Console.ReadLine();
            Console.WriteLine("Please enter the ZIP code:");
            newclient.ZIP = Console.ReadLine();
            Console.WriteLine("Please enter the city:");
            newclient.City = Console.ReadLine();

            //Adding automatically assigned Client ID
            newclient.ClientID = clientID;
            clientID++;
            clients.Add(newclient);

            Console.WriteLine("");
            Console.WriteLine("Client has been successfully added!");
            Console.WriteLine("\n==================================================================\n");
        }

        private void AddNewAppointment()
        {
            List<Lawyer> allLawyers = GetAllLawyers();
            //List<Lawyer> matchedLawyers = new List<Lawyer>();

            Appointment newappmt = new Appointment();
            Console.WriteLine("=============== Welcome to the add appointment section ===============");
            Console.WriteLine("Please enter Client ID:");
            newappmt.ClientID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the type of case that concerns the appointment:");
            Console.WriteLine("1 for Corporate Case");
            Console.WriteLine("2 for Criminal Case");
            Console.WriteLine("3 for Family Case");
            Console.WriteLine("4 for Unknown");
            int userinputcase = int.Parse(Console.ReadLine());

            switch (userinputcase)
            {
                case 1:
                    newappmt.CaseType = ECaseType.Corporate;
                    foreach (Lawyer l in allLawyers)
                    {
                        if (l.Specialization == ESpecialization.Corporate && newappmt.CaseType == ECaseType.Corporate)
                        {
                            matchedLawyer.Add(l);
                        }
                    }
                    break;
                case 2:
                    newappmt.CaseType = ECaseType.Criminal;
                    foreach (Lawyer l in allLawyers)
                    {
                        if (l.Specialization == ESpecialization.Criminal && newappmt.CaseType == ECaseType.Criminal)
                        {
                            matchedLawyer.Add(l);
                        }
                    }
                    break;
                case 3:
                    newappmt.CaseType = ECaseType.Family;
                    foreach (Lawyer l in allLawyers)
                    {
                        if (l.Specialization == ESpecialization.Family && newappmt.CaseType == ECaseType.Family)
                        {
                            matchedLawyer.Add(l);
                        }
                    }
                    break;
                case 4:
                    newappmt.CaseType = ECaseType.Unknown;
                    foreach (Lawyer l in allLawyers)
                    {
                        if (l.Specialization == ESpecialization.Unknown && newappmt.CaseType == ECaseType.Unknown)
                        {
                            matchedLawyer.Add(l);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine("============= The following lawyers are qualified for the case =============");
            if (matchedLawyer.Count == 0)
            {
                Console.WriteLine("Unfortunately no lawyers were found for that specific case.");
            }
            else
            {
                foreach (Lawyer foundlaw in matchedLawyer)
                {
                    Console.WriteLine(foundlaw);
                }
            }
            Console.WriteLine("\n==================================================================\n");

            Console.WriteLine("Please select the desired lawyer by providing his/her Employee ID:");
            newappmt.LawyerID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the date for the appointment (DD-MM-YYYY):");
            newappmt.AppointmentTime = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null); //ADD try catch/exception handling, if date is not in correct format
            Console.WriteLine("Please select the meeting room:");
            Console.WriteLine("1 for Warrior with a capacity of 20 persons");
            Console.WriteLine("2 for SOS with a capacity of 15 persons");
            Console.WriteLine("3 for Cube with a capacity of 10 persons");
            Console.WriteLine("4 for Cave with a capacity of 8 persons");
            Console.WriteLine("5 for to be determined");
            string userinputroom = Console.ReadLine();

            switch (userinputroom)
            {
                case "1":
                    newappmt.MeetingRoom = EMeetingRoom.Warrior;
                    break;
                case "2":
                    newappmt.MeetingRoom = EMeetingRoom.SOS;
                    break;
                case "3":
                    newappmt.MeetingRoom = EMeetingRoom.Cube;
                    break;
                case "4":
                    newappmt.MeetingRoom = EMeetingRoom.Cave;
                    break;
                case "5":
                    newappmt.MeetingRoom = EMeetingRoom.Unknown;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine("Additional comment or remark concerning the meeting:");
            newappmt.ShortDescription = Console.ReadLine();

            //Adding automatically assigned Appointment ID
            newappmt.AppointmentID = appID;
            appID++;
            appointments.Add(newappmt);

            Console.WriteLine("");
            Console.WriteLine("Appointment has been successfully added!");
            Console.WriteLine("\n==================================================================\n");
        }
        private void AddNewCase()
        {
            Case newcase = new Case();
            Console.WriteLine("=============== Welcome to the add new case section ===============");
            Console.WriteLine("Please enter Client ID:");
            newcase.ClientID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Lawyer ID:");
            newcase.LawyerID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the case type:");
            Console.WriteLine("1 for Corporate Case");
            Console.WriteLine("2 for Criminal Case");
            Console.WriteLine("3 for Family Case");
            Console.WriteLine("4 for Unknown");
            string userinputcase = Console.ReadLine();

            switch (userinputcase)
            {
                case "1":
                    newcase.CaseType = ECaseType.Corporate;
                    break;
                case "2":
                    newcase.CaseType = ECaseType.Criminal;
                    break;
                case "3":
                    newcase.CaseType = ECaseType.Family;
                    break;
                case "4":
                    newcase.CaseType = ECaseType.Unknown;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine("Please enter the start date of the case (DD-MM-YYYY):");
            newcase.StartDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null); //ADD try catch/exception handling, if date is not in correct format         
            Console.WriteLine("Please enter the total charges (€):");
            newcase.TotalCharges = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a short description of the case:");
            newcase.CaseDescription = Console.ReadLine();
            Console.WriteLine("Please enter any addtional comments concerning the case:");
            newcase.Comments = Console.ReadLine();

            //Adding automatically assigned Case ID
            newcase.CaseID = caseID;
            caseID++;
            cases.Add(newcase);

            Console.WriteLine("");
            Console.WriteLine("Case has been successfully added!");
            Console.WriteLine("\n==================================================================\n");
        }

        private void ListClients()
        {
            foreach (Client c in clients)
            {
                Console.WriteLine(c);
            }
        }
        private void ListCases()
        {
            foreach (Case ca in cases)
            {
                Console.WriteLine(ca);
            }
        }
        private void ListAppointments()
        {
            foreach (Appointment app in appointments)
            {
                Console.WriteLine(app);
            }
        }

        private List<Lawyer> GetAllLawyers()
        {
            List<Employee> allemps = GetAllEmployees();

            foreach (Employee emp in allemps)
            {
                if (emp is Lawyer)
                {
                    allLawyers.Add((Lawyer)emp);
                }
            }
            return allLawyers;
        }

        private List<Employee> GetAllEmployees()
        {
            List<Employee> allemps = new List<Employee>();

            Lawyer law1 = new Lawyer(1, "Harvey", "Spector");
            law1.Seniority = ESeniority.Senior;
            law1.Specialization = ESpecialization.Corporate;
            law1.JoinedOn = DateTime.ParseExact("01-06-2017", "dd-MM-yyyy", null);
            law1.DOB = DateTime.ParseExact("22-01-1972", "dd-MM-yyyy", null);
            allemps.Add(law1);

            Lawyer law2 = new Lawyer(2, "Mike", "Ross");
            law2.Seniority = ESeniority.Senior;
            law2.Specialization = ESpecialization.Corporate;
            law2.JoinedOn = DateTime.ParseExact("10-11-2019", "dd-MM-yyyy", null);
            law2.DOB = DateTime.ParseExact("27-08-1981", "dd-MM-yyyy", null);
            allemps.Add(law2);

            Lawyer law3 = new Lawyer(3, "Jessica", "Pearson");
            law3.Seniority = ESeniority.Senior;
            law3.Specialization = ESpecialization.Corporate;
            law3.JoinedOn = DateTime.ParseExact("01-01-2015", "dd-MM-yyyy", null);
            law3.DOB = DateTime.ParseExact("25-04-1969", "dd-MM-yyyy", null);
            allemps.Add(law3);

            Lawyer law4 = new Lawyer(4, "Louis", "Litt");
            law4.Seniority = ESeniority.Senior;
            law4.Specialization = ESpecialization.Criminal;
            law4.JoinedOn = DateTime.ParseExact("01-06-2017", "dd-MM-yyyy", null);
            law4.DOB = DateTime.ParseExact("12-06-1970", "dd-MM-yyyy", null);
            allemps.Add(law4);

            Lawyer law5 = new Lawyer(5, "Alicia", "Florrick");
            law5.Seniority = ESeniority.Senior;
            law5.Specialization = ESpecialization.Corporate;
            law5.JoinedOn = DateTime.ParseExact("01-08-2012", "dd-MM-yyyy", null);
            law5.DOB = DateTime.ParseExact("08-06-1966", "dd-MM-yyyy", null);
            allemps.Add(law5);

            Lawyer law6 = new Lawyer(6, "William", "Gardner");
            law6.Seniority = ESeniority.Senior;
            law6.Specialization = ESpecialization.Criminal;
            law6.JoinedOn = DateTime.ParseExact("01-12-2013", "dd-MM-yyyy", null);
            law6.DOB = DateTime.ParseExact("03-03-1973", "dd-MM-yyyy", null);
            allemps.Add(law6);

            Lawyer law7 = new Lawyer(7, "Diane", "Lockhart");
            law7.Seniority = ESeniority.Senior;
            law7.Specialization = ESpecialization.Corporate;
            law7.JoinedOn = DateTime.ParseExact("01-05-2011", "dd-MM-yyyy", null);
            law7.DOB = DateTime.ParseExact("31-01-1963", "dd-MM-yyyy", null);
            allemps.Add(law7);

            Lawyer law8 = new Lawyer(8, "Ella", "Jones");
            law8.Seniority = ESeniority.Junior;
            law8.Specialization = ESpecialization.Family;
            law8.JoinedOn = DateTime.ParseExact("01-08-2019", "dd-MM-yyyy", null);
            law8.DOB = DateTime.ParseExact("22-01-1995", "dd-MM-yyyy", null);
            allemps.Add(law8);

            Lawyer law9 = new Lawyer(9, "Ragnar", "Lothbrok");
            law9.Seniority = ESeniority.Junior;
            law9.Specialization = ESpecialization.Corporate;
            law9.JoinedOn = DateTime.ParseExact("01-12-2019", "dd-MM-yyyy", null);
            law9.DOB = DateTime.ParseExact("23-01-1992", "dd-MM-yyyy", null);
            allemps.Add(law9);

            Lawyer law10 = new Lawyer(10, "Hannah", "Wilson");
            law10.Seniority = ESeniority.Junior;
            law10.Specialization = ESpecialization.Criminal;
            law10.JoinedOn = DateTime.ParseExact("01-01-2020", "dd-MM-yyyy", null);
            law10.DOB = DateTime.ParseExact("25-01-1991", "dd-MM-yyyy", null);
            allemps.Add(law10);

            Lawyer law11 = new Lawyer(11, "Rudolf", "Taylor");
            law11.Seniority = ESeniority.Junior;
            law11.Specialization = ESpecialization.Criminal;
            law11.JoinedOn = DateTime.ParseExact("01-03-2020", "dd-MM-yyyy", null);
            law11.DOB = DateTime.ParseExact("31-01-1987", "dd-MM-yyyy", null);
            allemps.Add(law11);

            Lawyer law12 = new Lawyer(12, "Villö", "Martinez");
            law12.Seniority = ESeniority.Junior;
            law12.Specialization = ESpecialization.Criminal;
            law12.JoinedOn = DateTime.ParseExact("15-03-2020", "dd-MM-yyyy", null);
            law12.DOB = DateTime.ParseExact("18-01-2000", "dd-MM-yyyy", null);
            allemps.Add(law12);

            Lawyer law13 = new Lawyer(13, "Maximilian", "Brown");
            law13.Seniority = ESeniority.Junior;
            law13.Specialization = ESpecialization.Family;
            law13.JoinedOn = DateTime.ParseExact("01-04-2021", "dd-MM-yyyy", null);
            law13.DOB = DateTime.ParseExact("07-07-1994", "dd-MM-yyyy", null);
            allemps.Add(law13);

            Lawyer law14 = new Lawyer(14, "Lotta", "Williams");
            law14.Seniority = ESeniority.Junior;
            law14.Specialization = ESpecialization.Corporate;
            law14.JoinedOn = DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", null);
            law14.DOB = DateTime.ParseExact("17-09-1977", "dd-MM-yyyy", null);
            allemps.Add(law14);

            Lawyer law15 = new Lawyer(15, "Ida", "Green");
            law15.Seniority = ESeniority.Junior;
            law15.Specialization = ESpecialization.Corporate;
            law15.JoinedOn = DateTime.ParseExact("15-05-2021", "dd-MM-yyyy", null);
            law15.DOB = DateTime.ParseExact("01-01-2000", "dd-MM-yyyy", null);
            allemps.Add(law15);

            Lawyer law16 = new Lawyer(16, "Peter", "White");
            law16.Seniority = ESeniority.Junior;
            law16.Specialization = ESpecialization.Family;
            law16.JoinedOn = DateTime.ParseExact("15-12-2018", "dd-MM-yyyy", null);
            law16.DOB = DateTime.ParseExact("03-12-1985", "dd-MM-yyyy", null);
            allemps.Add(law16);

            Lawyer law17 = new Lawyer(17, "Alfred", "Lopez");
            law17.Seniority = ESeniority.Junior;
            law17.Specialization = ESpecialization.Criminal;
            law17.JoinedOn = DateTime.ParseExact("03-06-2019", "dd-MM-yyyy", null);
            law17.DOB = DateTime.ParseExact("26-07-1991", "dd-MM-yyyy", null);
            allemps.Add(law17);

            Lawyer law18 = new Lawyer(18, "Josh", "Lee");
            law18.Seniority = ESeniority.Junior;
            law18.Specialization = ESpecialization.Criminal;
            law18.JoinedOn = DateTime.ParseExact("01-06-2021", "dd-MM-yyyy", null);
            law18.DOB = DateTime.ParseExact("29-08-1997", "dd-MM-yyyy", null);
            allemps.Add(law18);

            Lawyer law19 = new Lawyer(19, "Oscar", "Gonzalez");
            law19.Seniority = ESeniority.Junior;
            law19.Specialization = ESpecialization.Criminal;
            law19.JoinedOn = DateTime.ParseExact("01-07-2020", "dd-MM-yyyy", null);
            law19.DOB = DateTime.ParseExact("09-05-1993", "dd-MM-yyyy", null);
            allemps.Add(law19);

            Lawyer law20 = new Lawyer(20, "Noah", "Harris");
            law20.Seniority = ESeniority.Junior;
            law20.Specialization = ESpecialization.Corporate;
            law20.JoinedOn = DateTime.ParseExact("01-09-2019", "dd-MM-yyyy", null);
            law20.DOB = DateTime.ParseExact("28-03-2001", "dd-MM-yyyy", null);
            allemps.Add(law20);

            Lawyer law21 = new Lawyer(21, "Anne", "Clark");
            law21.Seniority = ESeniority.Junior;
            law21.Specialization = ESpecialization.Corporate;
            law21.JoinedOn = DateTime.ParseExact("01-12-2020", "dd-MM-yyyy", null);
            law21.DOB = DateTime.ParseExact("15-11-1986", "dd-MM-yyyy", null);
            allemps.Add(law21);

            Lawyer law22 = new Lawyer(22, "Camilla", "Lewis");
            law22.Seniority = ESeniority.Junior;
            law22.Specialization = ESpecialization.Corporate;
            law22.JoinedOn = DateTime.ParseExact("15-03-2019", "dd-MM-yyyy", null);
            law22.DOB = DateTime.ParseExact("07-06-1999", "dd-MM-yyyy", null);
            allemps.Add(law22);

            Lawyer law23 = new Lawyer(23, "Marianne", "Robinson");
            law16.Seniority = ESeniority.Junior;
            law16.Specialization = ESpecialization.Family;
            law16.JoinedOn = DateTime.ParseExact("02-08-2020", "dd-MM-yyyy", null);
            law16.DOB = DateTime.ParseExact("24-12-1990", "dd-MM-yyyy", null);
            allemps.Add(law16);

            Lawyer law24 = new Lawyer(24, "Susan", "Walker");
            law24.Seniority = ESeniority.Junior;
            law24.Specialization = ESpecialization.Family;
            law24.JoinedOn = DateTime.ParseExact("01-05-2019", "dd-MM-yyyy", null);
            law24.DOB = DateTime.ParseExact("02-08-1991", "dd-MM-yyyy", null);
            allemps.Add(law24);

            Lawyer law25 = new Lawyer(25, "Carlos", "Perez");
            law25.Seniority = ESeniority.Junior;
            law25.Specialization = ESpecialization.Family;
            law25.JoinedOn = DateTime.ParseExact("01-02-2021", "dd-MM-yyyy", null);
            law25.DOB = DateTime.ParseExact("10-07-1989", "dd-MM-yyyy", null);
            allemps.Add(law25);

            Lawyer law26 = new Lawyer(26, "Lisa", "Hall");
            law26.Seniority = ESeniority.Junior;
            law26.Specialization = ESpecialization.Family;
            law26.JoinedOn = DateTime.ParseExact("15-11-2020", "dd-MM-yyyy", null);
            law26.DOB = DateTime.ParseExact("04-09-1996", "dd-MM-yyyy", null);
            allemps.Add(law26);

            Administration admin1 = new Administration(27, "Adi", "Endre");
            admin1.JoinedOn = DateTime.ParseExact("15-03-2016", "dd-MM-yyyy", null);
            admin1.Role = "Contract administrator";
            allemps.Add(admin1);

            Administration admin2 = new Administration(28, "Moor", "Jokai");
            admin2.JoinedOn = DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", null);
            admin2.Role = "Legal assistant";
            allemps.Add(admin2);

            Administration admin3 = new Administration(29, "Helga", "Horvath");
            admin3.JoinedOn = DateTime.ParseExact("03-07-2019", "dd-MM-yyyy", null);
            admin3.Role = "File Clerk";
            allemps.Add(admin3);

            Receptionist recept1 = new Receptionist(30, "Karla", "Hansen");
            recept1.JoinedOn = DateTime.ParseExact("01-04-2016", "dd-MM-yyyy", null);
            allemps.Add(recept1);

            return allemps;
        }
    }
}
