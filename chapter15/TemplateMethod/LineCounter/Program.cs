using System;
using TextFileProcessor;

namespace LineCounter {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length < 2) {
                Console.WriteLine("使用方法: Program <ファイル名> <カウントする単語>");
                return;
            }

            string fileName = args[0];
            string targetWord = args[1];

            // Run the processor with the specified target word
            TextProcessor.Run<LineCounterProcessor>(fileName, targetWord);
        }
    }
}
