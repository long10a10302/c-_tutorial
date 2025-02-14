using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shop
    {
        private List<Product> productList = new List<Product>();
        public void AddProduct()
        {
            Product newProduct = new Product();
            Console.Write("Enter product name: ");
            newProduct.Name = Console.ReadLine();
            Console.Write("Enter product description: ");
            newProduct.Description = Console.ReadLine();
            Console.Write("Enter product price (0 < Price <= 100): ");
            newProduct.Price = double.Parse(Console.ReadLine());
            productList.Add(newProduct);
            Console.WriteLine("Product added successfully");

        }

        public void IterateProductList()
        {
            foreach (var product in productList)
            {
                product.ViewInfo();
                Console.WriteLine($"Average Rating: {product.AverageRating():F2}");
                Console.WriteLine();
            }
        } 

        public void SearchProduct()
        {
            Console.Write("Enter mininum price: ");
            double minPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter maximum price: ");
            double maxPrice = double.Parse(Console.ReadLine());

            var fillteredProduct = productList.Where(p => p.Price >= minPrice && p.Price <= maxPrice);

            if (!fillteredProduct.Any())
            {
                Console.WriteLine("No product found in this price range");
                return;
            }

            foreach(var product in fillteredProduct)
            {
                product.ViewInfo();
                Console.WriteLine($"Average Rating: {product.AverageRating():F2}");
                Console.WriteLine();
            }
        }
        public void SortProduct()
        {
            productList = productList.OrderBy(p => p.Price).ToList();
            Console.WriteLine("Products sorted by price");
            foreach (var product in productList)
            {
                product.ViewInfo();
                Console.WriteLine($"Average Rating: {product.AverageRating():F2}");
                Console.WriteLine();
            }
        }
    }
}
