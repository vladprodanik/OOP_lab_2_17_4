using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 0, -7, 8, -3 };
            int result = OOP_lab_2_17_4.Program.CountHigherThanFive(a);
            Assert.AreEqual(2, result);
        }
        public void TestMethod2()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 0, -7, 8, -3 };
            int result = OOP_lab_2_17_4.Program.SumAfterHighest(a);
            Assert.AreEqual(-3, result);
        }
    }
}
