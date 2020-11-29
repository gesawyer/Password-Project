using System;
using System.Linq;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine("Hello, please enter a password between 7 and 12 characters long that contains an uppercase letter, a lowercase letter, a number, and an exclamation mark.");

            string userPassword = Console.ReadLine();
            Console.WriteLine();

            //Console.WriteLine("This is a test"+(userPassword));

           
          

            if (userPassword.Any(char.IsUpper) &&

                (userPassword.Any(char.IsLower)) &&

                (userPassword.Contains("!") &&

                (userPassword.Length>=7)) &&

                (userPassword.Length<=12))

                {

                Console.WriteLine("Password valid and accepted.");

                }

            else

                {
                Console.WriteLine("Error.");
                }
            
        }
    }
}
