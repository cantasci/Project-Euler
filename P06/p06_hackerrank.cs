using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler006
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(FindSumSquareDifference(n));
            }

            Console.Read();
        }

        /// <summary>
        /// Find the absolute difference between the sum of the squares of the first n  natural numbers and the square of the sum.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long FindSumSquareDifference(int n)
        {
            long sum = 0l;
            long squareSum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                squareSum += (long)Math.Pow(i, 2);
            }


            return (long)Math.Pow(sum, 2) - squareSum;
        }



    }
}
