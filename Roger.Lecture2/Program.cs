using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Convert numbers based on its base
/// </summary>
namespace Roger.Lecture2
{
    class Program
    {
        static int ToDecimal(byte _base, string input)
        {
            int sum = 0;
            int power = 0;
            for (int i = input.Length - 1; i > -1; i--)
            {
                int digit = int.Parse(input.ToCharArray()[i].ToString());

                int calc = (int) (digit * Math.Pow(_base, power));
                sum += calc;
                power++;
            }

            return sum;
        }

        static string ConvertToBase(int input, byte _base)
        {
            int left, res;
            string result = "";
            while (true)
            {
                left = input % _base;
                res = input / _base;
                result = left + result;
                if (res == 0 && left == 1)
                    break;

                input = res;
            }

            return result;
        }

        static void Main(string[] args)
        {
            WriteLine("Enter a base number of your number:");
            byte _base = Byte.Parse(ReadLine());
            WriteLine("Enter your number:");
            string input = ReadLine();

            int value = ToDecimal(_base, input);
            string result = ConvertToBase(value, _base);

            WriteLine("************************************************");
            WriteLine("{0} in base {1} to decimal is {2}", input, _base, value);
            WriteLine(value + " on base " + _base + " is " + result);

            ReadKey();
        }
    }
}
