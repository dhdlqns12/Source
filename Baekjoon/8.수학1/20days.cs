using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace B2_2745
//{
//    class Program
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Split();
//            string n = input[0];
//            int b = int.Parse(input[1]);

//            long result = 0;

//            for(int i = 0; i < n.Length;i++)
//            {
//                char digit = n[i];
//                int digitValue;

//                if(char.IsDigit(digit))
//                {
//                    digitValue = digit - '0';
//                }
//                else
//                {
//                    digitValue = digit - 'A' + 10;
//                }

//                int position = n.Length - 1 - i;

//                long power=1;
//                for(int j = 0;j<position;j++)
//                {
//                    power *= b;
//                }

//                 result += digitValue * power;
//            }
//            Console.WriteLine(result);
//        }
//    }
//}

//namespace B1_11005
//{
//    class Program
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Split();
//            long n = int.Parse(input[0]);
//            int b = int.Parse(input[1]);
//            string result;

//            result = ConvertDecimal(n, b);
//            Console.WriteLine($"{result}");
//        }

//        static string ConvertDecimal(long decimal_n,int base_b)
//        {
//            if (decimal_n == 0)
//                return "0";

//            StringBuilder result = new StringBuilder();

//            while(decimal_n>0)
//            {
//                long remain = decimal_n % base_b;
//                char digit;

//                if(remain<10)
//                {
//                    digit = (char)('0' + remain);
//                }
//                else
//                {
//                    digit = (char)('A' + remain - 10);
//                }

//                result.Insert(0, digit);

//                decimal_n = decimal_n / base_b;
//            }
//            return result.ToString();
//        }
//    }
//}
