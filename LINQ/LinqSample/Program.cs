namespace LinqSample {
    internal class Program {
        static void Main(string[] args) {

            var numbers = Enumerable.Range(1, 100);

            //合計値を出力
            Console.WriteLine(numbers.Sum());
            //平均値を出力
            Console.WriteLine(numbers.Average());

            Console.WriteLine(numbers.Where(n => n % 8 == 0).Sum());
            //Console.WriteLine(numbers.Where(n => n % 8 == 0).Max());

            //foreach (var num in numbers) {
            //    Console.WriteLine(num);
            //}
            

        }
    }
}
