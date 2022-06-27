using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Refactor1<int> refactorint = new Refactor1<int>();
            int max1 = refactorint.MaxValue(40, 50, 60);
            Console.WriteLine("Maximum value of int is: " + max1);

            Refactor1<double> refactorfloat = new Refactor1<double>();
            double max2 = refactorfloat.MaxValue(10.5, 20.5, 30.5);
            Console.WriteLine("Maximum value of float is: " + max2);

            Refactor1<string> refactorstring = new Refactor1<string>();
            string max3 = refactorstring.MaxValue("neelu", "varsh", "ashok");
            Console.WriteLine("Maximum value of string is: " + max3);
        }
    }
}
