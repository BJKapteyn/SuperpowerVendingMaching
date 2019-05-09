using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM
{
    class Program
    {
        static void Main(string[] args)
        {
            Power p1 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p2 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p3 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p4 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p5 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p6 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p7 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p8 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p9 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p10 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p11 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p12 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            List<Power> powers = new List<Power>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12 };

            PaymentView pv = new PaymentView();
            //pv.PayCheck();
            //pv.PayCash();
            pv.PayCredit();

            //Console.WriteLine("Welcome\n" +
            //    "Total price of (5) items: 100 bucks" +
            //    "\n\nhere's a list of stuff to buy\n" +
            //    "1 this\n" +
            //    "2 that\n" +
            //    "3 otherthing\n" +
            //    "Select index of item to buy or 'C' to checkout");

        }
    }
}
