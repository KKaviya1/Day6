
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    public class Calc
    {
        public double Add(params double[] numbers)
        {
            double total = 0;
            foreach (double number in numbers)
            {
                total += number;
            }
            return total;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine("Result after adding 1,12,23.5 is=\t" + calc.Add(1, 12, 23.5));
            Console.WriteLine("Result after adding 10,12 is =\t" + calc.Add(10, 12));
            Console.ReadKey();
        }
    }
}
   