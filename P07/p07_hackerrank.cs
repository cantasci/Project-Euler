using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler007
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            var inputs = new List<int>();
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                inputs.Add(n);
            }

            var max = inputs.Max();
            var primes = new Dictionary<int, int>(){ {1,2}};
            FindPrimes(primes, max);
            for (int i = 0; i < inputs.Count; i++)
            {
                Console.WriteLine(primes[inputs[i]]);
            } 
        }

        /// <summary>
        /// Find prime number until reach to max index
        /// </summary>
        /// <param name="primes"></param>
        /// <param name="max"></param>
        static void FindPrimes(Dictionary<int, int> primes, int max)
        { 
            var primePoint = 3;
            while (primes.Count < max)
            {
                if (IsPrime(primePoint))
                {
                    primes.Add(primes.Count+1, primePoint);
                }
                primePoint += 2;
            }
        }


        /// <summary>
        /// Check that number is prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool IsPrime(int number)
        { 
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
