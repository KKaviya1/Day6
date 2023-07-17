using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CollectionBase:
             ArrayList arrayList = new ArrayList();  
             Hashtable hashtable = new Hashtable();
             SortedList sortedList = new SortedList();   
             Stack stack = new Stack(); 
             Queue queue = new Queue();  
 */

            ArrayList arrayList = new ArrayList(){ 1, "viya", 'A', DateTime.Now};
            Console.WriteLine("item \t DataType");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item + "\t" + item.GetType());
            }
               ArrayList nameList = new ArrayList() { "Viya", "Gai", "Priya"};
            Console.WriteLine("Name list as follow\n");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            nameList.Add(12);
            nameList.Add(DateTime.Now);
            Console.WriteLine("name list as follows\n");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();  


        }
    }
}
