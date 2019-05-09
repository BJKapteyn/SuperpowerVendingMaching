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
            Console.Write("Please enter a check number: ");
            string userInput = Console.ReadLine().Trim();
            bool isMatch = rgx.IsMatch(userInput);
            
            if(isMatch)               
            {
                Console.WriteLine("Match!"); // test                
                //ReceiptView.PrintReciept(VendingMachine.PurchasedItems); // final case
            }
            else
            {
                Console.WriteLine("Please enter a valid chack number as a 3 digit integer. Please try again.");
                PayCheck();
            }

        }

        public void PayCredit()
        {
            ReceiptView.PrintReciept(VendingMachine.PurchasedItems);
        }

        public void PayCash()
        {
            Console.Write("Please insert cash: ");
            decimal.TryParse(Console.ReadLine(), out decimal cash);

            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits(cash)[3])[2];

            if decimalPlaces
            


            
            //ReceiptView.PrintReciept(VendingMachine.PurchasedItems);
        }
    }
}
