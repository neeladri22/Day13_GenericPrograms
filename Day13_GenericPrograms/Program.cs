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
            Console.WriteLine("Enter three Integer Value");
            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());
            int thirdValue = int.Parse(Console.ReadLine());
            UC1_MaxIntgerNumbers.MaxInteger(firstValue, secondValue, thirdValue);
        }
    }
}
