using System;
using System.Linq;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[] { 2, 4, 6, 8, 10 };
            var num1 = arr1.Length;
            var arr2 = new int[] { 2, 3, 4, 5, 6 };
            var num2 = arr2.Length;

            Console.WriteLine("1 array GCD " + GetGCD(arr1, num1));
            Console.WriteLine("2 array GCD " + GetGCD(arr2, num2));
        }

        private static int GetGCD(int[] numbers, int n)
        {
            var gcd = numbers.First();
            
            for (int i = 1; i < n; i++)
            {
                gcd = GCDByEuclidsAlgorithm(gcd, numbers[i]);
            }

            return gcd;
        }

        private static int GCDByEuclidsAlgorithm(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            return GCDByEuclidsAlgorithm(y, x % y);
        }
    }
}
