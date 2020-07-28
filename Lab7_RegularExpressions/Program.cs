using System;
using System.Text.RegularExpressions;

namespace Lab7_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameInput = UserInput("name");

            CheckName(nameInput);

            string emailInput = UserInput("email");

            CheckEmail(emailInput);

            string phoneInput = UserInput("phone number in the format XXX-XXX-XXXX");

            CheckPhoneNumber(phoneInput);

            string birthdayInput = UserInput("birthday in the format (dd/mm/yyy)");

            CheckBirthday(birthdayInput);

            string htmlInput = UserInput("HTML is in the format <xxx></xxx>");

            CheckHTML(htmlInput);

        }

        public static void CheckName(string nameInput)
        {
            if (Regex.IsMatch(nameInput, @"([A-z]{1,29}[\ ][A-z]{1,29})"))
            {
                Console.WriteLine("What a unique name!");
            }
            else
                Console.WriteLine("Boo!");
        }
        public static void CheckEmail(string emailInput)
        { 
            if(Regex.IsMatch(emailInput, @"([\w\d.]{1,29}[\@][\w\d]{5,10}[\.][a-z]{2,3})"))
            {
                Console.WriteLine("Now that's an email I would send a message to");
            }
            else
            {
                Console.WriteLine("What is this? Snail mail?");
            }
        }
        public static void CheckPhoneNumber(string phoneInput)
        {
            if (Regex.IsMatch(phoneInput, @"[\d]{1,3}[\-][\d]{1,3}[\-][\d]{1,4}"))
            {
                Console.WriteLine("Call me maybe.");
            }
            else
            {
                Console.WriteLine("That's not a phone number, ya goof!");
            }

        }
        public static void CheckBirthday(string birthday)
        {
            if (Regex.IsMatch(birthday, @"[\(](([01][1-9])|([1][0-9])|([1][1-9]))[[\/](([2][0-9])|([0-2][1-9])|([3][0-1]))[\/][0-9][0-9][0-9][1-9][\)]"))
            {
                Console.WriteLine("Wow! You're old!");
            }
            else
            {
                Console.WriteLine("Is that how they write dates on your planet?");
            }
        }
        public static void CheckHTML(string html)
        {
            if (Regex.IsMatch(html, @"[\<][\w\d]{1,3}[\>][\<][//][\w\d]{1,3}[\>]"))
            {
                Console.WriteLine("Wow! That's some HTML");
            }
            else
            {
                Console.WriteLine("Maybe write backend code from now on...");
            }


        }
        public static string UserInput(string name)
        {
            Console.WriteLine($"Please enter a {name}");
            string inputName = Console.ReadLine();

            return inputName;
        }
    }
}
