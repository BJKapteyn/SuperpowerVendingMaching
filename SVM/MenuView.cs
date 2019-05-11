using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SVM
{
    class MenuView
    {
       
        public static double SubTotal { get; set; }
        public static double FinalTotal { get; set; } = Math.Round(0.00, 2);

        public static void DisplayMenu(List<Power> powers, List<Power> BoughtPower)
        {
            Console.WriteLine($"Total Purchases: {SubTotal}\n");
            for(int i = 0; i < powers.Count; i++)
            {
                Console.WriteLine($"Power {i+1}: {powers[i].Name}");
            }

            int choice;
            Console.WriteLine("Please select:");
            Console.WriteLine("1) Buy" +
                "\n2) Checkout");
            Validator.IsInRangeIndex(Console.ReadLine(), 1, 2, out choice);
            if(choice == 0)
            {
                int index;
                Console.WriteLine();
                Console.WriteLine("Select index of the power you'd like.");
                Validator.IsInRangeIndex(Console.ReadLine(), 1, powers.Count, out index);
                PurchaseView.Purchase(powers[index], powers, BoughtPower);
            }
            else if(choice == 1)
            {
                if(BoughtPower.Count == 0)
                {
                    Console.WriteLine("There is nothing in your cart. Any key to return...");
                    Console.ReadKey();
                    Console.Clear();
                    DisplayMenu(powers, BoughtPower);
                }
                else
                {
                    Console.Clear();
                    ReceiptView.PrintCart(BoughtPower, powers);
                }
            }
        }
    }
}
