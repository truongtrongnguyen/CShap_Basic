using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_Than_Trieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mang1=new int[10,8];
            bool[,] mang2;
            string[,] mang3;
            int row = mang1.GetLength(0);   //Lấy số hàng của mảng 
            int col = mang1.GetLength(1);   //Lấy số cột của mảng
            Console.WriteLine($"So hang: {row}, So cot: {col}");
            for (int i = 0; i < mang1.GetLength(0); i++)
            {
                for (int j = 0; j < mang1.GetLength(1); j++)
                {
                    Console.Write(mang1[i, j]+" ");
                }
                Console.WriteLine();
            }
             
            //  MẢNG ZIGZAG
            int[][] matrix = new int[10][];
            for(int i=0;i<matrix.Length;i++)
            {
                matrix[i] = new int[i + 1];
            }
            int sohang = matrix.Length;
            int socot_hang1 = matrix[0].Length;
            int socot_hang2 = matrix[1].Length;
            Console.WriteLine($"So hang: {sohang}, So cot: {socot_hang2}");
            for(int i=0;i<matrix.Length;i++)
            {
                for(int j=0;j<matrix[i].Length;j++)
                {
                    Console.Write(matrix[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
