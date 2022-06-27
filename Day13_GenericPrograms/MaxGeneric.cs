using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericPrograms
{
    internal class MaxGeneric<T> where T : IComparable
    {
        public T[] value;

        public MaxGeneric(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sortValue = Sort(values);
            var maxIndex = sortValue.Length - 1;
            var maxSortValue = sortValue[maxIndex];
            return maxSortValue;
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("The maximum is: " + max);
        }
    }
}

