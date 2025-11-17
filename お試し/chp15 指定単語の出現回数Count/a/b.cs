using System;
using System.Text.RegularExpressions;
using TextFileProcessor;

namespace WordCounter {
    internal class WordCounterProcessor : TextProcessor {
        private int _count = 0;
        private string _targetWord = "";

        protected override void Initialize(string fname) {
            Console.Write("カウントする単語を入力してください: ");
            _targetWord = Console.ReadLine()?.Trim() ?? "";
            _count = 0;
        }

        protected override void Execute(string line) {
            if (string.IsNullOrEmpty(_targetWord)) return;

            // 正規表現で単語の一致をカウント（大文字小文字を無視）
            var matches = Regex.Matches(line, $@"\b{Regex.Escape(_targetWord)}\b", RegexOptions.IgnoreCase);
            _count += matches.Count;
        }

        protected override void Terminate() {
            Console.WriteLine($"\"{_targetWord}\" の出現回数: {_count}回");
        }
    }
}