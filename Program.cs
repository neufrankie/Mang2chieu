using System;

namespace MaxElementInMatrixApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập số hàng và số cột của ma trận
            Console.Write("Nhap vao so hang cua ma tran: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so cot cua ma tran: ");
            int columns = int.Parse(Console.ReadLine());

            // Khởi tạo ma trận với số hàng và số cột đã nhập
            double[,] matrix = new double[rows, columns];

            // Nhập giá trị cho từng phần tử của ma trận
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Nhap vao gia tri cua phan tu [{0},{1}]: ", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Tìm phần tử lớn nhất và tọa độ của nó
            double maxElement = matrix[0, 0];
            int maxRow = 0;
            int maxColumn = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        maxRow = i;
                        maxColumn = j;
                    }
                }
            }

            // Hiển thị kết quả
            Console.WriteLine("Phan tu lon nhat cua ma tran la {0} tai vi tri [{1},{2}].", maxElement, maxRow, maxColumn);
        }
    }
}
