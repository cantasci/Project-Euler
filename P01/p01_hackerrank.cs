using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine()); 

        for(int i = 0; i < t; i++){
            long n = long.Parse(Console.ReadLine()); 
            long sum = SumValuesByDivisible(n, 3) + SumValuesByDivisible(n, 5) - SumValuesByDivisible(n, 15);
            
            Console.WriteLine(sum);           
        }       
      
    }

    static long SumValuesByDivisible(long number, int dividingNumber) {
        if(dividingNumber == 0 ) return 0;

        long nm = (number-1)/dividingNumber;
        return dividingNumber * nm * (nm+1) / 2;
    }
}