using System;

namespace FindTheMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxInteger MaxNum = new MaxInteger();
            Console.WriteLine(MaxNum.NumberMax(30, 50, 40));
        }
    }
}