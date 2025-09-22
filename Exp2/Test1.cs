namespace Exp2
{
    [TestClass]
    public class Test1
    {
        static int Factorial(int x)
        {
           if(x < 0) return 0;
            
           int fact = 1;
           for (int i = 1; i <= x; i++)
           {
               fact *= i;
           }
           return fact;
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(720, Factorial(6));
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Factorial(1));
        }
        [TestMethod]
        public void TestMethod0()
        {
            Assert.AreEqual(1, Factorial(0));
        }
        [TestMethod]
        public void TestNegative()
        {
            Assert.AreEqual(0, Factorial(-5));
        }
        
    }
}
