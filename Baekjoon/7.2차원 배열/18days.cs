using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace B3_2738
//{
//    class Program
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Split();
//            int n = int.Parse(input[0]);
//            int m = int.Parse(input[1]);

//            int[,] matrixA = new int[n, m];
//            int[,] matrixB = new int[n, m];

//            for (int i = 0; i < n; i++)
//            {
//                string[] row = Console.ReadLine().Split();
//                for (int j = 0; j < m; j++)
//                {
//                    matrixA[i, j] = int.Parse(row[j]);
//                }
//            }

//            for (int i = 0; i < n; i++)
//            {
//                string[] row = Console.ReadLine().Split();
//                for (int j = 0; j < m; j++)
//                {
//                    matrixB[i, j] = int.Parse(row[j]);
//                }
//            }

//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < m; j++)
//                {
//                    Console.Write(matrixA[i, j] + matrixB[i, j]);
//                    if (j < m - 1) Console.Write(" ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
