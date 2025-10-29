
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            Console.WriteLine(Library.Books.MaxBy(a => a.Price));
        }

        private static void Exercise1_3() {
            //Console.WriteLine("2020:" + Library.Books.Where(a => a.PublishedYear == 2020).Count());
            //Console.WriteLine("2021:" + Library.Books.Where(a => a.PublishedYear == 2021).Count());
            //Console.WriteLine("2022:" + Library.Books.Where(a => a.PublishedYear == 2022).Count());
            //Console.WriteLine("2023:" + Library.Books.Where(a => a.PublishedYear == 2023).Count());

            var results = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(b => b.Key).Select(b => new { PublishedYear = b.Key, Count = b.Count() });
            foreach (var item in results) {
                Console.WriteLine($"{item.PublishedYear} : {item.Count}");
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books.OrderByDescending(c => c.PublishedYear).ThenByDescending(c => c.Price);
            foreach (var item in books) {
                Console.WriteLine($"{item.PublishedYear} : {item.Price} : {item.Title}");
            }
        }

        private static void Exercise1_5() {
            var categoryID = Library.Books.Where(d => d.PublishedYear == 2023).Join(Library.Categories
                , book => book.CategoryId, category => category.Id, (book, category) => category.Name).Distinct();
            foreach (var name in categoryID) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Categories.GroupJoin(Library.Books, e => e.Id, f => f.CategoryId, (c, books) => new { Category = c.Name, Books = books });
            foreach (var group in groups) {
                Console.WriteLine($"# {group.Category}");
                foreach (var book in group.Books) {
                    Console.WriteLine($"{book.Title} ({book.PublishedYear}年)");
                }
            }
        }

        private static void Exercise1_7() {
        
        }

        private static void Exercise1_8() {
            
        }
    }
}
