
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 15;
            int numerator = 20;
            int denominotor = 4;

                int actual = CalcDivide.Calculator.Divide(numerator, denominotor);
            Assert.AreEqual(expected,actual);


        }
    }
    
}
