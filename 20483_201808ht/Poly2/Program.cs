using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly2
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.Test();
            B b = new B();
            b.Test();

            A c = new B();
            c.Test();

            List<A> lst = new List<A>() { new A(), new B(), new B(), new A() };
            foreach (var item in lst)
            {
                item.Test();
            }


        }
    }

    class A {
        public virtual void Test() {
            Console.WriteLine("I A");
        }

        public void Test2() { }
    }

    class B : A {
        public override void Test()
        {
            Console.WriteLine("I B");            
        }
        public void Test3() { }
    }

}
