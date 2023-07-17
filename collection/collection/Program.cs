using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //STACK = last in first out
            Stack stack = new Stack();
            stack.Push("viya");
            stack.Push("kavi");
            stack.Push("gai-3");
            Console.WriteLine("number of items in stack are: \t" + stack.Count);
          /*  foreach (var item in stack)
            {
                Console.WriteLine(item);
            }*/
            Console.ReadKey();
        }
    }
}
