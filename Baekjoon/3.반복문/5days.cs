using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace B5_11022
//{
//    class Program
//    {
//        static void Main()
//        {
//            StreamReader reader = new StreamReader(Console.OpenStandardInput());
//            StringBuilder sb = new StringBuilder();

//            int input = int.Parse(reader.ReadLine());

//            for (int i = 1; i <= input; i++)
//            {
//                string input_num = reader.ReadLine();
//                string[] num = input_num.Split();
//                int a = int.Parse(num[0]);
//                int b = int.Parse(num[1]);

//                sb.AppendLine($"Case #{i}: {a} + {b} = {a + b}");
//            }
//            Console.WriteLine(sb.ToString());
//        }
//    }
//}

//namespace B5_2438
//{
//    class Program
//    {
//        static void Main()
//        {
//            StreamReader reader = new StreamReader(Console.OpenStandardInput());
//            StringBuilder sb = new StringBuilder();

//            int input = int.Parse(reader.ReadLine());

//            for (int i = 1; i <= input; i++)
//            {
//                sb.AppendLine(new string('*', i));
//            }

//            Console.WriteLine(sb.ToString());
//        }
//    }
//}

//namespace B5_2439
//{
//    class Program
//    {
//        static void Main()
//        {
//            int num = int.Parse(Console.ReadLine());
//            StringBuilder sb = new StringBuilder();

//            for (int i = 1; i <= num; i++)
//            {
//                sb.Append(new string(' ', num - i));
//                sb.AppendLine(new string('*', i));
//            }

//            Console.Write(sb.ToString());
//        }
//    }
//}

//namespace B5_10952
//{
//    class Program
//    {
//        static void Main()
//        {
//            StringBuilder sb = new StringBuilder();
//            for (; ; )
//            {
//                string[] input_num = Console.ReadLine().Split();
//                int a = int.Parse(input_num[0]);
//                int b = int.Parse(input_num[1]);

//                if (a == 0 && b == 0)
//                {
//                    break;
//                }

//                sb.AppendLine($"{a + b}");
//            }

//            Console.Write(sb.ToString());
//        }
//    }
//}

//namespace B5_10951
//{
//    class Program
//    {
//        static void Main()
//        {
//            StringBuilder sb = new StringBuilder();
//            string line;

//            while((line =Console.ReadLine())!=null)
//            {
//                if (line.Trim() == "")
//                    continue;

//                string[] num = line.Split();
//                int a = int.Parse(num[0]);
//                int b = int.Parse(num[1]);

//                sb.AppendLine($"{a + b}");
//            }

//            Console.Write(sb.ToString());
//        }
//    }
//}


