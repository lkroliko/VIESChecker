using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VIESCheckerLibrary;

namespace VIESCheckerTest
{
    [TestClass]
    public class UnitTest1
    {
        Company CocaCola = new Company() { CountryCode = "PL", VatNumber= "5260209679" };
        Company Pepsico = new Company() { CountryCode = "GB", VatNumber = "602950069" };
        Company Bad = new Company() { CountryCode = "PL", VatNumber = "9979929949" };

        [TestMethod]
        public void TestIntersnack()
        {
            VIESResponse response1 = VIESChecker.Check(CocaCola);
            Assert.IsTrue(response1.Valid);

            VIESResponse response2 = VIESChecker.Check(CocaCola, Pepsico);
            Assert.IsTrue(response2.Valid);
            Assert.IsFalse(string.IsNullOrEmpty(response2.RequestIdentifier));
        }

        [TestMethod]
        public void TestBad()
        {
            VIESResponse response1 = VIESChecker.Check(Bad);
            Assert.IsFalse(response1.Valid);

            VIESResponse response2 = VIESChecker.Check(Bad, Pepsico);
            Assert.IsFalse(response2.Valid);
        }
    }
}
