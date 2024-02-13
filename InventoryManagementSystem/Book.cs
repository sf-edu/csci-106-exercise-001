namespace InventoryManagementSystem
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Book(string isbn, string title, string author, decimal price, int stock)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
            Stock = stock;
        }
    }
}
