using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM
{
    class VendingMachine
    {
        public List<Power> Powers { get; set; }
        public static List<Power> PurchasedItems { get; set; }

        public VendingMachine(List<Power> powers)
        {
            Powers = powers;
        }
        public void WelcomeAction()
        {
            Console.WriteLine("welcome");
            MenuView.DisplayMenu(Powers);
        }

        public double CalculateTotal()
        {
            double total = MenuView.SubTotal *= 1.06;
            MenuView.FinalTotal = total;
            return total;
        }

        public double CalculateSubTotal(int index, int quantity)
        {

            int total = 100;
            MenuView.SubTotal += total;
            return total;
        }

        
    }
}
