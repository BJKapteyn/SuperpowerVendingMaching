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
        public static double FinalTotal { get; set; } = 0;

        public static void DisplayMenu(List<Power> powers)
        {
            //display list of powers
            //if user chooses to buy 
                //ask how many
                //calculate and add to total
                //  VendingMachine.CalculateSubTotal(int index, int quantity)
                //  Continue - this.DisplayMenu(powers)
                //  Checkout
                //back to main menu
            //if user chooses checkout
                //
        }
    }
}
