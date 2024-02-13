using System;

namespace InventoryManagementSystem
{
    public class Sale
    {
        private Inventory inventory;

        public Sale(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void ProcessSale(string isbn, int quantity)
        {
            var book = inventory.GetBook(isbn);
            if (book == null || book.Stock < quantity || quantity <= 0)
            {
                Console.WriteLine("Sale could not be processed. Book not found or invalid quantity.");
                return;
            }

            book.Stock -= quantity;
            var totalSaleValue = quantity * book.Price;
            Console.WriteLine($"Sale processed for {quantity} copies of {book.Title}. Total value: ${totalSaleValue}.");
        }
    }
}
