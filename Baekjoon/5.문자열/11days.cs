using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace B2_10809
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();

//            for (char a = 'a'; a <= 'z'; a++) //IndexOf사용
//            {
//                Console.Write($"{input.IndexOf(a)} ");
//            }
//        }
//    }
//}

//namespace B2_2675
//{
//    class Program
//    {
//        static void Main()
//        {
//            int tc = int.Parse(Console.ReadLine());

//            for (int i = 0; i < tc; i++)
//            {
//                string[] input = Console.ReadLine().Split();

//                int num = int.Parse(input[0]);
//                string s = input[1];

//                StringBuilder sb = new StringBuilder();

//                for (int j = 0; j < s.Length; j++)
//                {

//                    char currentChar = s[j];
//                    string result = new string(currentChar, num);
//                    sb.Append(result);
//                }
//                Console.WriteLine(sb.ToString());
//            }
//        }
//    }
//}
