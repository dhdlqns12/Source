using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace B5_10950
//{
//    class Program
//    {
//        static void Main()
//        {
//            string count_tc = Console.ReadLine();

//            int count = int.Parse(count_tc);

//            for (int i = 1; i <= count; i++)
//            {
//                string input_num = Console.ReadLine();
//                string[] num = input_num.Split();

//                int a = int.Parse(num[0]);
//                int b = int.Parse(num[1]);

//                Console.WriteLine(a + b);
//            }
//        }
//    }
//}

//namespace B5_8393
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input_num = Console.ReadLine();
//            int num = int.Parse(input_num);
//            int sum = 0;

//            for (int i = 1; i <= num; i++)
//            {
//                sum += i;
//            }

//            Console.WriteLine(sum);
//        }
//    }
//}

//namespace B4_25304
//{
//    class Program
//    {
//        static void Main()
//        {
//            string a = Console.ReadLine();
//            string b = Console.ReadLine();

//            int total_price = int.Parse(a);
//            int buy_type = int.Parse(b);

//            int sum = 0;

//            for (int i = 1; i <= buy_type; i++)
//            {
//                string c = Console.ReadLine();
//                string[] d = c.Split();

//                int price = int.Parse(d[0]);
//                int count = int.Parse(d[1]);

//                sum += (price * count);
//            }

//            if (sum == total_price)
//            {
//                Console.WriteLine("Yes");
//            }
//            else
//            {
//                Console.WriteLine("No");
//            }
//        }
//    }
//}

//namespace B5_25314
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            int a = int.Parse(input);

//            for(int i = 1; (i*4)<=a; i++)
//            {
//                Console.Write("long ");
//            }
//            Console.Write("int");
//        }
//    }
//}

//namespace B4_15552
//{
//    class Program
//    {
//        static void Main()
//        {
//            StringBuilder sb = new StringBuilder();

//            int tc_count = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= tc_count; i++)
//            {
//                string[] input = Console.ReadLine().Split();
//                int a = int.Parse(input[0]);
//                int b = int.Parse(input[1]);

//                sb.AppendLine((a + b).ToString());
//            }
//            Console.Write(sb.ToString());
//        }
//    }
//}

//namespace B5_11021
//{
//    class Program
//    {
//        static void Main()
//        {
//            StreamReader reader = new StreamReader(Console.OpenStandardInput());
//            StringBuilder writer = new StringBuilder();

//            int input = int.Parse(reader.ReadLine());

//            for(int i = 1; i<=input; i++)
//            {
//                string input_num = reader.ReadLine();
//                string[] num = input_num.Split(' ');
//                int a = int.Parse(num[0]);
//                int b = int.Parse(num[1]);

//                writer.AppendLine($"Case #{i}: { a + b}");
//            }
//            Console.Write(writer.ToString());
//        }
//    }
//}
