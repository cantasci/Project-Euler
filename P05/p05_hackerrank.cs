using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler005
{
    class Program
    { 
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SmallestValue(n));
            }
        }

        /// <summary>
        /// Find smallest multiple
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long SmallestValue(int n)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 2; i <= n; i++)
            {
                AppendToContainer(values, i);
            }

            long result = 1;
            foreach (KeyValuePair<int, int> data in values)
            {
                result *= (long)Math.Pow(data.Key, data.Value);
            }

            return result;
        }

        /// <summary>
        /// Increment value if value exists in container, or append to container 
        /// </summary>
        /// <param name="values"></param>
        /// <param name="n"></param>
        static void AppendToContainer(Dictionary<int, int> values, int n)
        {
            foreach (KeyValuePair<int, int> data in values)
            {
                if (n % data.Key == 0)
                {
                    n /= (int) Math.Pow(data.Key, data.Value);
                }
            }

            if (n > 1)
            {
                if (values.ContainsKey(n))
                    values[n] += 1;
                else
                    values.Add(n, 1);
            }

        }
    }
}
