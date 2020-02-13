using System;

namespace Ref_and_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            string message = MakeGreeting(name);
            Console.WriteLine(message);
            /* Both ref and out keywords are used to pass arguments into methods
             * But out is used when the data is passed from the method. So, it is useful to return
             * more than one value from the method
             *While ref is used when the data is passed to the method
             * Therefore, any change made to the parameter inside the method doesn't affect the original value */ 
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            /* out is used here because both the nameLength and fullname variables are
             * initialized by the FullName() method */
            int nameLength = FullName(name, lastName, out string fullname); 
            Console.WriteLine("Your full name is " + fullname + ". It has this many letters: " + nameLength);

            /* ref is used here the Capitalize() method call 
             * and passes the original value to the method */
            Capitalize(ref fullname); 
            Console.WriteLine("Your name in upper case: " + fullname);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static string MakeGreeting(string name)
        {
            return "Hello " + name + "!!";
        }

        /* Both out and ref are used in the methods definition */
        static int FullName(string firstName, string lastName, out string fullName)
        {
            fullName = firstName + " " + lastName;
            return fullName.Length;
        }

        static void Capitalize(ref string fullname)
        {
            fullname = fullname.ToUpper();
        }
    }
}
