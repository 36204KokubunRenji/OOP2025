using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessor
{
    public class WordCountProcessor : TextProcessor
    {
        private string _targetWord;
        private int _count;

        protected override void Initialize(string fname, string targetWord)
        {
            _targetWord = targetWord;
            _count = 0;
        }

        protected override void Execute(string line)
        {
            int index = 0;
            while ((index = line.IndexOf(_targetWord, index)) != -1)
            {
                _count++;
                index += _targetWord.Length;
            }
        }

        protected override void Terminate()
        {
            Console.WriteLine($"「{_targetWord}」の出現回数: {_count}");
        }
    }
}