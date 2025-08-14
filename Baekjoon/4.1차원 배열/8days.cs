using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading.Tasks.Dataflow;

//namespace B2_10811
//{
//    class program
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Split();

//            int a = int.Parse(input[0]);
//            int b = int.Parse(input[1]);

//            int[] basket = new int[a];

//            for (int i = 0; i < a; i++)
//            {
//                basket[i] = i + 1;
//            }

//            for (int j = 0; j < b; j++)
//            {
//                string[] num = Console.ReadLine().Split();
//                int start = int.Parse(num[0]) - 1;
//                int end = int.Parse(num[1]) - 1;

//                while (start < end)
//                {
//                    (basket[start], basket[end]) = (basket[end], basket[start]);
//                    start++;
//                    end--;
//                }
//            }

//            Console.WriteLine(string.Join(" ", basket));
//        }
//    }
//}
