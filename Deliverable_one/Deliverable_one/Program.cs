using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            const int maxLength = 12;
            const int minLength = 7;
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasExplanatory = false;

            Console.WriteLine("Please enter a password with the following criteria:");
            Console.WriteLine("At least one lowercase letter");
            Console.WriteLine("At least one uppercase letter");
            Console.WriteLine("At least minimum 7 characters");
            Console.WriteLine("At least a maximum 12 characters");
            Console.WriteLine("Must include one exclamation point(!)");

            password = Console.ReadLine(); // gets password from user


            if ((password.Length >= minLength && password.Length <= maxLength)) // checks max and min length of string inputted by user
            {
                if (password.Contains('!')) // check password contains '!' then,
                    hasExplanatory = true; // hasExplanatory=true

                foreach (char c in password) // read each character from password into 'c'
                {
                    if (char.IsUpper(c)) hasUpperCase = true; // check atleast one character upper then, set hasUpperCase=true
                    else if (char.IsLower(c)) hasLowerCase = true; // check atleast one character lower then, set hasLowerCase=true
                }

            }

            if (hasExplanatory && hasUpperCase && hasLowerCase) // check hasExplanatory and hasUpperCase and hasLowerCase then,
                Console.WriteLine("Password is valid"); // Print password valid
            else
                Console.WriteLine("Password is Not valid..."); // else, password not valid

        }
    }
}
