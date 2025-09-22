using System.Diagnostics.Tracing;
using ConsoleApp1;

namespace exp5
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> input = new List<string>() { "word", "world", "and", "library", "hello" };
            List<string> output = new List<string>() { "word", "and", "hello" };
            WordList wordList = new WordList(input);
            int count = wordList.DeleteWords(4);
            CollectionAssert.AreEqual(output, wordList.wordList);
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<string> input = new List<string>() { "word", "world", "and", "library", "hello" };
            List<string> output = new List<string>() { "word", "world", "and", "library", "hello" };
            WordList wordList = new WordList(input);
            int count = wordList.DeleteWords(7);
            CollectionAssert.AreEqual(output, wordList.wordList);
            Assert.AreEqual(0, count);
        }
        [TestMethod]
        public void TestMethod3()
        {
            List<string> input = new List<string>() { "word", "world", "library", "hello" };
            List<string> output = new List<string>();
            WordList wordList = new WordList(input);
            int count = wordList.DeleteWords(3);
            //CollectionAssert.AreEqual(output, wordList.wordList);
            Assert.AreEqual(0, count);
        }
    }
}
