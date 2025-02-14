using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value <= 100)
                    price = value;
                else
                    throw new ArgumentOutOfRangeException("Price must be between 0 and 100.");
            }
        }
        public List<int> Rate { get; set; } = new List<int>();

        public void ViewInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Description: {Description}");
        }

        public double AverageRating()
        {
            return Rate.Count > 0 ? Rate.Average() : 0;
        }
    }
}
