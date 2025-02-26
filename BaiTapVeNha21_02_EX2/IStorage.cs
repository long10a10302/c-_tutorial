namespace BaiTapVeNha21_02_EX2
{
    public interface IStorage
    {
        // Properties
        int Count { get; set; }

        // Indexers
        Book this[int index] { get; set; }

        // Methods
        void AddANewBook();
        void RemoveABook(string id);
        bool IsBook(string id);
    }
} 