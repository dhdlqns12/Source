using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace B5_9498
//{
//   class Program
//    {
//        static void Main()
//        {
//            string score = Console.ReadLine();
//            int n = int.Parse(score);
//            char grade;

//            if (n >= 90 && n <= 100)
//            {
//                grade = 'A';
//            }
//            else if (n >= 80 && n < 90)
//            {
//                grade = 'B';
//            }
//            else if (n >= 70 && n < 80)
//            {
//                grade = 'C';
//            }
//            else if (n >= 60 && n < 70)
//            {
//                grade = 'D';
//            }
//            else
//            {
//                grade = 'F';
//            }

//            Console.WriteLine(grade);
//        }
//    }
//}

//namespace B5_1330
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            string[] num = input.Split();
//            int a = int.Parse(num[0]);
//            int b = int.Parse(num[1]);

//            if(a>b)
//            {
//                Console.WriteLine(">");
//            }
//            else if(a<b)
//            {
//                Console.WriteLine("<");
//            }
//            else if(a==b)
//            {
//                Console.WriteLine("==");
//            }
//        }
//    }
//}

//namespace B5_2739
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            int num = int.Parse(input);

//            for(int n = 1; n<=9; n++)
//            {
//                Console.WriteLine(num+" * "+n+ " = "+ num * n);
//            }
//        }
//    }
//}

//namespace B5_10430
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            string[] num = input.Split();

//            int a = int.Parse(num[0]);
//            int b = int.Parse(num[1]);
//            int c = int.Parse(num[2]);

//            Console.WriteLine((a + b) % c);
//            Console.WriteLine(((a % c) + (b % c)) % c);
//            Console.WriteLine((a * b) % c);
//            Console.WriteLine(((a % c) * (b % c))%c);
//        }
//    }
//}

//namespace B5_10926
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();

//            Console.WriteLine(input + "??!");
//        }
//    }
//}

//namespace B5_18108
//{
//    class Program
//    {
//        static void Main()
//        { 
//            string input = Console.ReadLine();
//            int y = int.Parse(input);

//            int yy = y - 543;

//            Console.WriteLine(yy);
//        }
//    }
//}

//namespace B3_2588
//{
//    class Program
//    {
//        static void Main()
//        {
//            string n = Console.ReadLine();
//            string m = Console.ReadLine();

//            int a = int.Parse(n);
//            int b = int.Parse(m);

//            Console.WriteLine(a * (b % 10));
//            Console.WriteLine(a * ((b % 100) / 10));
//            Console.WriteLine(a * ((b % 1000) / 100));
//            Console.WriteLine(a * b);
//        }
//    }
//}

//namespace B5_11382
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            string[] str = input.Split();

//            double a = double.Parse(str[0]);
//            double b = double.Parse(str[1]);
//            double c = double.Parse(str[2]);

//            double sum = a + b + c;

//            Console.WriteLine(sum);
//        }
//    }
//}

//namespace B5_10171
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("\\    /\\");
//            Console.WriteLine(" )  ( ')");
//            Console.WriteLine("(  /  )");
//            Console.WriteLine(" \\(__)|");
//        }
//    }
//}

//namespace B5_10172
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("|\\_/|");
//            Console.WriteLine("|q p|   /}");
//            Console.WriteLine("( 0 )\"\"\"\\");
//            Console.WriteLine("|\"^\"`    |");
//            Console.WriteLine("||_/=\\\\__|");
//        }
//    }
//}

