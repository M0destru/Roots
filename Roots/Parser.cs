using System;
using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Roots
{
    class Parser
    {
        public static bool checkInt(string input)
        {
            Regex expr = new Regex(@"0|[-]?[1-9][0-9]*$");
            return expr.IsMatch(input);
        }

        public static bool checkDouble(string input)
        {
            Regex expr = new Regex(@"0|[-]?[1-9][0-9]*.[0-9]*$");
            return expr.IsMatch(input);
        }

        public static bool checkComplex(string input)
        {
            Regex expr = new Regex(@"([-]?[1-9][0-9]*.[0-9]*)?[+-]([1-9][0-9]*.[0-9]*)?[*]?i$");
            return expr.IsMatch(input);
        }

        public static string calc(string input)
        {
            input = input.Replace(" ", "");
            if (checkInt(input))
            {
                switch (int.TryParse(input, out int res))
                {
                    case true: return integers(res);
                    case false:
                        BigInteger res_ = BigInteger.Parse(input);
                        return bigints(res_);
                }
            }

            else if (checkDouble(input))
            {
                if (!double.TryParse(input, out double res)) throw new Exception("Число слишком большое, либо слишком маленькое");
                return floats(res);
            }

            else if (checkComplex(input))
            {
                int plus = input.IndexOf("+"), minus = input.IndexOf("-"), mult = input.IndexOf("i");
                int sign = Math.Max(plus, minus);
                if (input.Contains("*")) mult--;

                double real = plus == -1 && minus == -1 ? 0 : double.Parse(input.Substring(0, sign), CultureInfo.InvariantCulture);
                double imaginary = mult - sign - 1 == 0 ? 1 :
                    double.Parse(input.Substring(sign + 1, mult - sign - 1), CultureInfo.InvariantCulture);

                Complex res = new(real, imaginary);
                return complex(res);
            }

            throw new Exception("Введено не число, либо такой формат числа не поддерживается");
        }

        // плейсхолдеры для вызовов расчета корней
        static string integers(int val) => "integer";
        static string bigints(BigInteger val) => "biginteger";
        static string floats(double val) => "double";
        static string complex(Complex val) => "complex";
    }
}

