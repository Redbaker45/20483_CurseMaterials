using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iodemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = @"c:\temp\data.txt";
            Console.WriteLine(File.Exists(f));

            string a = File.ReadAllText(f);
            string[] b = File.ReadAllLines(f);

            System.IO.FileInfo f2 = new FileInfo(@"c:\temp\data.txt");
            System.IO.DirectoryInfo m = new DirectoryInfo(@"c:\temp");

            var t = System.IO.Path.Combine(@"c:\", "temp", "data.txt");

            
            using (var sr = System.IO.File.OpenRead(""))
            {

                
            }

            System.Collections.Generic.Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(3, "");
            
        }
    }
}
