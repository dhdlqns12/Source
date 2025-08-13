using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace B2_10813
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//            int n = arr[0];
//            int m = arr[1];

//            int[] basket = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                basket[i] = i + 1;
//            }

//            StringBuilder sb = new StringBuilder();

//            for (int i = 0; i < m; i++)
//            {
//                int[] swap = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

//                int a = swap[0]-1;
//                int b = swap[1]-1;

//                (basket[a], basket[b]) = (basket[b], basket[a]); //튜플 사용
//            }

//            for(int i = 0; i<n;i++)
//            {
//                sb.Append($"{basket[i]} ");
//            }

//            sb.Length--;
//            Console.WriteLine(sb.ToString());
//        }
//    }
//}

//namespace B3_5597 //Enumerable.Range, Linq사용
//{
//    class program
//    {
//        static void Main()
//        {
//            int student = 28;

//            int[] arr = new int[student];

//            for(int i = 0; i<student;i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            var not = Enumerable.Range(1, 30).Except(arr).OrderBy(x=>x);

//            foreach(int studentNum in not)
//            {
//                Console.WriteLine(studentNum);
//            }
//        }

//    }
//}

namespace B2_3052 //HashSet이용
{
    class Program
    {
        static void Main()
        {
            int[] num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine())%42;
            }
            HashSet<int> hs = new HashSet<int>(num);

            Console.WriteLine(hs.Count);
        }
    }
}
