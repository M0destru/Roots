using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Roots
{
    internal class SquareRootCalculator
    {
        private static double doubleSQRT(double x, int precision=3)
        {
            // https://webhamster.ru/mytetrashare/index/mtb0/1684

            // Newton's method

            // stop-criterion
            double eps = 1.0 / Math.Pow(10, precision);

            if (x == 0.0) return 0.0; // we don't need to calculate root for zero

            double y_prev;
            double y_new = x / 2; // first estimation

            do
            {
                y_prev = y_new;
                y_new = 0.5 * (y_prev + x / y_prev);
            } while (Math.Abs(y_prev - y_new) > eps);
            return y_new;
        }
        public static Complex SQRT(double input, int precision=3)
        {
            bool isNegative = (input < 0); 
            double x = Math.Abs(input); // root(-a) = root(a)*i, where a>0
            double y = doubleSQRT(x, precision);

            if (isNegative) return new Complex(0, y);
            else return new Complex(y, 0);
        }

        public static Complex SQRT(Complex input, int precision)
        {
            // http://fxdx.ru/page/kvadratnyj-koren-iz-kompleksnogo-chisla

            double a = input.Real;
            double b = input.Imaginary;

            // check it in the refference
            double reZ = (doubleSQRT(0.5 * (doubleSQRT(a * a + b * b, precision) + a), precision));
            double imZ = Math.Sign(b) * (doubleSQRT(0.5 * (doubleSQRT(a * a + b * b, precision) - a), precision));


            return new Complex(reZ, imZ);
        }

        public static string AnalyticalSQRT(BigInteger input)
        {
            // https://prog-cpp.ru/simple-multy/

            // prime factorization
            bool isNegative = (input.Sign == -1);
            BigInteger x = BigInteger.Abs(input);
            // prime factors of the input and its powers
            // key - factor, value power of factor
            // example: 12 = 2^2 * 3^1
            Dictionary<BigInteger, int> factors = new Dictionary<BigInteger, int>();
            BigInteger factor = 2;
            while (x>1)
            {
                if (x % factor == 0)
                    factors.Add(factor, 0);
                while (x % factor == 0)
                {
                    factors[factor]++;
                    x /= factor;
                }
                factor++;
            }

            // now we have to split outside- and inside- parts
            // example: sqrt(12) = sqrt(2^2 * 3^1)=2*sqrt(3)
            BigInteger outsideOfRoot = 1, insideOfRoot = 1;
            foreach (var p in factors)
            {
                if (p.Value%2==0)
                {
                    outsideOfRoot *= BigInteger.Pow(p.Key, p.Value / 2);
                }    
                else
                {
                    outsideOfRoot *= BigInteger.Pow(p.Key, (p.Value - 1) / 2);
                    insideOfRoot *= p.Key;
                }
            }
            string res = (outsideOfRoot != 1 ? outsideOfRoot : "") + (outsideOfRoot != 1 && insideOfRoot != 1 ? " * " : "") 
                + (insideOfRoot != 1 ? "sqrt(" + insideOfRoot + ")" : "");
            if (isNegative) res += " * i";
            return res;
        }
    }
}
