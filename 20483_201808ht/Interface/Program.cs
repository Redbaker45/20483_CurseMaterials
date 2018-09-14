using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde();
            k.Gem(1);
            k.Slet();
            Console.WriteLine(k is ISikkerhed);
            Faktura f = new Faktura();
            Console.WriteLine(f is ISikkerhed);

            f.Gem(1);
            f.Slet();

            IDbFunktioner r = k;
            r.Gem(8);

            List<IDbFunktioner> lst = new List<IDbFunktioner>();
            lst.Add(new Kunde());
            lst.Add(new Bil());
            lst.Add(new Faktura());
            lst.Add(new Kunde());
            lst.Add(new Bil());
            lst.Add(new Faktura());
            foreach (IDbFunktioner item in lst)
            {
                item.Gem(5);
                //if (item is ISikkerhed) {
                //    (item as ISikkerhed).CheckSikkerhed();
                //}
            }

            List<Hund> hunde = new List<Hund>();
            hunde.Add(new Hund() { AntalBen = 4 });
            hunde.Add(new Hund() { AntalBen = 3 });
            hunde.Add(new Hund() { AntalBen = 5 });

            foreach (var item in hunde)
            {
                Console.WriteLine(item.AntalBen);
            }

            hunde.Sort();

            foreach (var item in hunde)
            {
                Console.WriteLine(item.AntalBen);
            }
        }
    }

    class Hund : IComparable<Hund> {
        public int AntalBen { get; set; }

        public int CompareTo(Hund other)
        {
            if (this.AntalBen > other.AntalBen)
                return 1;
            if (this.AntalBen < other.AntalBen)
                return -1;
            return 0;


        }
    }

    class Kat { }
    class Kunde : IDbFunktioner
    {

        public int id { get; set; }
        public void Gem(int i)
        {
            Console.WriteLine("I gem - kunde");
        }

        public void Slet()
        {
            Console.WriteLine("I slet");
        }
    }

    class Faktura : IDbFunktioner, ISikkerhed
    {
        public void SkrivRykker() { }

        public void Gem(int id)
        {
            Console.WriteLine("I gem - faktura");
        }

        public void Slet()
        {
            Console.WriteLine("I slet");
        }

        public void CheckSikkerhed()
        {
            throw new NotImplementedException();
        }
    }

    class Bil : IDbFunktioner
    {
        public void Gem(int id)
        {
            Console.WriteLine("I gem - Bil");
        }

        public void Slet()
        {
            throw new NotImplementedException();
        }
    }




    interface IDbFunktioner {
        void Gem(int id);
        void Slet();
    }

    interface ISikkerhed {
        void CheckSikkerhed();
    }

    abstract class A {
        public abstract void Test();
    }
    abstract class B : A {
        
    }

    class C : B
    {
        public override void Test()
        {
            throw new NotImplementedException();
        }
    }
}
