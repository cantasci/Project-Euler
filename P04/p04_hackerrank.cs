using System;
using System.Collections.Generic;
using System.Linq; 

namespace Euler004
{
    class Program
    { 
        static void Main(String[] args)
        {
            var palindromeNumbers= new Dictionary<long, bool>();
            FindAllNumber(palindromeNumbers);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                foreach (var element in palindromeNumbers.OrderByDescending(x => x.Key))
                {
                    if (element.Key < n)
                    {
                        Console.WriteLine(element.Key);
                        break;
                    }
                }
            }
            
        }

        static void FindAllNumber(Dictionary<long, bool>  history)
        {
            for (long x = 100; x <= 999; x++)
            {
                for (long y = 100; y <= 999; y++)
                {
                    long num = x * y;
                    if (Check(num.ToString()) && !history.ContainsKey(num))
                    {
                        history.Add(num, true);
                    }
                }
            }
        }


        static bool Check(string text)
        {
            if (text.Length != 6) return false;
            for (int i = 0; i <= text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
