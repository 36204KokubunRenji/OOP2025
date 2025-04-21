namespace ProductSample {
    internal class Program {
        static void Main(String[] args){
            Product karinto = new Product(123, "かりんとう", 180);
            Product konpeitou = new Product(130, "こんぺいとう", 220);

            //税抜き価格を表示
            Console.WriteLine(karinto.Name + "の税抜き価格は" + karinto.Price + "です。");

            //消費税額の表示
            Console.WriteLine(karinto.Name + "の消費税額は" + karinto.GetTax() + "円です。");

            //税込み価格の表示
            Console.WriteLine(karinto.Name + "の税込み価格は" + karinto.GetPriceIncludingTax() + "円です");

            //税抜き価格を表示
            Console.WriteLine(konpeitou.Name + "の税抜き価格は" + konpeitou.Price + "です。");

            //消費税額の表示
            Console.WriteLine(konpeitou.Name + "の消費税額は" + konpeitou.GetTax() + "円です。");

            //税込み価格の表示
            Console.WriteLine(konpeitou.Name + "の税込み価格は" + konpeitou.GetPriceIncludingTax() + "円です");
        }
    }
}