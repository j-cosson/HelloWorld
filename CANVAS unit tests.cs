using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectApp;

namespace PersonalProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTaxAmount_2()
        {
            TaxCalculator MyCalculator = new TaxCalculator();
           
            double result = MyCalculator.CalculateTax("2", 49.99);

            Assert.AreEqual(3.62, result);
        }

        [TestMethod]
        public void TestTotalAmount_1()
        {
            TaxCalculator MyCalculator = new TaxCalculator();

            double result = MyCalculator.CalculateTax("1", 49.99);

            Assert.AreEqual(2.75, result);
        }

        [TestMethod]

        public void TestTaxAmount_3()
        {
            TaxCalculator MyCalculator = new TaxCalculator();

            double result = MyCalculator.CalculateTax("3", 49.99 );

            Assert.AreEqual(3, result);
        }
    }
}
