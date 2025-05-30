using section01;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks();

            //本の平均金額
            Console.WriteLine((int)books.Average(b => b.Price));
            //本のページ合計
            Console.WriteLine(books.Sum(b => b.Pages));
            //金額の安い書籍名と金額
            //Console.Write(books.MinBy(p => p.Price).Title);
            //Console.WriteLine(books.Min(p => p.Price));
            var book = books.Where(x => x.Price == books.Min(b => b.Price)).First();
            foreach (var item in books) {
                Console.WriteLine(book.Title + ":" + book.Price);
            }
            //ページが多い書籍名とページ数を表示
            //Console.Write(books.MaxBy(p => p.Pages).Title);
            //Console.WriteLine(books.Max(p =>  p.Pages));
            var maxpage = books.Where(x => x.Pages == books.Max(b => b.Pages)).First();
            foreach (var item in books) {
                Console.WriteLine(book.Title + ":" + book.Pages);
            }
            //タイトルに「物語」が含まれている書籍名をすべて表示
            var title = books.Where(x => x.Title.Contains("物語"));
            foreach (var item in title) {
                Console.WriteLine(item.Title);
            }
        }
        
    }
}
