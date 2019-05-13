using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM
{
    class ReceiptView
    {
        public static void PrintReciept(List<Power> powers)
        {
            Console.WriteLine("Receipt for transaction purchases:\n");
            Console.WriteLine($"{AddSpaces("Item")}Price");
            for (int i = 0; i < powers.Count; i++)
            {
                Console.WriteLine($"\n{AddSpaces(powers[i].Name)}{powers[i].Price}");
            }
            double sub = MenuView.SubTotal;
            double tax = sub * .06;
            Console.WriteLine($"\n\n{AddSpaces("Sub Total: ")}${sub}");
            Console.WriteLine($"\n{AddSpaces("Sales Tax (6%): ")}${Math.Round(tax, 2)}");
            Console.WriteLine($"\n{AddSpaces("Total: ")}${MenuView.FinalTotal}");
        }

        public static string AddSpaces(string input)
        {
            int spaces = 30 - input.Length;
            for (int i = 0; i < spaces; i++)
            {
                input += " ";
            }
            return input;
        }
        public static void PrintCart(List<Power> BoughtPowers, List<Power> MasterList)
        {
            Console.WriteLine("Here is your cart:\n");
            Console.WriteLine($"{AddSpaces("Item")}Price");
            for (int i = 0; i < BoughtPowers.Count; i++)
            {
                Console.WriteLine($"\n{AddSpaces(BoughtPowers[i].Name)} {BoughtPowers[i].Price}");
            }
            double sub = MenuView.SubTotal;
            double tax = sub * .06;
            VendingMachine.CalculateTotal();
            Console.WriteLine($"\n\n{AddSpaces("Sub Total: ")}${sub}");
            Console.WriteLine($"\n{AddSpaces("Sales Tax (6%): ")}${Math.Round(tax, 2)}");
            Console.WriteLine($"\n{AddSpaces("Total: ")}${MenuView.FinalTotal}");
            Console.WriteLine("Any key to Check out");
            Console.ReadKey();
            Console.WriteLine("Please enter Payment:" +
                "\n1) check" +
                "\n2) cash" +
                "\n3) credit");
            int choice = 0;
            Validator.IsInRangeIndex(Console.ReadLine(), 1, 3, out choice);
            switch(choice)
            {
                case 0:
                    PaymentView.PayCheck();
                    break;
                case 1:
                    PaymentView.PayCash();
                    break;
                case 2:
                    PaymentView.PayCredit();
                    break;
                default:
                    Console.WriteLine("Ya blew it");
                    break;
            }



        }
    }
}
