using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMaximum
{
    public class MaxFloat
    {
        public float FloatNumber(float num_1, float num_2, float num_3)
        {
            Console.WriteLine("Three numbers are Numer1 = " + num_1 + "Number2 =" + num_2 + "Number3 = " + num_3);

            if (num_1.CompareTo(num_2) > 0 && num_1.CompareTo(num_3) > 0)
            {
                Console.Write("Max Float Number = ");
                return num_1;
            }
            else if (num_2.CompareTo(num_1) > 0 && num_2.CompareTo(num_3) > 0)
            {
                Console.Write("Max Float Number = ");
                return num_2;//Console.WriteLine("{0} is Max number ", num2);
            }
            else if (num_3.CompareTo(num_1) > 0 && num_3.CompareTo(num_2) > 0)
            {
                Console.Write("Max Float Number = ");
                return num_3;//Console.WriteLine("{0} is Max number ", num3);
            }
            else
            {
                Console.WriteLine("all are eqaul");
            }
            return 0;
        }

    }
}