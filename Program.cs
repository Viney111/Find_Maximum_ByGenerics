using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Find_Maximum_ByGenerics;

namespace FindMaximumByGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = { 1, 2, 3, 4, 5, 6 };
            float[] arrayOfFloats = { 5, 6, 7, 8, 9 };
            string[] arrayOfStrings = {"a", "b", "c", "d", "e", "f" };

            //Making objects & passing arrays of different forms in the constructor of FindMaxByGeneric Class.
            FindMaxByGeneric<int> findMaxInt = new FindMaxByGeneric<int>(arrayOfIntegers);
            FindMaxByGeneric<float>findMaxDouble = new FindMaxByGeneric<float>(arrayOfFloats);
            FindMaxByGeneric<string>findMaxString = new FindMaxByGeneric<string>(arrayOfStrings);

            //Calling MaxMethod from FindMaxByGeneric Class.
            Console.WriteLine($"Max integer value is {findMaxInt.MaxMethod()}");
            Console.WriteLine($"Max Float value is {findMaxDouble.MaxMethod()}");
            Console.WriteLine($"Maximum string is {findMaxString.MaxMethod()}");
        }
    }
}
