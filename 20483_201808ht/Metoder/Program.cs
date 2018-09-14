using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 10;
            Beregn();
            void Beregn() {
                y++;
                
            }

            Test();
            Test(5);

            string t;

            //    Metode1(navn: "lkdjf", erSmart: true, )

            var r = M2();

            Print(@"c:\temp");

            

            
        }

        static void a() {
            a(1, 2, 3);
        }
        static void a(int _a) {
            a(_a, 2, 3);
        }
        static void a(int a, int b) { }
        static void a(int a, int b, int c) { }

        static void Metode1(string navn, int alder, bool erSmart, string land)
        {
        }

        static int Test(int i = 32) {

            if (i < 10)
                return i;



            return 6;

        }

        static MinReturVærdi M1() {
            MinReturVærdi r;
            r.a = 1;
            r.b = 1;
            return r;
        }

        static (int a, string b, bool t) M2()
        {
            // kode....
            return (3, "42", true);
        }

        static void Print(string mappe) {
            foreach (var fil in System.IO.Directory.GetFiles(mappe))
            {
                Console.WriteLine(fil);                
                foreach (var m in System.IO.Directory.GetDirectories(mappe))
                    Print(m);
            }
        }


    }

    struct MinReturVærdi {
        public int a;
        public int b;
    }
}
