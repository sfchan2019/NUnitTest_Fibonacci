using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EvenFibonacciNumbers;

namespace EvenFibonacciNumbers.Test
{
    [TestFixture()]
    class EvenFibonacciNumbersTest
    {
        FibonacciNumber fn = new FibonacciNumber();

        //[Test()]
        //public void FibNumTest()
        //{
        //    Assert.AreEqual(2, fn.FibNum(3));
        //    Assert.AreEqual(1548008755920, fn.FibNum(60));
        //    Assert.Greater(4000000, fn.FibNum(33));
        //    Assert.Less(4000000, fn.FibNum(34));
        //}

        [Test()]
        public void EvenSumTest()
        {
            Assert.AreNotEqual(2, fn.SumEven(6));
            Assert.AreEqual(44, fn.SumEven(9));
        }
    }
}
