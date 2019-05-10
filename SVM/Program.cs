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
            Power p1 = new Power("Loch Ness Monster Summoning", 3.50, "Arcane", "Will summon a very moochy Loch Ness Monster. Beware, sometimes he shows up uninvited.");
            Power p2 = new Power("Laser Gun", 1337, "Physical", "This isn't a super power so much as it's a laser gun. The destruction it causes is super cool though.");
            Power p3 = new Power("Pooping Pennies", 1, "Physical", "In 100 days or so, this one pays for itself!");
            Power p4 = new Power("Reverse Telepathy", .30, "Mental", "Everybody can hear your thoughts. Never tip toe through tulips again!");
            Power p5 = new Power("Time Travel", 300.99, "Physical", "Travel to any time or era you wish.");
            Power p6 = new Power("Elastic Girl/Boy", 75.25, "Physical", "Stretch your limbs,torso and head to indefinite length without any harm to you.");
            Power p7 = new Power("Do Little", 50, "Mental", "Understand and speak to animals.");
            Power p8 = new Power("Shape Shifter", 127.88, "Physical", "Shift into any animal or object at will.");
            Power p9 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p10 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p11 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            Power p12 = new Power("Spider Senses", 98, "Mental", "Spider stuff");
            List<Power> powers = new List<Power>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12 };

            VendingMachine vendor = new VendingMachine(powers, new List<Power> ());
            vendor.WelcomeAction();
            //pv.PayCheck();
            //pv.PayCash();

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
