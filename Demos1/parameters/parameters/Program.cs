using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameters
{
    public class Calc
    {
        public void Increment( ref int num)
        {
            Console.WriteLine("value of num inside method before increment: \t" +num);
            num += 5;
            Console.WriteLine("value of num inside method after increment: \t" + num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
  
            int myNum;
            Console.WriteLine("enter a number");
            myNum = int.Parse(Console.ReadLine());
            Console.WriteLine("myNum in main before call is: \t"+myNum);
            Calc calc = new Calc(); 
            calc.Increment(ref myNum);
            Console.WriteLine("myNum in main after call is: \t" + myNum);
            Console.ReadKey();
        }
    }
}
