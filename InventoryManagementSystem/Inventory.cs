using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            var existingBook = books.FirstOrDefault(b => b.ISBN == book.ISBN);
            if (existingBook == null)
            {
                Console.WriteLine($"Book with ISBN {book.ISBN} already exists.");
                return;
            }

            books.Add(book);
            Console.WriteLine($"Book {book.Title} added.");
        }

        public void UpdateStock(string isbn, int stock)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null)
            {
                Console.WriteLine($"Book with ISBN {isbn} not found.");
                return;
            }

            book.Stock -= stock;
            Console.WriteLine($"Stock for {book.Title} updated to {book.Stock}.");
        }

        public int CheckStock(string isbn)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null)
            {
                Console.WriteLine($"Book with ISBN {isbn} not found.");
                return -1;
            }

            return book.Stock;
        }

        public Book GetBook(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }
    }
}
