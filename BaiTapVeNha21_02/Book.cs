namespace NSBooks
{
    // Lớp Book implements interface IBook
    public class Book : IBook
    {
        // Các thuộc tính được implement từ interface
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }

        // Biến private để lưu giá trung bình
        private float _averagePrice;
        // Property chỉ set cho giá trung bình
        public float AveragePrice 
        { 
            get { return _averagePrice; }
        }

        // Mảng để lưu trữ danh sách giá, cho phép null
        private int?[] PriceList = new int?[5];

        // Indexer để truy cập và thiết lập giá trong mảng PriceList
        public int? this[int index]
        {
            get
            {
                // Kiểm tra index có hợp lệ không
                if (index >= 0 && index < PriceList.Length)
                    return PriceList[index];
                throw new IndexOutOfRangeException("Index must be between 0 and 4");
            }
            set
            {
                // Kiểm tra index có hợp lệ không
                if (index >= 0 && index < PriceList.Length)
                    PriceList[index] = value;
                else
                    throw new IndexOutOfRangeException("Index must be between 0 and 4");
            }
        }

        // Phương thức tính giá trung bình từ các giá trong PriceList
        public void Calculate()
        {
            // Lấy các giá không null và chuyển thành số
            var validPrices = PriceList.Where(p => p.HasValue).Select(p => p.Value);
            if (validPrices.Any())
                AveragePrice = (float)validPrices.Average();
            else    
                AveragePrice = 0;
        }

        // Phương thức hiển thị thông tin sách
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Publish Date: {PublishDate:dd/MM/yyyy}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine($"Average Price: {_averagePrice}");
            Console.WriteLine();
        }
    }
} 