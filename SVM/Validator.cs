using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM
{
    public class Validator
    {
        public static bool YayOrNay(string YN)
        {
            if (YN == "Y")
            {
                return true;
            }
            else if (YN == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter Y or N");
                YayOrNay(Console.ReadLine().ToUpper());
            }
            return false;
        }
        int x;
        public static void IsInRangeIndex(string choice, int minVal, int maxVal, out int x)
        {
            int num;
            try
            {
                num = Convert.ToInt32(choice);
                if (num >= minVal && num <= maxVal)
                {
                    x = num - 1;
                    return;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Please enter a number {minVal}-{maxVal}.");
                x = 0;
                IsInRangeIndex(Console.ReadLine(), minVal, maxVal, out x);
            }
        }

        public static void DoubleInput(string dub, out double var)
        {
            try
            {
                if (Convert.ToDouble(dub) >= 0)
                {
                    var = Convert.ToDouble(dub);
                    return;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a positive number.");
                DoubleInput(Console.ReadLine(), out var);
            }
        }
    }
}
