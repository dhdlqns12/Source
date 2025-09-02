using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

//namespace B3_2566
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[,] board = new int[9, 9];
//            int max = board[0, 0];
//            int row_Index = 1;
//            int col_Index = 1;

//            for (int i = 0; i < 9; i++)
//            {
//                int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//                for (int j = 0; j < 9; j++)
//                {
//                    board[i, j] = row[j];

//                    if (max < board[i, j])
//                    {
//                        max = board[i, j];
//                        row_Index = i + 1;
//                        col_Index = j + 1;
//                    }
//                }
//            }

//            Console.WriteLine($"{max}");
//            Console.Write($"{row_Index} {col_Index}");
//        }
//    }
//}

//namespace B1_10798
//{
//    class Program
//    {
//        static void Main()
//        {
//            char[,] board = new char[5, 15];

//            for (int i = 0; i < 5; i++)
//            {
//                string row = Console.ReadLine();
//                for (int j = 0; j < row.Length; j++)
//                {
//                    board[i, j] = row[j];
//                }
//            }

//            for (int j = 0; j < 15; j++)  
//            {
//                for (int i = 0; i < 5; i++) 
//                {
//                    if (board[i, j] != '\0')
//                    {
//                        Console.Write(board[i, j]);
//                    }
//                }
//            }
//        }
//    }
//}

//namespace S5_2563
//{
//    class Program
//    {
//        static void Main()
//        {
//            int num = int.Parse(Console.ReadLine());

//            bool[,] board = new bool[100, 100];
//            int area = 0;

//            for (int i = 0; i < num; i++)
//            {
//                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//                int x = input[0];
//                int y = input[1];

//                for (int j = x; j <x+10; j++)
//                {
//                    for (int k = y; k < y+10; k++)
//                    {
//                        board[j, k] = true;
//                    }
//                }
//            }

//            for(int i=0;i<100; i++)
//            {
//                for(int j = 0; j<100;j++)
//                {
//                    if (board[i, j])
//                        area++;
//                }
//            }
//            Console.WriteLine($"{area}");
//        }
//    }
//}
