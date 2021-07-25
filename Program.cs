using System;

namespace Method_Overloading_Exercise
{
    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isRight)
        {
            var sum = a + b;
            
            if(isRight == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(isRight == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if(isRight == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main (string[] args)
        {
            var x = 33;
            var y = 36;

            var answer = Add(x, y);

            var a = 34.0m;
            var b = 37.0m;

            var decimalAnswer = Add(a, b);

            var thirdOption = Add(2, 2, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdOption);

        }
    }
}
