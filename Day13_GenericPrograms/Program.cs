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
            Console.WriteLine("Enter 3 string Values");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            UC3_MaxString.MaxStringValues(first,second,third);
        }
    }
}
