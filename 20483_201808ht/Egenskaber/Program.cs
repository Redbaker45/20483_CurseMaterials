using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person(10, "a");
            Console.WriteLine(p.GetAlder());
            p.SetAlder(20);
            Console.WriteLine(p.GetAlder());

            Console.WriteLine(p.ToStringEx());

        }
    }

    class Person {

        private int alder;

        public string Navn { get; set; }

        public Person(int alder, string navn)
        {
            this.alder = alder;
            this.Navn = navn;
        }

        public int GetAlder() {
            // log
            // sikkerhed
            // validering..

            return this.alder;
        }

        public void SetAlder(int alder) {
            // log
            // sikkerhed
            // validering..
            this.alder = alder;
        }
    }
}
