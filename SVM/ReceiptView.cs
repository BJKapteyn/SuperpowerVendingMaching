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
            Console.WriteLine($"\n\n{AddSpaces("Sub Total:")}{MenuView.SubTotal}");
            Console.WriteLine($"\n{AddSpaces("Sales Tax (6%):")}{MenuView.SubTotal * .06}");
            Console.WriteLine($"\n{AddSpaces("Total:")}{MenuView.FinalTotal}");
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
    }
}
