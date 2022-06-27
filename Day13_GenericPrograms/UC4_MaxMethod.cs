using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericPrograms
{
    internal class UC4_MaxMethod
    {
        public static void MaxMethod(int[] arr)
        {
            Console.WriteLine("Sort the array");
            Array.Sort(arr);
            int maxvalue = arr.Length - 1;
            Console.WriteLine("The maximum integer value is: " + arr[maxvalue]);
        }
    }
}
