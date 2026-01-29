using System;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("変換したいファイルのパスを入力してください: ");
            string filePath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath)) {
                Console.WriteLine("ファイルが見つかりません。正しいパスを入力してください。");
                return;
            }

            TextProcessor.Run<Processor>(filePath, null);
            Console.WriteLine("CurrentDirectory: " + Environment.CurrentDirectory);

        }
    }
}