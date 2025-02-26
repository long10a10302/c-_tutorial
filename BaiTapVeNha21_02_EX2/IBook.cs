namespace BaiTapVeNha21_02_EX2
{
    // Interface định nghĩa các thuộc tính và phương thức cho quản lý sách
    public interface IBook
    {
        // Properties
        string ID { get; }
        string Name { get; }
        string AuthorName { get; }
        string Subject { get; }
        double BuyingPrice { get; }
        double SellingPrice { get; }

        // Methods
        void ShowDetail();
        void SetDetail(string name, string authorname, string subject, double buyingprice);
        void SetSellingPrice(double newSellingPrice);
    }
} 