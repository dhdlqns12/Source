using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace B5_10807
//{
//    class Program
//    {
//        static void Main()
//        {
//            int input_num = int.Parse(Console.ReadLine());
//            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//            int target = int.Parse(Console.ReadLine());

//            Console.WriteLine(arr.Count(x => x == target));
//        }
//    }
//}

//namespace B5_10871
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//            StringBuilder sb = new StringBuilder();

//            for (int i = 0; i < input[0]; i++)
//            {
//                if (arr[i] < input[1])
//                {
//                    sb.Append($"{arr[i]} ");
//                }
//            }

//            Console.WriteLine(sb.ToString());
//        }
//    }
//}

//namespace B3_10818
//{
//    class Program
//    {
//        static void Main()
//        {
//            int input_num = int.Parse(Console.ReadLine());
//            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//            int min = arr.Min();
//            int max = arr.Max();

//            Console.WriteLine($"{min} {max}");
//        }
//    }
//}

//namespace B3_2562
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[] arr= new int[9];

//            int max = 0;
//            int index = 0;

//            for(int i = 0; i<9;i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());

//                if (arr[i]>max)
//                {
//                    max = arr[i];
//                    index = i + 1;
//                }
//            }

//            Console.WriteLine(max);
//            Console.WriteLine(index);
//        }
//    }
//}

//namespace B3_10810
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[] arr_1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//            int n = arr_1[0];
//            int m = arr_1[1];

//            int[] basket = new int[n];

//            StringBuilder sb = new StringBuilder();

//            for (int i = 0; i < m; i++)
//            {
//                int[] arr_2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//                int start = arr_2[0] - 1;
//                int end = arr_2[1] - 1;
//                int ball = arr_2[2];

//                for (int j = start; j <= end; j++)
//                {
//                    basket[j] = ball;
//                }
//            }
//            for(int i = 0; i<n;i++)
//            {
//                sb.Append($"{basket[i]} ");
//            }
//            Console.WriteLine(sb.ToString());
//        }
//    }
//}

