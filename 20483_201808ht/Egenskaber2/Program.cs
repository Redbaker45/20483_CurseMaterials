using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace Egenskaber2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("x");
            //p.SetNavn("x");
            //Console.WriteLine(p.GetNavn());

            Console.WriteLine(p.Navn);
            p.Navn = "x";
            Console.WriteLine();
            Console.WriteLine(p.ToStringEx());
            //p.Alder = 10;


            Bil b = new Bil();
            b.AntalHjul = 4;
            Console.WriteLine(b.ToStringEx());

            Bil b2 = new Bil { Model = "X70", Mærke = "Volvo", AntalHjul = 4};

            int id1 = b2.MitId1;
            int id2 = b2.MitId2();



        }
    }

    class Person
    {

        //public int Alder;

        private int _alder;

        public int alder
        {
            get {

                return _alder; }
            set {

                _alder = value; }
        }



        // fuld egenskab
        private string _navn;

        public string Navn
        {
            get
            {
                // log
                // sikkerhed
                // validering
                return this._navn;
            }
            set
            {
                // log
                // sikkerhed
                // validering
                if (value == null)
                    value = "";
                this._navn = value;
            }
        }

        public Person(string navn)
        {
            this.Navn = navn;
        }

        //public void SetNavn(string v) {
        //    // log
        //    // sikkerhed
        //    // validering
        //    this.Navn = v;
        //}

        //public string GetNavn()
        //{
        //    // log
        //    // sikkerhed
        //    // validering
        //    return this.Navn;
        //}


    }

    public class Faktura {

        private int nummer;

        public int Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        private DateTime date;

        public DateTime Dato
        {
            get { return date; }
            set { date = value; }
        }


        private bool betalt;

        public bool Betalt
        {
            get { return betalt; }
            
        }

    }

    class Bil {

        private int antalHjul;

        public int AntalHjul
        {
            get { return antalHjul; }
            set {
                if (value <= 2)
                    value = 4;
                antalHjul = value; }
        }


        //public int AntalHjul { get; set; }
        public string Model { get; set; } = "";
        public string Mærke { get; set; } = "";
        public DateTime Dato { get; private set; }

        public int MitId1
        {
            get { return 1; }
            
        }

        public int MitId2() {
            return 1;
        }


        void Test()
        {
            this.Dato = DateTime.Now;

        }

    }


}
