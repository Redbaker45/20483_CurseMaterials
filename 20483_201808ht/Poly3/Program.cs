using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly3
{
    class Program
    {
        static void Main(string[] args)
        {

            //B b = new B();
            //Console.WriteLine(b is B);
            //Console.WriteLine(b is A);
            //Console.WriteLine(b is C);

            //A a = new B();
            //B c = a as B;

            A a = new A();
            a.Test();
            B b = new B();
            b.Test();
            A c = new B();
            c.Test();



            YatzyTerning t = new YatzyTerning();
        }
    }

    class A {
        public virtual void Test() {
            Console.WriteLine("i A");
        }
    }

    class B : A {
        public new void Test()
        {
            Console.WriteLine("i B");
        }
    }

    class C { }

    abstract class Terning {
        public void Ryst() {
            // kode...
        }

        abstract public void Skriv();


    }

    class YatzyTerning : Terning
    {
        public override void Skriv()
        {
            
        }
    }
    class LudoTerning : Terning
    {
        public override void Skriv()
        {
            
        }
    }

    abstract class Faktura {
        public abstract void Gem();
    }
    class DebitorFaktura : Faktura
    {
        public override void Gem()
        {
            throw new NotImplementedException();
        }
    }
    class KreditorFaktura : Faktura
    {
        public override void Gem()
        {
            throw new NotImplementedException();
        }
    }

}
