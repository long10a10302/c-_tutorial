namespace BaiTapVeNha21_02_EX2
{
    public class Storage : IStorage
    {
        // Fields
        private int _Count = 0;
        private Book[] BookStore = new Book[100]; // Maximum 100 books

        // Constructor
        public Storage()
        {
            Count = 0;
            BookStore = new Book[100];
        }

        // IStorage Members Implementation
        public Book this[int index]
        {
            get { return BookStore[index]; }
            set { BookStore[index] = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public void AddANewBook()
        {
            if (_Count >= 100)
            {
                Console.WriteLine("BookStore is full!");
                return;
            }

            Console.WriteLine("\nEnter book details:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Subject: ");
            string subject = Console.ReadLine();
            Console.Write("Buying Price: ");
            double buyingPrice = double.Parse(Console.ReadLine());

            Book newBook = new Book();
            newBook.SetDetail(name, author, subject, buyingPrice);
            BookStore[_Count] = newBook;
            _Count++;
        }

        public void RemoveABook(string id)
        {
            for (int i = 0; i < _Count; i++)
            {
                if (BookStore[i].ID == id)
                {
                    // Shift remaining books left
                    for (int j = i; j < _Count - 1; j++)
                    {
                        BookStore[j] = BookStore[j + 1];
                    }
                    BookStore[_Count - 1] = null;
                    _Count--;
                    Console.WriteLine($"Book with ID {id} has been removed.");
                    return;
                }
            }
            Console.WriteLine($"Book with ID {id} not found.");
        }

        public bool IsBook(string id)
        {
            for (int i = 0; i < _Count; i++)
            {
                if (BookStore[i].ID == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
} 