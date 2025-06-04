﻿
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Execise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
        }

        private static void Exercise1(string text) {
            //Console.WriteLine("空白数：" + text.IndexOf(" "));
            var space = text.Count(c => c == ' ');
            
        }

        private static void Exercise2(string text) {
            Console.WriteLine(text.Replace("big", "small"));
        }

        private static void Exercise3(string text) {
            var array = text.Split(' ');
            var sb = new StringBuilder(array[0]);
            foreach (var word in array.Skip(1)) {
                sb.Append(" ");
                sb.Append(word);
            }
            //末尾はピリオド（.）で終わる
            Console.WriteLine(sb + ".");
        }

        private static void Exercise4(string text) {
            var count = text.Split(' ').Length;
            Console.WriteLine("単語数:{0}", count);
        }
            
            
        

        private static void Exercise5(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in words) ;
            Console.WriteLine(word);
            
        }

        private static void Exercise6(string text) {
            Console.WriteLine(text);
            Console.WriteLine("");
            Console.WriteLine("出現アルファベットの個数");
            var str = text.ToLower().Replace(" ", "");
            var alphDicCOunt = Enumerable.Range('a', 26).ToDictionary(num => ((char)num).ToString(), num => 0);
            foreach (var alph in str) {
                alphDicCOunt[alph.ToString()]++;
            }

            foreach (var item in alphDicCOunt) {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            Console.WriteLine();
            //配列で集計
            var array = Enumerable.Repeat(0, 26).ToArray();

            foreach (var alph in str) {
                array[alph - 'a']++;
            }

            for (char ch = 'a'; ch < 'z'; ch++) {
                Console.WriteLine($"{ch}:{array[ch - 'a']}");
            }

            Console.WriteLine();
            //'a'から順にカウントして出力
            for (char ch = 'a'; ch < 'z'; ch++) {
                Console.WriteLine($"{ch}:{text.Count(tc => tc == ch)}");
            }


        }
    }
}
