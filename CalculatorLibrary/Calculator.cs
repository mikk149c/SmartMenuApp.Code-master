using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            double addition = v1 + v2;
            return addition;
        }

        public static double Subtract(double v1, double v2)
        {
            double subtraction = v1 - v2;
            return subtraction;
        }

        public static double Multiply(double v1, double v2)
        {
            double multiplication = v1 * v2;
            return multiplication;
        }

        public static double Divide(double v1, double v2)
        {
            double divide = v1 / v2;
            return divide;
        }

        public static double Sum(double[] numbers)
        {
            double Sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                Sum = numbers[i] + Sum;
            }
            return Sum;
        }

        public static double Minimum(double[] numbers)
        {
            double Min = 999999999;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Min > numbers[i])
                {
                    Min = numbers[i];
                }
            }

            return Min;
        }

        public static double Maximum(double[] numbers)
        {
            double Max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0 || Max < numbers[i])
                {
                    Max = numbers[i];
                }
            }

            return Max;
        }

        public static double Average(double[] numbers)
        {
            double res = 0;
            double Average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = numbers[i] + res;
            }

            Average = numbers.Length;
            Average = res / Average;

            return Average;
        }
    }
}
