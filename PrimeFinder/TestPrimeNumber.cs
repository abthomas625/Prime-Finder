using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeFinder
{
    public class TestPrimeNumber
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 5)]
        [InlineData(10, 29)]
        [InlineData(13, 41)]
        [InlineData(25, 97)]

        public void TestAll(int input, int expected)
        {
            PrimeNumber pn = new PrimeNumber();

            int actual = pn.GetPrime(input);

            Assert.Equal(expected, actual);
        }
    }
}
