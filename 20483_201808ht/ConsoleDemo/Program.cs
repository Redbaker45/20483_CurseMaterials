using System;
using System.IO;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string txt = File.ReadAllText("");
            Console.WriteLine("*");

            string t = Console.ReadLine();
            
            if (System.Diagnostics.Debugger.IsAttached) {
                Console.ReadKey();
            }


        }
    }
}
