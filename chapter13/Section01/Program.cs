﻿namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var groups = Library.Categories.GroupJoin
                (Library.Books, c => c.Id, b => b.PublishedYear, (c, books) => new {Category = c.Name, books = c.Name,Books = books, });
            foreach (var group in groups) {
                Console.WriteLine(group.Category);
                foreach (var book in group.Books) {
                    Console.WriteLine($"  {book.Title} ({book.PublishedYear})年");
                }
            }
         }
    }
}
