using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class Ourclass
    {
        //Instance method return Type void and no parameters
        public void Display()
        {
            Console.WriteLine("Welcome to Methods !");
        }

        //static method
        public static void Welcome()
        {
            Console.WriteLine("static method welcome you !");
        }
        //methods return void and take two parameters
        public void FullName(string fname, string lname) 
        {
        Console.WriteLine("FullName is: "+fname + " " + lname);
        }

        //methods return double and take two parameters
        public double Add(double n1, double n2)
        {
            double result;
            result = n1 + n2;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ourclass obj = new Ourclass();      
            obj.Display();
            Ourclass.Welcome();

            Console.WriteLine("\n \n")

            Ourclass ourclass = new Ourclass();
            double num1, num2;
            Console.WriteLine("enter first number");
            num1=double.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2=double.Parse(Console.ReadLine()); 
           Console.WriteLine("result after addition is: \t "+ourclass.Add(num1, num2));
            Ourclass.Welcome();
            Console.ReadKey();
        }
        
    }
   
}
