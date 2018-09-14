using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person(1);
            
            p.InstansMetode();
            Person.StatiskMetode();

            Person p2 = Person.HentFraDb(4);
            if (Person.CprValidering("11")) { }

            Dyr d = new Dyr();
            
        }
    }

    public static class IRRBeregning {
        public static  int Beregn() { return 0; }
    }

    public class Person {

        public int alder;
        public string navn;

        public void InstansMetode() { }

        public static void StatiskMetode() { }
        public static bool CprValidering(string cpr) {
            return true;
        }

        public static Person HentFraDb(int id) {
            // kode....
            return new Person();
        }

        public Person() : this(0, "")
        {
            //this.alder = 0;
            //this.navn = "";
        }

        public Person(int alder) : this(alder, "")
        {
            //if (alder > 100 || alder < 0)
            //    throw new ApplicationException("Fejl");
            //// log
            //// sikkerhed
            //this.alder = alder;
            //this.navn = "";
        }

        public Person(int alder, string navn)
        {
            if (alder > 100 || alder < 0)
                throw new ApplicationException("Fejl");
            // log
            // sikkerhed
            this.alder = alder;
            this.navn = navn;
        }

    }

    public partial class Dyr {
        public int a;
    }

    public partial class Dyr {
        public int b;
    }

}
