using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
        public class GenericMaximum<T> where T : IComparable
        {
            public T[] value;
            //This method is created for initialize the constructor of instance variables.
            public GenericMaximum(T[] valuee)
            {
                this.value = valuee;
            }
            //This method is created for sorting the values.
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            //This method is created for finding max for given type.
            public T MaxValue(T[] values)
            {
                var Sorted_value = Sort(values);
                return Sorted_value[^1];
            }
            //This method is created calling maxvalue method
            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }
            //Thid method is printing maximum generic value.
            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Max Value is : " + max);
            }
        }
    }

