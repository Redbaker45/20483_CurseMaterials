using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Mor m = new Mor();
            Barn b = new Barn();
            b.Test1();

            A a = new A();
            Console.WriteLine();
            B b2 = new B();

            Dyr d = new Dyr("a");

            Hund h = new Hund();
        }
    }

    class Dyr {

        public Dyr()
        {

        }
        public Dyr(string navn)
        {
            Console.WriteLine("I ctor");
        }
    }

    class Hund : Dyr
    {
 
    }

    class A
    {
        public A()
        {
            Console.WriteLine("I A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("I B");
        }
    }
    public class Mor
    {
        public int A { get; set; }
        protected int B { get; set; }
        private int C { get; set; }

        public void Test1()
        {
            // Alle egenskaber kan ses
            Console.WriteLine("I Test1");
        }

        protected void Test2()
        {
            // Alle egenskaber kan ses
            Console.WriteLine("I Test2");
        }

        private void Test3()
        {
            // Alle egenskaber kan ses
            Console.WriteLine("I Test3");
        }
    }

    public class Barn : Mor
    {
        public int D { get; set; }

        public void Test4()
        {
            // A, B og D kan ses
            // Test1, Test2 kan ses            

            

            Console.WriteLine("I Test4");
        }
    }
}
