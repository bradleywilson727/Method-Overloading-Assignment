using System;

namespace MethodOverloadingAssignment
{
    class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool trueOrFalse)
        {
            var sum = num1 + num2;

            if(trueOrFalse == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(trueOrFalse == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(trueOrFalse == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

        }
    }
}
