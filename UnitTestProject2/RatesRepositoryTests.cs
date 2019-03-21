using System;
using _08_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class RatesRepositoryTests
    {
        [TestMethod]
        public void Rates_Repository_CalculateCost_ShouldBeCorrectDecimal()
        {
            RatesRepository _ratesRepo = new RatesRepository();
            Cost cost = Cost.basePremium;

            decimal actual = _ratesRepo.CalculateCost(cost);
            decimal expected = 75m;

            Assert.AreEqual(expected, actual);
        }
    }
}
