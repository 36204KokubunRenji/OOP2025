using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise01 {
    public class Processor : TextProcessor {
        protected override void Execute(string line) {
            string converted = ConvertZenkakuDigitsToHankaku(line);
            Console.WriteLine(converted);
        }

        private string ConvertZenkakuDigitsToHankaku(string input) {
            char[] result = input.Select(c =>
                (c >= '０' && c <= '９') ? (char)(c - '０' + '0') : c
            ).ToArray();
            return new string(result);
        }
    }
}