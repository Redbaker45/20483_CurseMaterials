using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afkobling
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Terning t = new Terning(FindGenerator());
                t.Skriv();

            }

        }

        static ITilfældigshedsGenerator FindGenerator() {
            string t = System.Configuration.ConfigurationManager.AppSettings["tilf"];
            if(t== "TilfældighedMock")
                return new TilfældighedMock();
            if (t == "TilfældighedSystemRandom")
                return new TilfældighedSystemRandom();
            throw new ApplicationException("Fejl");
        }

    }

    class Terning
    {

        private ITilfældigshedsGenerator rnd;



        public int Værdi { get; set; }
        public void Ryst() {
            Værdi = rnd.FindTal(1, 7);
        }

        public Terning(ITilfældigshedsGenerator g)
        {
            this.rnd = g;
            Ryst();
        }
        public void Skriv() {
            Console.WriteLine("[" + this.Værdi + "]");
        }
    }

    interface ITilfældigshedsGenerator {
        int FindTal(int min, int max);
    }

    class TilfældighedSystemRandom : ITilfældigshedsGenerator
    {
        private static System.Random rnd = new Random();
        public int FindTal(int min, int max)
        {
            return rnd.Next(1, 7);
        }
    }

    class TilfældighedUnivers : ITilfældigshedsGenerator
    {
        
        public int FindTal(int min, int max)
        {
            if (DateTime.Now.Millisecond % 2 == 0)
                return 3;
            else
                return 6;
        }
    }

    class TilfældighedMock : ITilfældigshedsGenerator
    {

        public int FindTal(int min, int max)
        {
            return min;
        }
    }

}
