# FinalProjectLegalX

Brief Solution Plan
This report presents technical specifications and design choices about the application for company LegalX. 
The solution is built using Object Oriented programming principles. 
The solution consists of a total of 9 classes, including the main class, the parent class Employee and its three child classes, namely Lawyer, Administration and Receptionist, 
as well as the classes Client, Appointment, Case and Processor.

The main class instantiates the Processor class and calls for its method MainMenu(). 
There the user is presented with 4 choices, either to choose their specific role to prompt its log in or to quit the program. 
Depending on what role the user selects, the log in credentials and the menu with the tasks that the user can perform differ. 
Thus, the initial page determines what features of the application will be available to the user after the successful log in.
The Processor class will automatically go on to call the needed methods according to the user’s decisions. 
The MainMenu() calls the individual LogIn() method that user selects, which then in return calls the equivalent DisplayMenu() method where the options are adjusted according to the role of the user. 
The remaining classes are used to define properties so that the information collected from the user can be stored in the properties and then added to the overall list of the class.

The Application has the following users:
- Lawyer
- Admin
- Receptionist

The Receptionist can perform the following task:
- Add a new client
- Add a new appointment
- List all clients
- List all appointments

A Lawyer can perform the following task:
- Add a new case
- List all cases
- List all appointments

An Admin can perform the following task:
- List all cases
- List all appointments

List of Classes
- Program.cs: to instantiate the Processor class and call the MainMenu() method
- Employee: parent class, declares certain common properties
- Lawyer: child class, stating the properties of a lawyer
- Administration: child class, stating the properties of an admin staff
- Receptionist: child class, stating the properties of a receptionist
- Case: stating the properties of a case
- Client: stating the properties of a client
- Appointment: stating the properties of an appointment
- Processor: for the main functionalities of the application
