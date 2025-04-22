namespace Execise02 {
    internal class Program {


        //フィートからメールへの対応表を出力
        static void Main(String[] args) {
            for (int inch = 1; inch <= 10; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine($"{inch}ft = {meter:0.0000}m");
            }
        }
    }
}