using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WordList
    {
        public List<string> wordList {  get; set; }

        public WordList(List<string> wordList)
        {
            this.wordList = wordList;
        }
        public int DeleteWords(int maxLen)
        {
            int count = 0;
            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i].Length > maxLen)
                {
                    count++;
                    wordList.Remove(wordList[i]);
                }
            }
            return count;
        }
    }
}
