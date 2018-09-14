using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Collections.ArrayList lst1 = new System.Collections.ArrayList();
            lst1.Add("a");
            lst1.Add("b");
            lst1.Insert(1, "c");
            foreach (var item in lst1)
                Console.WriteLine(item);
            for (int i = 0; i < lst1.Count; i++)
                Console.WriteLine(lst1[i]);

            System.Collections.Hashtable lst2 = new System.Collections.Hashtable();
            lst2.Add("123", "anders");
            lst2.Add("124", "lene");
            Console.WriteLine(lst2["124"]);

            //System.Collections.Queue
            System.Collections.Stack s = new System.Collections.Stack();
            s.Push("1");
            s.Push("2");
            s.Push("3");
            var o = s.Pop();

            Garage g = new Garage();
            g.SætBilIGarage(new Bil() { Mærke = "Volvo" });
            g.SætBilIGarage(new Bil() { Mærke = "BMW" });


            System.Collections.Generic.List<string> lst3 = new List<string>();
            lst3.Add("1");
            string r = lst3[0];

            System.Collections.Generic.List<Bil> lst4 = new List<Bil>();
            lst4.Add(new Bil());

            System.Collections.Generic.Queue<int> lst5 = new Queue<int>();
            System.Collections.Generic.Stack<string> lst6 = new Stack<string>();
            System.Collections.Generic.Dictionary<string, int> lst7 = new Dictionary<string, int>();
            lst7.Add("123", 5);
            lst7.Add("125", 6);

            List<int> lst8 = new List<int>();
            lst8.Add(3);
            lst8.Add(6);
            lst8.Add(6);
            Test2(lst8.ToArray());

        }

        static void Test2(int[] a) {

        }
    }

    class Garage {

        private System.Collections.ArrayList lst = new System.Collections.ArrayList();

        public void SætBilIGarage(Bil b) {
            lst.Add(b);
        }

    }
}
