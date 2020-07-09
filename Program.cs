using System;
using System.Text.RegularExpressions;

namespace ValidInputRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for Name, Email, Phone Number, and Date, use methods to verify input follows format
            
            NameMethod();
            EmailMethod();
            PhoneMethod();
            DateMethod();

            static void NameMethod()
            {
                Console.Write("Please enter a valid Name: ");
                string inputName = Console.ReadLine();
                Regex checkedName = new Regex(@"([A-Z]{1}[A-Za-z]{2,}).([A-Z]{1}[A-Za-z]{2,27})");
                //First name minumum of 2 characters, then a space then last name minimum 2 character, max 27 (Total of 30 with first name and space)
                //Requirements: Only alphabet, Start with capital, Max Length of 30
                //Observations: Should have a space between first and last

                bool compareName = checkedName.IsMatch(inputName);

                if (compareName)
                {
                    Console.WriteLine("Name is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, name is not valid!");
                }
            }

            static void EmailMethod()
            {
                Console.Write("Please enter a valid email: ");
                string inputEmail = Console.ReadLine();
                Regex checkedEmail = new Regex(@"(.){5,20}@(.){5,10}\.(.){2,3}");
                //Any characters min 5 max 20, at, any characters min 5 max 10, period, any characters min 2 max 3
                //Requirements: Combination of between 5 and 30 alphanumeric [no special] characters, @, Combination of between 5 and 10 alphanumeric [no special] characters, ., combination of two or three alphanumeric characters
                //Observations: None
                bool compareEmail = checkedEmail.IsMatch(inputEmail);

                if (compareEmail)
                {
                    Console.WriteLine("Email is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, email is not valid!");
                }
            }

            static void PhoneMethod()
            {
                Console.Write("Please enter a valid phone number: ");
                string inputPhone = Console.ReadLine();
                Regex checkedPhone = new Regex(@"^(\d){3}\-(\d){3}\-(\d){4}$");
                // \d for digits, {3} group of 3, \- minus, repeat, repeat with 4
                //Requirements: 3 digit Area code –  3 digit prefix – 4 digit suffix
                //Observations: Valid area codes start at 201(through 999), prefix also starts at 201(through 999), suffix can be any
                bool comparePhone = checkedPhone.IsMatch(inputPhone);

                if (comparePhone)
                {
                    Console.WriteLine("Phone is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, phone is not valid!");
                }
            }

            static void DateMethod()
            {
                Console.Write("Please enter a valid date: ");
                string inputDate = Console.ReadLine();

                Regex checkedDate = new Regex(@"(\d){2}\/(\d){2}\/(\d){4}");
                // \d for digits, {2} for day, \/ slash, {2} for month, {4} for year
                //Requirements: dd/mm/yyyy - 2 digit day, 2 digit month, 4 digit year
                //Observations: Day should only be bwteen 01 and 31, month should be between 01 and 12
                bool compareDate = checkedDate.IsMatch(inputDate);

                if (compareDate)
                {
                    Console.WriteLine("Date is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, Date is not valid!");
                }
            }

        }
    }
}
