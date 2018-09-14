using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hukommelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            //Console.WriteLine(x);
            Test(out x);
            Console.WriteLine(x);
            int r;
            int.TryParse("55", out r);

            Person p = new Person();
            p.Navn = "a";
            Console.WriteLine(p.Navn);
            Test2( p);
            Console.WriteLine(p.Navn);

            int.TryParse("2", out int value);
            
        }

        static void Test(out int a) {
           
            a = 100;
        }

        static void Test1(Person a)
        {
            a.Navn = "*";
        }

        static void Test2( Person a)
        {
            a = new Person() { Navn = "***" };
        }

    }

    struct Person {
        public string Navn;
    }
}
