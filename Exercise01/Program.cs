
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();

            Exercise2(text);

        }

        private static void Exercise1(string text) {
            var dict = new Dictionary<Char, int>();

            foreach (var c in text.ToUpper()) {
                if ('A' <= c && c <= 'Z') {
                    if (dict.ContainsKey(c))
                        dict[c]++;
                    else
                        dict[c] = 1;
                }
            }
            foreach (var item in dict.OrderBy(x => x.Key)) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }

        }

        private static void Exercise2(string text) {
            var dict = new SortedDictionary<Char, int>();

            foreach (var c in text.ToUpper()) {
                if ('A' <= c && c <= 'Z') {
                    if (dict.ContainsKey(c))
                        dict[c]++;
                    else
                        dict[c] = 1;
                }
            }
            foreach (var item in dict) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
    }
}
