using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedhardware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> hardwareList = new SortedList<string, int>()
            {
                {"FDD", 670 },
                {"HDD", 900},
                {"RAM", 120 },
                {"CD", 340 }
            };
            Console.WriteLine("short form\tprice ");
            foreach(var k in hardwareList.Keys)
            {
                Console.WriteLine(k + "\t" + "\t"+hardwareList[k]);
            }
            Console.ReadKey();
        }
    }
}
