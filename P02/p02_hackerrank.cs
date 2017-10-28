using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(SumEvenFib((ulong)n));
        }
    }
    
      static ulong SumEvenFib(ulong n)
        {
            ulong sum = 0, prevNumber=0, currentNumber=1, nextNumber=0;
            while (currentNumber < n)
            {
                nextNumber = prevNumber + currentNumber;
                prevNumber = currentNumber;
                currentNumber = nextNumber;
                if (prevNumber % 2 == 0)
                {
                    sum += prevNumber;
                }
            }
            return sum;
        }
}
