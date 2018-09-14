using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    public delegate void MinDelegate1();        // Action
    public delegate int MinDelegate2(int i);    // Func
    public delegate int MinDelegate3(int i, int y);
    public delegate void LogDelegate(string txt);


    class Program
    {


        static void Main(string[] args)
        {

            Metode1();



            MinDelegate1 f1 = new MinDelegate1(Metode1);
            f1.Invoke();

            Action f1a = Metode1;
            f1a.Invoke();

            LogDelegate l1 = Metode2;
            l1.Invoke("!!!");

            Action<string> l2 = Metode2;
            l2 += Console.WriteLine;
            l2.Invoke("////");
            

            Action<int, bool, double> l3a;


            Func<int, int> f4 = Test;
            Console.WriteLine(f4(5));

            Func<int, int, int> f5 = LægSammen;
            Console.WriteLine(f5(6, 6)); 


            return;
            //LogDelegate l1 = new LogDelegate(Metode2);
            //l1.Invoke("!!!");

            //LogDelegate l1 = Metode2;
            //l1 += Metode2;
            //l1 += Metode2;
            //l1 += Console.WriteLine;
            //l1 += LogTilFil;

            //l1.Invoke("!!!");
            //l1("123");

            //foreach (var item in l1.GetInvocationList())
            //{
            //    item.DynamicInvoke("ss");
            //}

            ////l1 -= LogTilFil;
            ////l1.Invoke("!!!");

            //MinDelegate3 f3 = LægSammen;
            //f3 += LægSammen2;
            //int t = f3(4, 4);
            //Console.WriteLine(t);

            ////int r = f3.Invoke(4, 5);




        }

        public static int Test(int a)
        {
            return 5;

        }

        public static int LægSammen(int a, int b)
        {
            return a + b;

        }

        public static int LægSammen2(int a, int b)
        {
            return a + b+1;

        }

        public static void Metode1() {
            Console.WriteLine("I metode1");
        }

        public static void Metode2(string t)
        {
            Console.WriteLine("***** " + t + " *******");
        }

        public static void LogTilFil(string t)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", t);
        }
    }
}
