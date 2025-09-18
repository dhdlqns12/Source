using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace B3_2720
//{
//    class Program
//    {
//        static void Main()
//        {
//            int tc = int.Parse(Console.ReadLine());
//            var result = new List<string>();

//            for (int i = 0; i < tc; i++)
//            {
//                int c = int.Parse(Console.ReadLine());

//                int q = c / 25;
//                c %= 25;

//                int d = c / 10;
//                c %= 10;

//                int n = c / 5;
//                c %= 5;

//                int p = c;

//                result.Add($"{q} {d} {n} {p}");

//                q = 0;
//                d = 0;
//                n = 0;
//                p = 0;
//            }

//            for (int i = 0; i < tc; i++)
//            {
//                Console.WriteLine($"{result[i]}");
//            }
//        }
//    }
//}

//namespace B3_2903
//{
//    class Program
//    {
//        static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());

//            int result = (int)Math.Pow(2, n);
//            int result2 = (int)Math.Pow((result + 1), 2);

//            Console.WriteLine($"{result2}");
//        }
//    }
//}

//namespace B2_2292
//{
//    class Program
//    {
//        static void Main()
//        {
//            //1층은 1 2층은 7 3층은 19 4층은 37 5층은 61
//            int n = int.Parse(Console.ReadLine());

//            for (int floor =1; ; floor++)
//            {
//                int count = 3 * floor*(floor - 1) + 1;

                
//                if(n<=count)
//                {
//                    n = floor;
//                    Console.WriteLine(n);
//                    break;
//                }
//            }
//        }
//    }
//}
