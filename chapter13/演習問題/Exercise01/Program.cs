
using System.Text.RegularExpressions;

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
            //var groups = Library.Categories.GroupJoin(Library.Books, e => e.Id, f => f.CategoryId, (c, books) => new { Category = c.Name, Books = books });
            //foreach (var group in groups) {
              //  Console.WriteLine($"# {group.Category}");
                //foreach (var book in group.Books) {
                  //  Console.WriteLine($"{book.Title} ({book.PublishedYear}年)");
               // }
            //}
            var groups = Library.Books.GroupBy(book => book.CategoryId)
                .Select(g => new { Category = Library.Categories.FirstOrDefault(h => h.Id == g.Key).Name,Books = g});
              //.Select(g => new { Category = Library.Categories.FirstOrDefault(h => h.Id == g.Key)?.Name ?? "Unknown", Books = g });

            foreach (var group in groups) {
                Console.WriteLine($"# {group.Category}");
                foreach (var book in group.Books) {
                    Console.WriteLine($"{book.Title} ({book.PublishedYear}年)");
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Categories.Where(i => i.Name.Equals("Development"))
                .Join(Library.Books, c => c.Id, b => b.CategoryId, (c, b) => new { b.Title, b.PublishedYear }).GroupBy(x => x.PublishedYear).OrderBy(x => x.Key);
            foreach (var group in groups) {
                Console.WriteLine($"# {group.Key}");
                foreach (var book in group) {
                    Console.WriteLine($"{book.Title}");
                }
            }
        }

        private static void Exercise1_8() {
            var groups = Library.Categories.GroupJoin(Library.Books, c => c.Id, b => b.CategoryId, (c, books) => new { Category = c.Name, Books = books })
                .Where(g => g.Books.Count() >= 4);

            foreach (var group in groups) {
                Console.WriteLine($"# {group.Category} ({group.Books.Count()})");
             
            }
        }
    }
}
