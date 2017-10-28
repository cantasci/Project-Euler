using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(MaxPrimeFactor(n));
        }
    }
    
    static long MaxPrimeFactor(long number)
      {
          long maxPrimeFactor = 1L;
          for (long i = 2L; i <= number / i; i++)
          {
              while (number % i == 0)
              {
                  if (i > maxPrimeFactor) maxPrimeFactor = i;
                  number /= i;
              }
          }
          if (number > 1 && number > maxPrimeFactor)
          {
              maxPrimeFactor = number;
          }
          return maxPrimeFactor;
      }
}
