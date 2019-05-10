using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SVM
{
    class PaymentView
    {
        public void PayCheck()
        {
            string pattern = "^\\d{3}$";
            Regex rgx = new Regex(pattern);
            Console.Write($" Your total is: ${MenuView.FinalTotal} Please enter a check number: ");
            string userInput = Console.ReadLine().Trim();
            bool isMatch = rgx.IsMatch(userInput);
            
            if(isMatch)               
            {
                Console.WriteLine("Match!"); // test                
                //ReceiptView.PrintReciept(VendingMachine.PurchasedItems); // final case
            }
            else
            {
                Console.WriteLine($"Your total is: ${MenuView.FinalTotal}Please enter a valid chack number as a 3 digit integer. Please try again.");
                PayCheck();
            }
        }

        public void PayCredit()
        {
            Console.Write($"Your total is: ${MenuView.FinalTotal}.");

            Regex ccNumRgx = new Regex("^\\d{3}$");
            Regex cvvRgx = new Regex("^\\d{3}$");
            Regex expRgx = new Regex(@"^ (0[1 - 9] | 1[0 - 2])$");
            

            bool validCcNum = false;
            bool validCvv = false;
            bool validExp = false;

            while(! validCcNum)
            {
                Console.Write("Please insert your credit card number: ");
                string ccNum = Console.ReadLine();
                bool isMatchCcNum = ccNumRgx.IsMatch(ccNum);

                if (isMatchCcNum)
                {
                    Console.WriteLine("valid ccNum"); //test
                    validCcNum = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Credit card must be 16 digits long and have no spaces.");
                }

            }

            while(! validCvv)
            {
                Console.Write("Please enter your cvv: ");
                string cvv = Console.ReadLine();
                bool isMatchCvv = cvvRgx.IsMatch(cvv);

                if (isMatchCvv)
                {
                    Console.WriteLine("valid cvv"); //test
                    validCvv = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Cvv must be 3 digits long and have no spaces.");
                }
            }

            while (! validExp)
            {
                Console.WriteLine("Please enter your expiration date");
                string exp = Console.ReadLine();
                bool isMatchExp = expRgx.IsMatch(exp);

                if (isMatchExp)
                {
                    Console.WriteLine("valid exp"); //test
                    validExp = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Expiration date must be formatted dd/yy.");
                }
            }
            
            if (validCcNum && validCvv && validExp)
            {
                Console.WriteLine("all fields are valid"); //test
                //ReceiptView.PrintReciept(VendingMachine.PurchasedItems); // final case
            }
        }

        public void PayCash()
        {
            Console.Write("Please insert cash: ");
            decimal.TryParse(Console.ReadLine(), out decimal cash);

            // set number of decimal places in user input to the decimalPlaces 
            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits(cash)[3])[2];

            if(decimalPlaces != 0 && decimalPlaces != 2 || cash == 0)
            {
                Console.WriteLine("Invalid Input. Enter currency formatted as $dd.cc Please try again.");
                PayCash();
            }
            else
            {
                Console.WriteLine("valid input"); //test
                Console.WriteLine($"You paid: ${cash}. The total is {MenuView.FinalTotal}. Here is your change: {cash - (decimal)MenuView.FinalTotal} ");
                //ReceiptView.PrintReciept(VendingMachine.PurchasedItems); // final case
            }
        }
    }
}
