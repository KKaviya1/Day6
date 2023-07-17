using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace calc
{
    public class Calc
    { 
   public void BonusCalc(double salary, out double bonus)
    {
        bonus = salary * 0.2;
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 50000;
            double bonus;
            Calc calc = new Calc();
            calc.BonusCalc(salary, out bonus);    
            Console.WriteLine($"salary:{salary} & bonus: {bonus} ");
            Console.ReadKey();
        }
    }
}
