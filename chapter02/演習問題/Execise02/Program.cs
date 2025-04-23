using System.Diagnostics.Metrics;

namespace Execise02 {
    internal class Program {
        static void Main(String[] args) {
            Console.WriteLine("1.メートルからインチ");
            Console.WriteLine("2.インチからメートル");
            int app = int.Parse(Console.ReadLine());

            Console.WriteLine("はじめ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("おわり");
            int end = int.Parse(Console.ReadLine());

            if(app == 1) {
                PrintMeterToInchList(start, end);
            } else if(app == 2) {
                PrintInchToMeterList(start, end);
            } else {
                Console.WriteLine("エラー");
            }

                static void PrintInchToMeterList(int start, int end) {
                    for (int inch = start; inch <= end; inch++) {
                        double meter = InchConverter.ToMeter(inch);
                        Console.WriteLine($"{inch}ft = {meter:0.0000}m");
                    }
                }

                static void PrintMeterToInchList(int start, int end) {
                     for (int meter = start; meter <= end; meter++) {
                         double inch = InchConverter.FromMeter(meter);
                         Console.WriteLine($"{meter}ft = {inch:0.0000}m");
                     }
                }
        }
    }
}