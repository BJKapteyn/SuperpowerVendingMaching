using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM
{
    class PurchaseView
    {
        //added list of powers to be able to go back to main menu with the same list
        public static void Purchase(Power power, List<Power> powers)
        {
            Console.Clear();
            Console.WriteLine($"Power name:         {power.Name}" +
                            $"\nCategory:           {power.Category}" +
                            $"\nDescription:        {power.Description}" +
                            $"\nPrice:              {power.Price}");
            Console.WriteLine("\nPlease select an action:" +
                              "\n1) Buy" +
                              "\n2) Main Menu");

            int index = 0;
            Validator.IsInRangeIndex(Console.ReadLine(), 1, 2, out index);
            if (index == 0)
            {
                while (true)
                {
                    Console.WriteLine("How many would you like to buy?" +
                        "\n\nEnter quantity or enter 'M' for main menu:");

                    int quantity = 0;
                    string uChoice = Console.ReadLine().ToUpper();
                    if (uChoice == "M")
                    {
                        MenuView.DisplayMenu(powers);
                        break;
                    }
                    else
                    {
                        if (int.TryParse(uChoice, out quantity))
                        {
                            if (quantity == 0)
                            {
                                Console.WriteLine("Back to Main Menu.");
                                MenuView.DisplayMenu(powers);
                                break;
                            }
                            else if (quantity > 0)
                            {
                                double total = VendingMachine.CalculateSubTotal(quantity, power);
                                Console.WriteLine($"Total purchase comes to {total}. Press any key to return to main menu...");
                                Console.ReadKey();
                                MenuView.DisplayMenu(powers);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a positive whole number");
                                continue;
                            }
                        }
                    }
                }
            }
            else if(index == 1)
            {
                MenuView.DisplayMenu(powers);
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
