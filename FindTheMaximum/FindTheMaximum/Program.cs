using System;

namespace FindTheMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxInteger MaxNum = new MaxInteger();
            Console.WriteLine(MaxNum.NumberMax(30, 50, 40));
            Console.WriteLine("-------------------------");
            MaxFloat maxfloat = new MaxFloat();
            Console.WriteLine(maxfloat.FloatNumber(80.8f, 44.6f, 60.1f));
            Console.WriteLine("-------------------------");

            MaxString maxString = new MaxString();
            Console.WriteLine(maxString.largeString("Apple", "Peach", "Banana"));
        }
    }
}