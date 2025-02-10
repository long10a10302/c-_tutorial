using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1701
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1. In mảng theo chiều đảo ngược");
                Console.WriteLine("2. Tìm phần tử lớn nhất, nhỏ nhất trong mảng");
                Console.WriteLine("3. Sắp xếp mảng theo thứ tự tăng dần");
                Console.WriteLine("4. Tìm phần tử lớn thứ hai trong mảng");
                Console.WriteLine("5. Tính tổng các phần tử trên đường chéo chính của ma trận");
                Console.WriteLine("6. Tính tổng các hàng, các cột của ma trận");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int[] arr = NhapMang();
                        InMangDaoNguoc(arr);
                        break;
                    case 2:
                        arr = NhapMang();
                        TinhMinMax(arr);
                        break;
                    case 3:
                        arr = NhapMang();
                        SapXepTangDan(arr);
                        break;
                    case 4:
                        arr = NhapMang();
                        TimPhanTuLonThuHai(arr);
                        break;
                    case 5:
                        int[,] matrix = NhapMaTran();
                        TinhTongDuongCheo(matrix);
                        break;
                    case 6:
                        matrix = NhapMaTran();
                        TinhTongHangCot(matrix);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại");
                        break;
                }

            }
        }
        static int[] NhapMang()
        {
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhập các phần tử của mảng: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void InMangDaoNguoc(int[] arr)
        {
            Console.WriteLine("Mảng theo chiều đảo ngược: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + "");
            }
            Console.WriteLine();
        }
        static void TinhMinMax(int[] arr)
        {
            int min = arr[0], max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            Console.WriteLine("Phần tử nhỏ nhất: " + min);
            Console.WriteLine("Phần tử lớn nhất: " + max);
        }
        static void SapXepTangDan(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(", ", arr));
        }

        static void TimPhanTuLonThuHai(int[] arr)
        {
            Array.Sort(arr);
            int max = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                Console.WriteLine("Phần tử lớn thứ hai: " + arr[i]);
                return;
            }
            Console.WriteLine("Không có phần tử thứ hai.");
        }
        static int[,] NhapMaTran()
        {
            Console.Write("Nhập số hàng: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(i + ": ");
                    Console.Write(j + ": ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
        static void TinhTongDuongCheo(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine("Tổng các phần tử trên đường chéo chính: " + sum);
        }

        static void TinhTongHangCot(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j <= matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }
                Console.WriteLine("Tổng hàng: " + i + ": " + rowSum);

            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int colSum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    colSum += matrix[i, j];
                }
                Console.WriteLine("Tổng cột: " + j + ": " + colSum);
            }

        }
    }
}
