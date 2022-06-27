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
            Refactor2<int> refactorint = new Refactor2<int>(30, 40, 50);
            int max1 = refactorint.MaxValueOf(30,40,50);
            Console.WriteLine("Maximum value of int is: " + max1);

            Refactor2<double> refactorfloat = new Refactor2<double>(10.5, 20.5, 30.5);
            double max2 = refactorfloat.MaxValueOf(10.5, 20.5, 30.5);
            Console.WriteLine("Maximum value of float is: " + max2);

            Refactor2<string> refactorstring = new Refactor2<string>("Abhi", "avi", "lol");
            string max3 = refactorstring.MaxValueOf("neelu", "varsha", "ashok");
            Console.WriteLine("Maximum value of string is: " + max3);
        }
    }
}
