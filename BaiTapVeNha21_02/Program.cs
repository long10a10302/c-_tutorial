using NSBooks;

namespace NSBookTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo từ điển để lưu trữ sách với key là ID
            Dictionary<int, IBook> books = new Dictionary<int, IBook>();
            // Biến để tự động tăng ID
            int nextId = 1;

            // Vòng lặp chính của chương trình
            while (true)
            {
                // Hiển thị menu
                Console.WriteLine("=== Book Management System ===");
                Console.WriteLine("1. Add new book");
                Console.WriteLine("2. Display all books");
                Console.WriteLine("3. Calculate and display average prices");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                // Đọc và xử lý lựa chọn của người dùng
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddNewBook(books, ref nextId);
                            break;
                        case 2:
                            DisplayAllBooks(books);
                            break;
                        case 3:
                            CalculateAndDisplayBooks(books);
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                // Tạm dừng để người dùng đọc kết quả
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Phương thức thêm sách mới
        static void AddNewBook(Dictionary<int, IBook> books, ref int nextId)
        {
            // Tạo instance mới của Book với ID tự động
            Book book = new Book { ID = nextId };

            // Nhập thông tin sách
            Console.Write("Enter book name: ");
            book.Name = Console.ReadLine();

            // Nhập và kiểm tra định dạng ngày
            while (true)
            {
                Console.Write("Enter publish date (dd/MM/yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, 
                    System.Globalization.DateTimeStyles.None, out DateTime publishDate))
                {
                    book.PublishDate = publishDate;
                    break;
                }
                Console.WriteLine("Invalid date format. Please try again.");
            }

            Console.Write("Enter author: ");
            book.Author = Console.ReadLine();

            Console.Write("Enter language: ");
            book.Language = Console.ReadLine();

            // Nhập danh sách giá
            Console.WriteLine("Enter 5 prices (press Enter for null):");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Price {i + 1}: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    book[i] = null;
                else if (int.TryParse(input, out int price))
                    book[i] = price;
                else
                {
                    Console.WriteLine("Invalid price. Setting to null.");
                    book[i] = null;
                }
            }

            // Thêm sách vào từ điển và tăng ID
            books.Add(nextId, book);
            nextId++;
            Console.WriteLine("Book added successfully!");
        }

        // Phương thức hiển thị tất cả sách
        static void DisplayAllBooks(Dictionary<int, IBook> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books to display.");
                return;
            }

            foreach (var book in books.Values)
            {
                book.Display();
            }
        }

        // Phương thức tính toán giá trung bình và hiển thị sách
        static void CalculateAndDisplayBooks(Dictionary<int, IBook> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books to calculate.");
                return;
            }

            foreach (var book in books.Values)
            {
                // Kiểm tra và ép kiểu để gọi phương thức Calculate
                if (book is Book b)
                    b.Calculate();
                book.Display();
            }
        }
    }
} 