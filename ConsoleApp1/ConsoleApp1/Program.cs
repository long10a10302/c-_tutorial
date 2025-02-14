using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            while (true)
            {
                Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
                Console.WriteLine("1. Add new Product");
                Console.WriteLine("2. Iterate product list");
                Console.WriteLine("3. Search Product");
                Console.WriteLine("4. Sort products by price");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        shop.AddProduct();
                        break;
                    case 2:
                        shop.IterateProductList();
                        break;
                    case 3:
                        shop.SearchProduct();
                        break;
                    case 4:
                        shop.SortProduct();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
            }
        }
    }
}
