using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {


            Action a = Test;
            a();

            Action b = () => {
                Console.WriteLine("*");
            };
            b += () => { Console.WriteLine("!"); };
            b();

            Action<string> c = Log;
            c += (txt) => {
                Console.WriteLine(txt);
            };
            c += (txt) => {
                System.IO.File.AppendAllText(@"c:\temp\log.txt", txt);
            };
            c("****");

            // Func<int, int, bool> d = (int a1, int b1) => { return a1 == b1; };
            // Func<int, int, bool> d = ( a1, b1) => { return a1 == b1; };
            Func<int, int, bool> d = (a1, b1) => a1 == b1;

            int[] r = { 4, 5, 1, 4, 56, 5 };
            //var res = System.Array.FindAll(r, (int i) => { return i < 5; });
            var res = System.Array.FindAll(r, i => i < 5);


            Console.WriteLine(Find(1,1));
            Console.WriteLine(d(1, 1));
            
            

        }

        public static bool Find(int a, int b) {
            return a == b;
        }
        public static void Test() {
            Console.WriteLine("*");
        }

        public static void Log(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
