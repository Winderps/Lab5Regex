using System;
using System.Net;
using System.Text.RegularExpressions;

namespace RegexLab
{
    class Program
    {
        static string nameRegex = @"^[A-Z]{1}[a-z]{0,30}$";
        static string emailRegex = @"^[a-zA-Z0-9]{5,30}\@[a-zA-Z]{5,10}\.[a-z]{2,3}$";
        static string phoneRegex = @"^\d{3}-\d{3}-\d{4}$";
        static string dateRegex = @"^\d{2}\/\d{2}\/\d{4}$";
        static void Main(string[] args)
        {
            Console.Title = "User Data Validation Tool";
            Console.WriteLine("Welcome to the User Data Validation Tool!");

            do
            {
                bool validInput = false;
                while (!validInput)
                {
                    string input = GetUserInput("Please enter your name: ");
                    validInput = ValidName(input);
                    if (!validInput)
                    {
                        Console.WriteLine("That doesn't look like a name to me!");
                    }
                }

                validInput = false;
                while (!validInput)
                {
                    string input = GetUserInput("Please enter your email: ");
                    validInput = ValidEmail(input);
                    if (!validInput)
                    {
                        Console.WriteLine("That doesn't look like an email to me!");
                    }
                }

                validInput = false;
                while (!validInput)
                {
                    string input = GetUserInput("Please enter your phone number: ");
                    validInput = ValidPhone(input);
                    if (!validInput)
                    {
                        Console.WriteLine("That doesn't look like a phone number to me!");
                    }
                }

                validInput = false;
                while (!validInput)
                {
                    string input = GetUserInput("Please enter your birthday: ");
                    validInput = ValidDate(input);
                    if (!validInput)
                    {
                        Console.WriteLine("That doesn't look like a date to me!");
                    }
                }

                Console.Write("Enter y(es) to continue or anything else to exit: ");
            } while (Console.ReadLine().ToLower().StartsWith('y'));
        }
        static string GetUserInput(string prompt)
        {
            string ret = "";
            while (ret.Equals(""))
            {
                Console.Write(prompt);
                ret = Console.ReadLine();

                if (ret.Equals(""))
                {
                    Console.WriteLine("Input cannot be empty! Please try again.");
                }
            }

            return ret;
        }
        static bool ValidName(string input)
        {
            return Regex.IsMatch(input, nameRegex);
        }
        static bool ValidEmail(string input)
        {
            return Regex.IsMatch(input, emailRegex);
        }
        static bool ValidPhone(string input)
        {
            return Regex.IsMatch(input, phoneRegex);
        }
        static bool ValidDate(string input)
        {
            return Regex.IsMatch(input, dateRegex);
        }
    }
}