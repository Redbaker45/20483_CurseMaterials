using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;
using Teknologisk;

namespace Diverse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            Console.WriteLine(p.ToStringEx());

            string d = "lksdjlk fj";
            Console.WriteLine(d.MinMetode(10));

            //Console.WriteLine(MineExtensions.MinMetode("jjj"));

            //Diverse.Properties.Settings.Default.s3 = 20;
            //Diverse.Properties.Settings.Default.Save();


            Console.WriteLine(Diverse.Properties.Settings.Default.s3);

        }

        [Obsolete("Må ikke bruges", false)]
        static void Test() {

        }
    }

    

    class Person {

        public int Id { get; set; }

        public void test() { }
    }
}

namespace Teknologisk
{
    public static class MineExtensions
    {
        public static string MinMetode(this string e, int antal)
        {
            // logik
            return e.ToUpper() + new string('*', antal);
        }
    }
}
