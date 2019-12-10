using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MattyList<string> list1 = new MattyList<string> { "1", "2" };
            MattyList<string> list2 = new MattyList<string> { "1", "2" };
            MattyList<string> list3 = list1 - list2;
            foreach (string thing in list3) 
            {
                Console.WriteLine(thing);
            }
                
            Console.ReadLine();
        }
    }
}
