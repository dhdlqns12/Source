using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace B2_5622
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            int time = 0;

//            for (int i = 0; i < input.Length; i++)
//            {
//                int index = input[i] - 'A';

//                if (index < 3)
//                    time += 3;
//                else if (index < 6)
//                    time += 4;
//                else if (index < 9)
//                    time += 5;
//                else if (index < 12)
//                    time += 6;
//                else if (index < 15)
//                    time += 7;
//                else if (index < 19)
//                    time += 8;
//                else if (index < 22)
//                    time += 9;
//                else if (index < 26)
//                    time += 10;
//                else
//                    time += 11;
//            }

//            Console.WriteLine($"{time}");
//        }
//    }
//}

//namespace B3_11718
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input;
//            var sb = new StringBuilder();

//            while ((input = Console.ReadLine()) != null)
//            {
//                if (string.IsNullOrWhiteSpace(input))
//                    continue;

//                sb.AppendLine(input);
//            }

//            Console.Write(sb.ToString());
//        }
//    }
//}
