using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessor
{
    class Program
    {
        static void Main()
        {
            Console.Write("テキストファイルのパスを入力してください: ");
            string path = Console.ReadLine();

            Console.Write("検索する単語を入力してください: ");
            string word = Console.ReadLine();

            TextProcessor.Run<WordCountProcessor>(path, word);

        }
    }
}