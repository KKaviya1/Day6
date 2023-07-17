using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> students = new SortedList<int, string>()
            {
                { 15, "viya"},
                { 12, "ravi"},
                { 53, "raji"}
            };
           
            Console.WriteLine("number of students are: " + students.Count);
            Console.WriteLine("Roll \t Name");
            foreach (var k in students.Keys)
            {
                Console.WriteLine(k + "\t" + students[k]);
            }
            students.Add(32, "prakash");
            Console.WriteLine("\n");
            Console.WriteLine("updated students list");
            Console.WriteLine("Roll \t Name");
            foreach (var k in students.Keys)
            {
                Console.WriteLine(k + "\t" + students[k]);
            }
            Console.ReadKey();

        }

    }



}