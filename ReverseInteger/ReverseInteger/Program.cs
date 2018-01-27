using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(-123 % 10);
            int result = Reverse(1563847412);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int Reverse(int x)
        {
            int multiplier = 1000000000;
            double result = 0;
            int digits = 0;
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                if (Math.Abs(x / multiplier) > 0 || digits > 0)
                {
                    digits += 1;
                    numbers.Push(x / multiplier);
                    x = x % multiplier;
                }

                multiplier = multiplier / 10;
            }

            for (int i = 10; i > 0; i--)
            {
                if (numbers.Count > 0)
                {
                    result = Math.Pow(10, digits - 1) * numbers.Pop() + result;
                    if (result >= Int32.MaxValue || result <= Int32.MinValue)
                    {
                        result = 0;
                        break;
                    }
                    else
                    {
                        digits--;
                    }
                }
                else
                {
                    break;
                }

            }
            return (int)result;
        }

        public static int ReverseSimple(int x)
        {
            double reverse = 0;
            while (x != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + x % 10;
                x = x / 10;
            }
            if(reverse >= Int32.MaxValue || reverse <= Int32.MinValue)
            {
                reverse = 0;
            }
            return (int)reverse;
        }
    }
}
