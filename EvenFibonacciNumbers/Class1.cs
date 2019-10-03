using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    public class FibonacciNumber
    {
        //    public long FibNum(int n)
        //    {
        //        if (n == 1 || n == 2)
        //        {
        //            return 1;
        //        }
        //        long[] memo = new long[n + 1];
        //        memo[1] = 1;
        //        memo[2] = 1;
        //        for (int i = 3; i <= n; i++)
        //        {
        //            memo[i] = memo[i - 1] + memo[i - 2];
        //        }
        //        return memo[n];
        //    }

        public long SumEven(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            long sum = 0;
            long[] memo = new long[n + 1];
            memo[1] = 1;
            memo[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
                if((i) % 3 == 0)
                sum += memo[i];
            }
            return sum;
        }
    }
}
