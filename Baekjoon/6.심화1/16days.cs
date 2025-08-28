using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace B1_1157
//{
//    class Program
//    {
//        static void Main()
//        {
//            bool b = false;
//            string input = Console.ReadLine().ToUpper();

//            int[] count = new int[26];

//            foreach(char c in input)
//            {
//                count[c - 'A']++;
//            }

//            int max = 0;
//            int maxIndex = -1;

//            for(int i = 0;i<26;i++)
//            {
//                if (count[i]>max)
//                {
//                    max = count[i];
//                    maxIndex = i;
//                    b = false;
//                }
//                else if (count[i]==max)
//                {
//                    b = true;
//                }
//            }

//            if (!b)
//            {
//                Console.WriteLine((char)('A' + maxIndex));
//            }
//            else if(b)
//            {
//                Console.WriteLine($"?");
//            }
//        }
//    }
//}

//namespace S5_2941 //HashSet<T>와 Dictionary<Tkey,TValue>의 차이는  HashSet은 이값이 존재하는가? 체크용,Dictionary는 이 키에 해당하는 값은 무엇인가? 검색용
//{
//    class Program
//    {

//        static void Main()
//        {
//            string input = Console.ReadLine();

//            CharConverter(input);
//        }

//        static void CharConverter(string s)
//        {
//            int count = 0;

//            Dictionary<int, HashSet<string>> words = new Dictionary<int, HashSet<string>>
//            {
//                {2, new HashSet<string> { "c=","c-","d-","lj","nj","s=","z="} },//딕셔너리의 키를 지정(변환되는 문자 길이),HashSet에는 해당길이의 크로아티아 문자들,HashSet이 각 길이별로 이 문자집합이 존재하는가? 빠르게 체크
//                {3, new HashSet<string> {"dz="} }
//            };

//            for (int i = 0; i < s.Length; i++)
//            {
//                bool found = false;
//                for (int j = 3; j >= 2; j--)
//                {
//                    if (i <= s.Length - j && words[j].Contains(s.Substring(i, j)))
//                    {
//                        count++;
//                        i += j - 1;
//                        found = true;
//                        break;
//                    }
//                }
//                if (!found)
//                    count++;
//            }
//            Console.WriteLine($"{count}");
//        }
//    }
//}

