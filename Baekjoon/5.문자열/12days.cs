using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace B2_1152 //StringSplitOptions.RemoveEmptyEntries사용
//    class Program
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.RemoveEmptyEntries는 빈 문자열만 제거

//            int n = input.Count();

//            Console.WriteLine($"{n} ");
//        }
//    }
//}

//namespace B2_2908 //LinQ Reverse와 ToArray()사용
//{
//    class Program
//    {
//        static void Main() 
//        {
//            string[] num = Console.ReadLine().Split();

//            string num1 = ReverseString(num[0]);
//            string num2 = ReverseString(num[1]);

//            int result = int.Parse(num1);

//            if(result<int.Parse(num2))
//            {
//                result = int.Parse(num2);
//            }
//            Console.WriteLine($"{result}");
//        }

//        static string ReverseString(string s)
//        {
//            return new string(s.Reverse().ToArray()); //ToArray()는 LINQ의 "게으른 실행"을 "즉시 실행"
//        }
//    }
//}