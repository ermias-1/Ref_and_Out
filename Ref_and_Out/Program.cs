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

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            int nameLength = FullName(name, lastName, out string fullname);
            Console.WriteLine("Your full name is " + fullname + ". It has this many letters: " + nameLength);

            Capitalize(ref fullname);
            Console.WriteLine("Your name in upper case: " + fullname);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static string MakeGreeting(string name)
        {
            return "Hello " + name + "!!";
        }

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
