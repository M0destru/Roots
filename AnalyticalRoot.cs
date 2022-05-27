using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RootTest
{
    class AnalyticalRoot // вид a * sqrt(b)
    {
        public BigInteger mult { get; private set; } // a
        public BigInteger radical { get; private set; } // b
        public override string ToString()
        {
            string mult = this.mult == 1 && this.radical != 1 ? "" : this.mult.ToString();
            string radical = this.radical == 1 ? "" : $"sqrt({this.radical})";
            return $"{mult}{(mult != "" ^ radical != "" ? "" : " * ")}{radical}";
        }
        public string calc(int number)
        {
            if (number < 1) return "-";
            else
            {
                mult = BigInteger.One;
                radical = new BigInteger(number);

                for (int i = Convert.ToInt32(Math.Sqrt(number)); i >= 2; i--)
                    if (radical % (i * i) == 0)
                    {
                        mult *= i;
                        radical /= (i * i);
                    }

                return ToString();
            }
        }

        // Пример использования
        //AnalyticalRoot root = new AnalyticalRoot();
        //BigInteger n = BigInteger.Parse(Console.ReadLine());
        //Console.WriteLine(root.calc(n));

        List<BigInteger> eratosfen(BigInteger number)
        {
            List<BigInteger> lst = new();
            BigInteger sqrt = new BigInteger(Math.Pow(Math.E, BigInteger.Log(number) / 2));
            for (BigInteger i = new(2); i <= sqrt; i++)
                if (lst.TrueForAll(a => number % a != 0)) lst.Add(i);
            return lst;
        }
        public string calc(BigInteger number) // по логике должен работать, но это делается миллион лет
        {
            if (number < 1) return "-";
            else
            {
                mult = BigInteger.One;
                radical = number;
                List<BigInteger> erat = eratosfen(number);

                foreach (BigInteger num in erat)
                    if (radical % (num * num) == 0)
                    {
                        mult *= num;
                        radical /= (num * num);
                    }

                return ToString();
            }
        }
    }
}
