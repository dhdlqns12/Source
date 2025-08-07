using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace B5_2753
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            int year = int.Parse(input);

//            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
//            {
//                Console.WriteLine("1");
//            }
//            else
//                Console.WriteLine("0");
//        }
//    }
//}

//namespace B5_14681
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input_x = Console.ReadLine();
//            string intput_y = Console.ReadLine();

//            int x = int.Parse(input_x);
//            int y = int.Parse(intput_y);

//            if(x>0 && y>0)
//            {
//                Console.WriteLine("1");
//            }
//            else if(x<0 && y>0)
//            {
//                Console.WriteLine("2");
//            }
//            else if (x < 0 && y < 0)
//            {
//                Console.WriteLine("3");
//            }
//            else if(x >0 && y<0)
//            {
//                Console.WriteLine("4");
//            }
//        }
//    }
//}

//namespace B3_2884
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            string[] str = input.Split();

//            int hour = int.Parse(str[0]);
//            int min = int.Parse(str[1]);

//            if (hour != 0 && min < 45)
//            {
//                hour -= 1;
//                min += 60;
//            }
//            else if (hour == 0 && min < 45)
//            {
//                hour = 23;
//                min += 60;
//            }

//            Console.WriteLine(hour + " " + (min - 45));
//        }
//    }
//}

//namespace B3_2525
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            string input_t = Console.ReadLine();
//            string[] str = input.Split();

//            int hour = int.Parse(str[0]);
//            int min = int.Parse(str[1]);
//            int time = int.Parse(input_t);

//            min += time;
//            hour += min / 60;
//            min %= 60;
//            hour %= 24;

//            Console.WriteLine(hour + " " + min);
//        }
//    }
//}

//namespace B4_2480
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            string[] num = input.Split();

//            int num_1 = int.Parse(num[0]);
//            int num_2 = int.Parse(num[1]);
//            int num_3 = int.Parse(num[2]);

//            int result;

//            if (num_1 == num_2 && num_1 == num_3)
//            {
//                result = 10000 + (num_1 * 1000);
//            }
//            else if (num_1 == num_2 || num_1 == num_3)
//            {
//                result = 1000 + (num_1 * 100);

//            }
//            else if (num_2==num_3)
//            {
//                result = 1000 + (num_2 * 100);
//            }
//            else
//            {
//                int max = Math.Max(num_1, Math.Max(num_2, num_3));
//                result = max * 100;
//            }

//            Console.WriteLine(result);
//        }
//    }
//}
