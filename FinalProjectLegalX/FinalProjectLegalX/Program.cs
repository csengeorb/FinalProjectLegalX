using System;

namespace FinalProjectLegalX
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var p = new Processor();
            try
            {
                p.MainMenu();
            }
            catch (Exception error)
            {
                Console.WriteLine("Unfortunately an error occurred. The program unexpectedly quit.");
                Console.WriteLine($"The Error Message is: {error}");
                Console.WriteLine("\n==================================================================\n");
                Console.WriteLine("Program will be restarted, please try again");
                p.MainMenu();
            }
        }
    }
}
