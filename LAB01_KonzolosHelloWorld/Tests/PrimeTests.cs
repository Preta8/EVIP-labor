using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Numbers;

namespace Tests
{
    public class PrimeTests
    {
        [Fact]
        public void CountPrimeNumbers100Returns1060()
        {   
            var p = new CountPrimeNumbers(100);
            Assert.Equal(1060, p.CalculateSolution());

        }
    }
}
