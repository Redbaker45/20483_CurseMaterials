using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynmaicDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic a = new { navn="a", alder = 10 };
            Test(a);

            long t = 1;
            

            


        }

        static void Test(dynamic t) {
            Console.WriteLine(t.alder);
        }
    }
}
