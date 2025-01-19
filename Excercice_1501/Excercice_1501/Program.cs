using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercice_1501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //Bài 1
            String name = PrintNameStudent();
            Console.WriteLine("Tên của sinh viên vừa nhập: " + name);
            //Bài 2
            int n = CheckNumber();
            //Bài 3
            Console.Write("Nhập số nguyên thứ nhất: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số nguyên thứ hai: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập số nguyên thứ ba: ");
            int c = int.Parse((Console.ReadLine()));

            if (CanFormTriangle(a, b, c))
            {
                if(a == b && b == c)
                {
                    Console.WriteLine("Tam giác là tam giác đều");
                }else if(a == b || b == c || a == c)
                {
                    Console.WriteLine("Tam giác là tam giác cân");
                }
                else
                {
                    Console.WriteLine("Tam giác là tam giác thường");
                }
            }
            else
            {
                Console.WriteLine("Ba số nguyên vừa nhập không tạo thành một tam giác"
            }


        }


        static string PrintNameStudent()
        {
            Console.Write("Nhập họ tên của sinh viên: ");
            string name = Console.ReadLine();
            return name;
        }

        static int CheckNumber()
        {
            Console.Write("Nhập số nguyên cần kiểm tra: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Số vừa nhập là số chẵn");
            }
            else
            {
                Console.WriteLine("Số vừa nhập là số lẻ");
            }
            return n;
        }

        static bool CanFormTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
