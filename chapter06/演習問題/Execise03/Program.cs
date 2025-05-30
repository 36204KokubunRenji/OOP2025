
using System.Security.Cryptography.X509Certificates;

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

        }

        private static void Exercise1(string text) {
             Console.WriteLine("空白数：" + text.IndexOf(" "));
            
        }

        private static void Exercise2(string text) {
            Console.WriteLine(text.Replace("big", "small"));
        }

        private static void Exercise3(string text) {
            
        }

        private static void Exercise4(string text) {
            string[] words = text.Split(' ');
            while (true) {
                int i = 0;
                if (words[i] == null) {
                    Console.WriteLine("単語数：" + i);
                    break;
                }
                i++;
            }
        }
            
            
        

        private static void Exercise5(string text) {
            throw new NotImplementedException();
        }
    }
}
