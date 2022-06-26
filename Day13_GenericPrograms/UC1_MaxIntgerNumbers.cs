using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericPrograms
{
    internal class UC1_MaxIntgerNumbers
    {
        public static int MaxInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                    first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                    first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("First integer is maximum value" + first);
                return first;
            }

            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("Second Integer is Maximum value" + second);
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0 ||
                    third.CompareTo(second) >= 0 && third.CompareTo(first) > 0 ||
                    third.CompareTo(second) > 0 && third.CompareTo(first) >= 0)
            {
                Console.WriteLine("Third Integer is maximum value" + third);
                return third;
            }
            if (first.CompareTo(second) == 0 && first.CompareTo(third) == 0 && second.CompareTo(third) == 0)
            {
                Console.WriteLine("All three integers values are equal");
            }
            return first;
        }
    }
}
