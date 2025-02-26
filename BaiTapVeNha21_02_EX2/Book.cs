namespace BaiTapVeNha21_02_EX2
{
    public class Book : IBook
    {
        // Static field để đếm số lượng sách
        private static int _Count = 0;

        // Private fields
        private string _ID;
        private string _Name;
        private string _AuthorName;
        private string _Subject;
        private double _BuyingPrice;
        private double _SellingPrice;

        // Constructor
        public Book()
        {
            _Count++;
            // Tạo ID theo định dạng yêu cầu
            if (_Count < 10)
                _ID = "B00" + _Count;
            else if (_Count < 100)
                _ID = "B0" + _Count;
            else
                _ID = "B" + _Count;
        }

        // Properties implementation
        public string ID => _ID;
        public string Name => _Name;
        public string AuthorName => _AuthorName;
        public string Subject => _Subject;
        public double BuyingPrice => _BuyingPrice;
        public double SellingPrice => _SellingPrice;

        // Methods implementation
        public void ShowDetail()
        {
            Console.WriteLine("\n=== Book Details ===");
            Console.WriteLine($"ID: {_ID}");
            Console.WriteLine($"Name: {_Name}");
            Console.WriteLine($"Author: {_AuthorName}");
            Console.WriteLine($"Subject: {_Subject}");
            Console.WriteLine($"Buying Price: {_BuyingPrice:C}");
            Console.WriteLine($"Selling Price: {_SellingPrice:C}");
        }

        public void SetDetail(string name, string authorname, string subject, double buyingprice)
        {
            _Name = name;
            _AuthorName = authorname;
            _Subject = subject;
            _BuyingPrice = buyingprice;
            // Giá bán mặc định = giá mua + 30%
            _SellingPrice = buyingprice * 1.3;
        }

        public void SetSellingPrice(double newSellingPrice)
        {
            _SellingPrice = newSellingPrice;
        }
    }
} 