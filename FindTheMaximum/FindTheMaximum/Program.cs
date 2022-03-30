using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace FindTheMaximum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 25, 75, 26, 88, 196, 111, 18, };
            float[] floatArray = { 95.5f, 75.46f, 46.32f, 25.95f, 111.21f };
            string[] stringArray = { "Apple", "Peach", "Banana", "Remant", "Vivek", "Aman" };

            MaxGeneric<int> intValue = new MaxGeneric<int>(intArray);
            intValue.PrintMax();
            MaxGeneric<float> floatValue = new MaxGeneric<float>(floatArray);
            floatValue.PrintMax();
            MaxGeneric<string> strValue = new MaxGeneric<string>(stringArray);
            strValue.PrintMax();
        }


    }
}