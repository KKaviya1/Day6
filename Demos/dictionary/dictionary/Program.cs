using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                { 15, "viya"},
                { 12, "priya"},
                { 53, "riya"}
            };
            Console.WriteLine("number of students are: "+ students.Count);
            Console.WriteLine("Roll \t Name");
            foreach(var k in students.Keys)
            {
                Console.WriteLine(k + "\t"+ students[k]);

            }
            students.Add(32, "Deepaa");
            Console.WriteLine("\n");
            Console.WriteLine("Updated students list");
            Console.WriteLine("Roll \t Name");
            foreach (var k in students.Keys)
            {
                Console.WriteLine(k + "\t" + students[k]);

            }
            Console.ReadKey();
        }
    }
}
