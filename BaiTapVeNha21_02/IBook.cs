namespace NSBooks
{
    // Interface định nghĩa các thuộc tính và phương thức cần thiết cho một cuốn sách
    public interface IBook
    {
        // Mã định danh duy nhất cho mỗi cuốn sách
        int ID { get; set; }
        
        // Tên sách
        string Name { get; set; }
        
        // Ngày xuất bản
        DateTime PublishDate { get; set; }
        
        // Tác giả
        string Author { get; set; }
        
        // Ngôn ngữ của sách
        string Language { get; set; }
        
        // Giá trung bình (chỉ đọc)
        float AveragePrice { get; }
        
        // Indexer để truy cập danh sách giá
        int? this[int index] { get; set; }
        
        // Phương thức hiển thị thông tin sách
        void Display();
    }
} 