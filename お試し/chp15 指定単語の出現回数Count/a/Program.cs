using TextFileProcessor;

namespace WordCounter {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length == 0) {
                Console.WriteLine("ファイル名を指定してください。");
                return;
            }

            TextProcessor.Run<WordCounterProcessor>(args[0]);
        }
    }
}