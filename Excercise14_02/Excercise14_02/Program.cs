using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise14_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Products product = new Products();

            Console.Write("Nhập tên hàng: ");
            string name = Console.ReadLine();

            Console.Write("Nhập số lượng: ");
            int quantity = int.Parse(Console.ReadLine());

            product.SetDetail(name, quantity);
            product.ShowDetail();

            Console.Write("Nhập số lượng muốn thêm: ");
            int moreQuantity = int.Parse(Console.ReadLine());

            product.AddQuantity(moreQuantity);
            product.ShowDetail();
        }
    }
}
