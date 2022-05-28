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

            double reZ = (doubleSQRT(0.5 * (doubleSQRT(a * a + b * b) + a)));
            double imZ = Math.Sign(b) * (doubleSQRT(0.5 * (doubleSQRT(a * a + b * b) - a)));


            return new Complex(reZ, imZ);
        }

        public static string AnalyticalSQRT(BigInteger input)
        {
            // https://prog-cpp.ru/simple-multy/

            // prime factorization
            bool isNegative = (input.Sign == -1);
            BigInteger x = BigInteger.Abs(input);
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
            string res = outsideOfRoot + "sqrt(" + insideOfRoot + ")";
            if (isNegative) res = res + "i";
            return res;
        }
    }
}
