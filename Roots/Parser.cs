using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;

namespace Roots
{
    class Parser
    {
        public static bool checkInt(string input)
        {
            Regex expr = new Regex(@"^(0|([-]?[1-9][0-9]*))$");
            return expr.IsMatch(input);
        }

        public static bool checkDouble(string input)
        {
            Regex expr = new Regex(@"^([-]?(0|([1-9][0-9]*))[.][0-9]*)$");
            return expr.IsMatch(input);
        }

        public static bool checkComplex(string input)
        {
            Regex expr = new Regex(@"^((([0]|([-]?[0][.][0-9]*)|([-]?[1-9][0-9]*([.][0-9]*)?))[+-])?(([0]|([1-9][0-9]*))([.][0-9]*)?[*]?)?[i])$");
            return expr.IsMatch(input);
        }

        public static string calc(string input, bool isAnalytical, int precision)
        {
            input = input.Replace(" ", "");
            if (checkInt(input))
            {
                switch (int.TryParse(input, out int res))
                {
                    case true: return integers(res, isAnalytical, precision);
                    case false:
                        BigInteger res_ = BigInteger.Parse(input);
                        return bigints(res_, isAnalytical, precision);
                }
            }

            else if (checkDouble(input))
            {
                double res = double.Parse(input, CultureInfo.InvariantCulture);
                return floats(res, isAnalytical, precision);
            }

            else if (checkComplex(input))
            {
                int plus = input.IndexOf("+"), minus = input.LastIndexOf("-"), mult = input.IndexOf("i");
                int sign = Math.Max(plus, minus);
                if (sign == -1) sign = 0;
                if (input.Contains("*")) mult--;

                double real = (plus == -1 && minus == -1) ||  minus == 0 && plus == -1 && input.IndexOf("i") != -1 ?
                    0 : double.Parse(input.Substring(0, sign), CultureInfo.InvariantCulture);
                if (sign == minus || sign == 0) sign--;
                double imaginary = mult - sign - 1 == 0 ? 1 :
                    double.Parse(input.Substring(sign + 1, mult - sign - 1), CultureInfo.InvariantCulture);

                Complex res = new(real, imaginary);
                return complex(res, isAnalytical, precision);
            }

            throw new Exception(sWrongFormat);
        }

        // плейсхолдеры для вызовов расчета корней
        static string integers(int val, bool isAnalytical, int precision) =>
            isAnalytical ? SquareRootCalculator.AnalyticalSQRT(new BigInteger(val)).ToString() : 
            ComplexToStr(SquareRootCalculator.SQRT(val, precision), precision);
        static string bigints(BigInteger val, bool isAnalytical, int precision) =>
            isAnalytical ? SquareRootCalculator.AnalyticalSQRT(val).ToString() :
            ComplexToStr(SquareRootCalculator.SQRT(((double)val), precision), precision);
        static string floats(double val, bool isAnalytical, int precision) =>
            isAnalytical ? sSimpleBad :
            ComplexToStr(SquareRootCalculator.SQRT(val, precision), precision);
        static string complex(Complex val, bool isAnalytical, int precision) =>
            isAnalytical ? sComplexBad :
            ComplexToStr(SquareRootCalculator.SQRT(val, precision), precision);

        static string ComplexToStr(Complex val, int precision) => 
            $"{(val.Real != 0 || val.Imaginary == 0 ? $"{Math.Round(val.Real, precision)}" : "")}" +
            $"{(val.Imaginary > 0 && val.Real != 0 ? "+" : "")}" + 
            $"{(val.Imaginary != 0 ? $"{Math.Round(val.Imaginary, precision)}i" : "")}";

        static string sWrongFormat = "Введено не число, либо такой формат числа не поддерживается";
        static string sSimpleBad = "Аналитический корень вещественного числа не поддерживается";
        static string sComplexBad = "Аналитический корень комплексного числа не поддерживается";

        public static void ChangeLoc(List<string> text)
        {
            if (text != null)
            {
                sWrongFormat = text[31];
                sSimpleBad = text[32];
                sComplexBad = text[33];
            }
        }
    }
}