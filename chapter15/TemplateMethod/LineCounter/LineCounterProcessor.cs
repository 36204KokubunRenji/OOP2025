using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    internal class LineCounterProcessor : TextProcessor {
        private int _count = 0;
        private string _targetWord;

        // Initialize with target word to count
        public LineCounterProcessor(string targetWord) {
            _targetWord = targetWord;
        }

        protected override void Initialize(string fname) {
            _count = 0;
        }

        protected override void Execute(string line) {
            // Count the occurrences of the target word in the line
            _count += CountOccurrences(line, _targetWord);
        }

        protected override void Terminate() {
            Console.WriteLine($"単語「{_targetWord}」の出現回数: {_count}回");
        }

        // Helper method to count occurrences of a word in a line
        private int CountOccurrences(string line, string word) {
            int count = 0;
            int index = 0;

            while ((index = line.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1) {
                count++;
                index += word.Length;
            }

            return count;
        }
    }
}
