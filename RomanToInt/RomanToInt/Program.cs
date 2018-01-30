using System;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("DCXXI"));
            Console.ReadLine();
        }
        public static int RomanToInt(string s)
        {
            //const int romanI = 1;
            //const int romanV = 5;
            //const int romanX = 10;
            //const int romanL = 50;
            //const int romanC = 100;
            //const int romanD = 500;
            //const int romanM = 1000;
            int total = 0;
            s = s.Trim().ToUpper();
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 > s.Length-1)
                {
                    total = total + GetValue(s[i]);
                    break;
                }
                if (GetValue(s[i]) >= GetValue(s[i+1]))
                {
                    total = total + GetValue(s[i]);
                }
                else
                {
                    total = total + (GetValue(s[i + 1]) - GetValue(s[i]));
                    i++;
                }
            }
            return total;
        }
        public static int GetValue(Char Letter)
        {
            switch (Letter)
            {
                case 'M':
                    return 1000;
                case 'D':
                    return 500;
                case 'C':
                    return 100;
                case 'L':
                    return 50;
                case 'X':
                    return 10;
                case 'V':
                    return 5;
                case 'I':
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
