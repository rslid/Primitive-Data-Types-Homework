using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.


namespace BankAccount
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan";
            string midleName = "Ivanov";
            string lastName = "Ivanov";
            decimal balance = 12345670.33m;
            string bank = "First Investment Bank";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            ulong cardOne = 378282246310005;
            ulong cardTwo = 30569309025904;
            ulong cardThree = 5105105105105100;

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Middle name: " + midleName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Available balance: " + balance + " leva");
            Console.WriteLine("Bank: " + bank);
            Console.WriteLine("IBAN: " + iban);
            Console.WriteLine("American Express Credit Card Number: " + cardOne);
            Console.WriteLine("Diners Club Credit Card Number: " + cardTwo);
            Console.WriteLine("MasterCard Credit Card Number: " + cardThree);
        }
    }
}
