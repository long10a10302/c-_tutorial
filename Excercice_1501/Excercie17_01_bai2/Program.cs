using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercie17_01_bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Chèn phần tử vào mảng");
                Console.WriteLine("2. Xóa phần tử khỏi mảng");
                Console.WriteLine("3. Tính tổng đường chéo chính của ma trận");
                Console.WriteLine("4. Tính tổng các hàng và cột của ma trận");
                Console.WriteLine("5. Vẽ tam giác sao");
                Console.WriteLine("6. So sánh hai mảng");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ChenPhanTu();
                        break;
                    case 2:
                        XoaPhanTu();
                        break;
                    case 3:
                        int[,] matrix = NhapMaTran();
                        TinhTongDuongCheo(matrix);
                        break;
                    case 4:
                        matrix = NhapMaTran();
                        TinhTongHangCot(matrix);
                        break;
                    case 5:
                        VeTamGiacSao();
                        break;
                    case 6:
                        SoSanhMang();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
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
        static void ChenPhanTu()
        {
            int[] arr = NhapMang();
            Console.Write("Nhập phần tử cần chèn: ");
            int value = int.Parse(Console.ReadLine());
            arr = arr.Append(value).ToArray();
            Console.WriteLine("Mảng sau khi chèn: " +string.Join(", ", arr));   
        }

        static void XoaPhanTu()
        {
            int [] arr = NhapMang();
            Console.Write("Nhập vị trí cần xoá: ");
            int index = int.Parse(Console.ReadLine());
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Vị trí không hợp lệ! ");
                return;
            }
            arr = arr.Where((val,idx) => idx != index).ToArray();
            Console.WriteLine("Mảng sau khi xoá: " +string.Join(", ", arr));
        }

        static void VeTamGiacSao()
        {
            Console.Write("Nhập số hàng của tam giác: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        static void SoSanhMang()
        {
            Console.WriteLine("Nhập mảng A:");
            int[] A = NhapMang();
            Console.WriteLine("Nhập mảng B:");
            int[] B = NhapMang();

            int[] common = A.Intersect(B).ToArray();
            int[] onlyInA = A.Except(B).ToArray();
            int[] onlyInB = B.Except(A).ToArray();

            Console.WriteLine("Mảng chứa phần tử chung: " + string.Join(" ", common));
            Console.WriteLine("Mảng chứa phần tử chỉ có trong A: " + string.Join(" ", onlyInA));
            Console.WriteLine("Mảng chứa phần tử chỉ có trong B: " + string.Join(" ", onlyInB));
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
