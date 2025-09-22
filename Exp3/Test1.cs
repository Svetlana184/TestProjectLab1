namespace Exp3
{
    [TestClass]
    public class Test1
    {
        static double Square(double x, double y)
        {
            if(x <= 0 || y <= 0) return 0;
            double sq = x * y;
            return Math.Round(sq, 2);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(27, Square(6, 4.5));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(6.82, Square(3.1, 2.2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, Square(-3, -5));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, Square(5, -3));
        }
    }
}
