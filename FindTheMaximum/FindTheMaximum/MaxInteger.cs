using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMaximum
{
    internal class MaxInteger
    {
        public int NumberMax(int Num_1, int Num_2, int Num_3)
        {
            Console.WriteLine("Three numbers are Numer1 = " +Num_1 +" Number2 = " +Num_2+ " Number3 = " +Num_3);

            if (Num_1.CompareTo(Num_2) > 0 && Num_1.CompareTo(Num_3) > 0)
            {
                Console.Write("Max = ");
                return Num_3;
            }
            else if (Num_2.CompareTo(Num_3) > 0 && Num_2.CompareTo(Num_1) > 0)
            {
                Console.Write("Max = ");
                return Num_2;
            }
            else if (Num_3.CompareTo(Num_1) > 0 && Num_3.CompareTo(Num_2) > 0)
            {
                Console.Write("Max = ");
                return Num_3;
            }
            else
            {
                Console.WriteLine("all numbers are equal");
            }
            return 0;
        }
    }
}