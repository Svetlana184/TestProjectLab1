using ConsoleApp1;

namespace Exp_4
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Password password = new Password();
            password.UserPassword = "d2f9st";
            Assert.IsTrue(password.CheckPassword());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Password password = new Password();
            password.UserPassword = "d21fstz!";
            Assert.IsTrue(password.CheckPassword());
        }
        [TestMethod]
        public void TestNegativeNoNumbers()
        {
            Password password = new Password();
            password.UserPassword = "dstttt!!";
            Assert.IsFalse(password.CheckPassword());
        }
        [TestMethod]
        public void TestNegativeLength()
        {
            Password password = new Password();
            password.UserPassword = "d23t";
            Assert.IsFalse(password.CheckPassword());
        }
    }
}
