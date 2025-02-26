namespace BaiTapVeNha21_02_EX2
{
    public class OnlineShopBook
    {
        // Fields
        private Storage BookStorage = new Storage();
        private double profits = 0;

        // Methods
        public void ImportBook()
        {
            Console.Write("\nEnter number of books to import: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEntering details for book {i + 1}:");
                BookStorage.AddANewBook();
            }
        }

        public void ShowDetail()
        {
            Console.WriteLine("\n=== Complete Book Store Details ===");
            for (int i = 0; i < BookStorage.Count; i++)
            {
                BookStorage[i].ShowDetail();
            }
        }

        public void Show()
        {
            Console.WriteLine("\n=== Book Store Catalog ===");
            for (int i = 0; i < BookStorage.Count; i++)
            {
                var book = BookStorage[i];
                Console.WriteLine($"\nID: {book.ID}");
                Console.WriteLine($"Name: {book.Name}");
                Console.WriteLine($"Author: {book.AuthorName}");
                Console.WriteLine($"Subject: {book.Subject}");
                Console.WriteLine($"Selling Price: {book.SellingPrice:C}");
            }
        }

        public void SellABook()
        {
            Show();
            Console.Write("\nEnter book ID to purchase: ");
            string id = Console.ReadLine();

            if (BookStorage.IsBook(id))
            {
                for (int i = 0; i < BookStorage.Count; i++)
                {
                    if (BookStorage[i].ID == id)
                    {
                        profits += BookStorage[i].SellingPrice - BookStorage[i].BuyingPrice;
                        BookStorage.RemoveABook(id);
                        Console.WriteLine("Book sold successfully!");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        public void ChangeSellingPrice()
        {
            ShowDetail();
            Console.Write("\nEnter book ID to change price: ");
            string id = Console.ReadLine();

            if (BookStorage.IsBook(id))
            {
                Console.Write("Enter new selling price: ");
                double newPrice = double.Parse(Console.ReadLine());

                for (int i = 0; i < BookStorage.Count; i++)
                {
                    if (BookStorage[i].ID == id)
                    {
                        BookStorage[i].SetSellingPrice(newPrice);
                        Console.WriteLine("Price updated successfully!");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        public void ShowProfits()
        {
            Console.WriteLine($"\nCurrent profits: {profits:C}");
        }
    }
} 