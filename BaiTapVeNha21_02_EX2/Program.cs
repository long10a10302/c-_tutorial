using NSBooks;

namespace BaiTapVeNha21_02_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineShopBook BookShop = new OnlineShopBook();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Main Menu ===");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AdminMenu(BookShop);
                        break;
                    case "2":
                        CustomerMenu(BookShop);
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AdminMenu(OnlineShopBook BookShop)
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\n=== Admin Menu ===");
                Console.WriteLine("1. Import book to the store");
                Console.WriteLine("2. Show the store in detail");
                Console.WriteLine("3. Change a book selling price");
                Console.WriteLine("4. Show profits");
                Console.WriteLine("5. Back");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BookShop.ImportBook();
                        break;
                    case "2":
                        BookShop.ShowDetail();
                        break;
                    case "3":
                        BookShop.ChangeSellingPrice();
                        break;
                    case "4":
                        BookShop.ShowProfits();
                        break;
                    case "5":
                        back = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void CustomerMenu(OnlineShopBook BookShop)
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\n=== Customer Menu ===");
                Console.WriteLine("1. Show all books of store");
                Console.WriteLine("2. Buy a book");
                Console.WriteLine("3. Back");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BookShop.Show();
                        break;
                    case "2":
                        BookShop.SellABook();
                        break;
                    case "3":
                        back = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }

    public class BookManager
    {
        private readonly Dictionary<int, IBook> _books = new();
        private int _nextId = 1;

        public void Run()
        {
            while (true)
            {
                DisplayMenu();
                if (ProcessMenuChoice())
                    break;
            }
        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Book Management System ===");
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Display all books");
            Console.WriteLine("3. Calculate and display average prices");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice: ");
        }

        private bool ProcessMenuChoice()
        {
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                ShowError("Invalid input. Please enter a number.");
                return false;
            }

            switch (choice)
            {
                case 1:
                    AddNewBook();
                    break;
                case 2:
                    DisplayAllBooks();
                    break;
                case 3:
                    CalculateAndDisplayBooks();
                    break;
                case 4:
                    return true;
                default:
                    ShowError("Invalid choice. Please try again.");
                    break;
            }

            WaitForKey();
            return false;
        }

        private void AddNewBook()
        {
            var book = new Book { ID = _nextId };

            Console.Write("Enter book name: ");
            book.Name = Console.ReadLine() ?? string.Empty;

            while (true)
            {
                Console.Write("Enter publish date (dd/MM/yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime publishDate))
                {
                    book.PublishDate = publishDate;
                    break;
                }
                ShowError("Invalid date format. Please try again.");
            }

            Console.Write("Enter author: ");
            book.Author = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter language: ");
            book.Language = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("\nEnter 5 prices (press Enter for null):");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Price {i + 1}: ");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    book[i] = null;
                else if (int.TryParse(input, out int price))
                    book[i] = price;
                else
                    ShowError($"Invalid price format. Setting price {i + 1} to null.");
            }

            _books.Add(_nextId++, book);
            Console.WriteLine("\nBook added successfully!");
        }

        private void DisplayAllBooks()
        {
            if (!_books.Any())
            {
                ShowError("No books to display.");
                return;
            }

            foreach (var book in _books.Values)
            {
                book.Display();
            }
        }

        private void CalculateAndDisplayBooks()
        {
            if (!_books.Any())
            {
                ShowError("No books to calculate.");
                return;
            }

            foreach (var book in _books.Values)
            {
                if (book is Book b)
                    b.Calculate();
                book.Display();
            }
        }

        private void ShowError(string message)
        {
            Console.WriteLine($"\nError: {message}");
        }

        private void WaitForKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
} 