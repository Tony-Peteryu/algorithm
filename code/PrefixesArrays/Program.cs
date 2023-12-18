using System;

namespace PrefixesArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NumArray numArray = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
            Console.WriteLine(numArray.SumRange(0, 2));
            Console.WriteLine(numArray.SumRange(2, 5));
            Console.WriteLine(numArray.SumRange(0, 5));
        }
    }
}
