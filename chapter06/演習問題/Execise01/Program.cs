using System.Globalization;

namespace Execise01 {
    internal class Program {
        static void Main(string[] args) {
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            var cultureinfo = new CultureInfo("ja-JP");
            if (String.Compare(str1, str2, cultureinfo, CompareOptions.None) == 0) {
                Console.WriteLine("一致しています");
            } else {
                Console.WriteLine("一致しません");
            }

            }
        }
    }

