﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMaximum
{
   
        public class MaxGeneric<T> where T : IComparable
        {
            public T[] array_Value;

            public MaxGeneric(T[] array_Value)
            {
                this.array_Value = array_Value;
            }
            public T[] Sort(T[] array_Value)
            {
                Array.Sort(array_Value);
                return array_Value;
            }
            public T array_Max(T[] array_Value)
            {
                var sorted_Value = Sort(array_Value);
                return sorted_Value[^1];
            }
            public T FindMaximum()
            {
                var max = array_Max(array_Value);
                return max;
            }
        public void PrintMax()
        {
            var maximum = array_Max(array_Value);
            Console.WriteLine("Maximum is = " + maximum);
        }
    }
    
}
