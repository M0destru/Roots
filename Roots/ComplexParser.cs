using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Roots
{
    class ComplexParser
    {
        public static Complex parse(string input)
        {
            input.Replace(" ", "");
            Regex expr = new(@"([1-9][0-9]*(.[0-9]*)?[+-])?([1-9][0-9]*(.[0-9]*))?[*]?i$");
            if (!expr.IsMatch(input)) throw new Exception("Введено не комплексное число");

            int plus = input.IndexOf("+"), minus = input.IndexOf("-"), mult = input.IndexOf("i");
            int sign = Math.Max(plus, minus);
            if (input.Contains("*")) mult--;

            double real = plus == -1 && minus == -1 ? 0 : double.Parse(input.Substring(0, sign), CultureInfo.InvariantCulture);
            double imaginary = mult - sign - 1 == 0 ? 1 : 
                double.Parse(input.Substring(sign + 1, mult - sign - 1), CultureInfo.InvariantCulture);

            Complex res = new(real, imaginary);
            return res;
        }
    }
}
