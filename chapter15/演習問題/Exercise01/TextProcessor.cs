using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public abstract class TextProcessor {
        // Now the Run method takes an additional argument for the target word
        public static void Run<T>(string fileName, string targetWord) where T : TextProcessor, new() {
            var self = new T();
            self.Process(fileName, targetWord);
        }

        private void Process(string fileName, string targetWord) {
            Initialize(fileName, targetWord);
            var lines = File.ReadLines(fileName);
            foreach (var line in lines) {
                Execute(line);
            }
            Terminate();
        }

        protected virtual void Initialize(string fname, string targetWord) { }
        protected virtual void Execute(string line) { }
        protected virtual void Terminate() { }
    }
}