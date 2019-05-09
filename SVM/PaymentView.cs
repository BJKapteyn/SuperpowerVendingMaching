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
            string pattern = "^\d\d\d$";
            Regex rgx = new Regex();
            Console.WriteLine("Please enter a check number: ");
            string userInput = Console.ReadLine().Trim();
            Int32.TryParse(userInput, out int checkNumber);
            
            if(checkNumber > 0)               
            {
                ReceiptView.PrintReciept(VendingMachine.PurchasedItems);
            }
            else
            {
                Console.WriteLine("Please enter a valid chack number as a 3 digit integer. Please try again.");
            }

        }

        public void PayCredit()
        {
            ReceiptView.PrintReciept(VendingMachine.PurchasedItems);
        }

        public void PayCash()
        {
            ReceiptView.PrintReciept(VendingMachine.PurchasedItems);
        }
    }
}
