using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            inventory.AddBook(new Book("123456", "C# Programming", "Jane Doe", 29.99m, 10));
            inventory.AddBook(new Book("654321", "Learning .NET", "John Smith", 39.99m, 5));

            inventory.UpdateStock("123456", 5);

            var sale = new Sale(inventory);
            sale.ProcessSale("123456", 3);

            Console.WriteLine($"Stock level for C# Programming: {inventory.CheckStock("123456")}");
        }
    }
}
