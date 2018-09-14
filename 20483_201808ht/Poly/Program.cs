using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Test();
            

            B b = new B();
            b.Test();

            A a2 = new B() { Id = 4 };

            B b2 = a2 as B;

            Hund h = new Hund() { Navn = "a" };
            Console.WriteLine(h.ToString());
            Console.WriteLine(h);


            Elev e = new Elev();
            e.Gem();

            Person p = new Elev();
            p.Gem();

        }
    }

    class Hund {
        public string Navn { get; set; }

        public override string ToString() {
            return "Jeg er en hund og hedder " + this.Navn;
        }

    }


    class Person {
        public virtual  void Gem() {
            Console.WriteLine("Gemmer person");
        }
    }
    class Elev : Person
    {
        public override void Gem()
        {
            Console.WriteLine("Gemmer elev");
        }
    }


    class A {
        public void Test() {
            Console.WriteLine("I Test() fra A");
        }
    }

    class B : A {
        public int Id { get; set; }
        public void Test2() { }
    }
}
