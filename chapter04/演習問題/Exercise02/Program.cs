using System;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {




            Exercise1();
            Console.WriteLine("---");
            Exercise2();
            Console.WriteLine("---");
            Exercise3();
        }

        

        private static void Exercise1() {
            var converter = Console.ReadLine();
            if (int.TryParse(converter,out var num)) {
                 if (num > 0) {
                    Console.WriteLine(num);
                }else if (num < 100) {
                    Console.WriteLine(num * 2);
                }else if (num < 500) {
                    Console.WriteLine(num * 3);
                }else if (num >= 500) {
                    Console.WriteLine(num);
                }
            } else {
                Console.WriteLine("入力値に誤りがあります");
            }
            
        }

        private static void Exercise2() {
            var converter = Console.ReadLine();
            if (int.TryParse(converter, out var num)) {
                switch (num) {
                    case > 500:
                        Console.WriteLine(num);
                        break;
                    case > :
                }
            }
        }

        private static void Exercise3() {
            throw new NotImplementedException();
        }
    }
}
