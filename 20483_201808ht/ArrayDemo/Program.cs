using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a1 = { 2, 34, 5, 3, 1, 1, 4, 56 };
            int[] a2 = a1.Clone() as int[];
            if (a2 != null) { }
            int[] a3 = (int[])a1.Clone();



            Console.WriteLine(a1.Length);
            //System.Array.Resize(ref a1, 100);

            System.Array.Sort(a1);

            int[] b = { 5, 10, 1, 3, 8 };
            Console.WriteLine(FindMindste(b));

            Console.WriteLine(Sum(1));
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1, 3, 4, 5, 4, 1, 74, 1, 7, 5, 1));
            Console.WriteLine(Sum(4,b));


            string tal = "1;5;4;2;4";
            string[] talA = tal.Split(';');
            Console.WriteLine(string.Join(",", talA));
            Console.WriteLine(string.Join(",", 4,5,6,34,2,4,56,7,4));



        }

        public static int FindMindste(int[] array)
        {
            int[] c = array.Clone() as int[];
            System.Array.Sort(c);
            return c[0];
        }

        public static int Sum(int y, params int[] tal)
        {
            int sum = 0;
            foreach (var item in tal)
            {
                sum += item;
            }
            return sum;
        }

    }
}
