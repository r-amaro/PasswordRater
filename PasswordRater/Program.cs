using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PasswordRater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the password rater!");

            int score = 0;
            int minLength = 8;
            string digits = "0123456789";
            string specialChars = "#?!@$%&*";

            Console.WriteLine("Enter your password: ");
            string input = Console.ReadLine();

            if (input.Length >= minLength)
            {
                score++;
            }
            if (Program.Contains(input, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
            {
                score++;
            }
            if (Program.Contains(input, "abcdefghijklmnopqrstuvwxyz"))
            {
                score++;
            }
            if (Program.Contains(input, digits))
            {
                score++;
            }
            if (Program.Contains(input, specialChars))
            {
                score++;
            }
            if (input == "password")
            {
                score = 0;
            }
            if (input == "1234")
            {
                score = 0;
            }

            Console.WriteLine($"\nYour Password score is: {score}");

            switch (score)
            {
                case 1:
                    Console.WriteLine("Weak Password");
                    break;
                case 2:
                    Console.WriteLine("Medium Password");
                    break;
                case 3:
                    Console.WriteLine("Strong Password");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Extremely Strong Password");
                    break;
                default:
                    Console.WriteLine("Meets Zero Standards");
                    break;
            }

            Console.ReadLine();
        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

    }
}
