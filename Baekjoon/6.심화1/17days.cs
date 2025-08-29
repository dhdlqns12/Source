using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace S5_1316
//{
//    class Program
//    {
//        static void Main()
//        {
//            int input_num = int.Parse(Console.ReadLine());
//            int count = 0;

//            for (int i = 0; i < input_num; i++)
//            {
//                string input = Console.ReadLine();
//                if (IsGroupWord(input))
//                    count++;
//            }

//            Console.WriteLine($"{count}");
//        }

//        static bool IsGroupWord(string s)
//        {
//            HashSet<char> hs = new HashSet<char>();
//            for (int i = 0; i < s.Length; i++)
//            {
//                char current = s[i];

//                if (i > 0 && s[i-1]!=current)
//                {
//                    hs.Add(s[i - 1]);
//                }

//                if(hs.Contains(current))
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}

//namespace S5_25206
//{
//    class Program
//    {
//        static void Main()
//        {
//            float gpa = 0;
//            float totla_Credit = 0;
//            //전공평점 계산,전공평점 = 전공 과목별(학점*과목평점) 합을  학점의 총합으로 나눈 값,등급이 p인 과목은 계산에서 제외
//            Dictionary<string, float> gradeToScore = new Dictionary<string, float>
//            {
//                {"A+", 4.5f }, {"A0", 4.0f}, {"B+", 3.5f},{"B0", 3.0f},
//                {"C+", 2.5f},{"C0", 2.0f},{"D+", 1.5f},{"D0", 1.0f},{"F", 0.0f}
//            };

//            for (int i = 0; i < 20; i++)
//            {
//                string[] input = Console.ReadLine().Split();
//                float credit = float.Parse(input[1]);
//                string grade = input[2];

//                if(grade!="P")
//                {
//                    gpa += credit * gradeToScore[grade];
//                    totla_Credit += credit;
//                }
//            }

//            Console.WriteLine($"{(gpa / totla_Credit):F6}");
//        }
//    }
//}
