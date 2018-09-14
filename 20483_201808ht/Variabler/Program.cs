using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int antalMåneder = 0;
                antalMåneder++;

                var t = 1;

                System.Double a = 0.5;
                double aa = 0.0;
                var aaa = 0.5;

                float ft = 0.22F;


                int dage = DateTime.DaysInMonth(2018, 2);
                DateTime tee = DateTime.Now;
                DateTime t4 = new DateTime(2018, 1, 1);
                TimeSpan ts = tee.Subtract(t4);
                Console.WriteLine(ts.TotalDays);

                TimeSpan ts2 = new TimeSpan(15, 22, 00);
                TimeSpan t3 = ts2.Add(new TimeSpan(0, 20, 0));


                byte u = 255;
                //checked
                //{
                //    u++;
                //    u++;
                //}
                Console.WriteLine(u);

                string qq = "flksdflskdf lkdj lsjd fs";

                string sti = @"c:\temp\test.txt";
                Console.WriteLine(sti);

                Console.WriteLine("start");
                string lp = "";
                for (int p = 0; p < 100000; p++)
                {
                    lp += "*";
                    //lp = lp + "*";
                }
                Console.WriteLine("slut");

                //Convert.ToInt32("222222222222222");

                int qqq = int.Parse("32");
                int www = 0;
                if (int.TryParse("32s", out www))
                {

                }

                void MinM() {

                }

                int tddd = 1;


                System.Text.StringBuilder sb = new StringBuilder();
                Console.WriteLine("start");
                for (int p = 0; p < 10_000_000; p++)
                {
                    sb.Append("*");
                }
                Console.WriteLine("slut");

                Test();
                //byte y = 300;

                //Console.WriteLine(byte.MinValue);
                //Console.WriteLine("byte min: " + System.Byte.MinValue);
                //Console.WriteLine($"byte min: {System.Byte.MinValue} {t} {t:N5}");
            }

            {
                int a = 1;
                Console.WriteLine($"a = {a}");
            }
            {
                int b = 2;
                Console.WriteLine($"b = {b}");
                // Her kendes a ikke
            }
            {
                int c = 3;
                Console.WriteLine($"c = {c}");
                // Her kendes hverken a eller b
            }
            Console.ReadKey();


        }

        static void Test() {

            string navn1 = "mikkel";
            int alder1 = 15;
            Køn køn1 = Køn.Mand;

            string navn2 = "mathias";
            int alder2 = 12;
            Køn køn2 = Køn.Mand;

            string navn3 = "lene";
            int alder3 = 52;
            Køn køn3 = Køn.Kvinde;

            Person p1 = new Person();
            p1.navn = "a";
            p1.alder = 1;
            p1.køn = Køn.Mand;

            Person p2;
            p2 = p1;

            p1.navn = "x";



            Person p3 = new Person();
            p3.alder++;


            

        }
    }


}
