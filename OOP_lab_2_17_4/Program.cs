using System;

namespace OOP_lab_2_17_4
{
    public class Program
    {
        public static int CountHigherThanFive(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > 5)
                {
                    ++count;
                }
            }

            return count;
        }

        public static int SumAfterHighest(int[] arr)
        {
            int sum = 0;

            int indexOfHighest = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > arr[indexOfHighest])
                {
                    indexOfHighest = i;
                }
            }

            for (int i = indexOfHighest + 1; i < arr.Length; ++i)
            {
                sum += arr[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }

            Console.WriteLine("Kiлькiсть елементiв масиву, бiльших за число п’ять: {0}", CountHigherThanFive(a));
            Console.WriteLine("Cумa елементiв масиву, розташованих пiсля максимального елемента: {0}", SumAfterHighest(a));
        }
    }
}
