using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMaximum
{
    internal class MaxString
    {
        public string largeString(string Str_1, string Str_2, string Str_3)
        {
            Console.WriteLine("Three Strings are String1 = " + Str_1 + " String2 = " + Str_2 + " String3 = " + Str_3);
            if (Str_1.CompareTo(Str_2) > 0 && Str_1.CompareTo(Str_3) > 0)
            {
                Console.Write("Max String = ");
                return Str_1;
            }
            else if (Str_2.CompareTo(Str_1) > 0 && Str_2.CompareTo(Str_3) > 0)
            {
                Console.Write("Max String = ");
                return Str_2;
            }
            else if (Str_3.CompareTo(Str_1) > 0 && Str_3.CompareTo(Str_2) > 0)
            {
                Console.WriteLine("Max String = ");
                return Str_3;
            }
            else
            {
                Console.WriteLine("all string are equal");
            }
            return null;
        }


    }
}