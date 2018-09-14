using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);

            var t = people.Where(i => i.IsHealthy == true && i.Height > 150).OrderBy(i => i.Name).ToList();


            int[] a = {  };

            //var y = a.Single();

            XmlDocument doc;
            
            var res3 = a.Where(i => i < 10).OrderBy(i => i).ToList();

            foreach (var item in res3)
            {
                Console.WriteLine(item);
            }
            

            var mappe = new System.IO.DirectoryInfo(@"c:\temp");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            Console.WriteLine($"Antal filer i temp: {filer.Length:N0}");

            var res1 = from fil in filer
                       where fil.Length < 1000
                       orderby fil.Length
                       group fil by fil.Extension into f
                       select f;

            var res2 = filer
                .Where(fil => fil.Length < 1000)
                .OrderBy((System.IO.FileInfo fil) => { return fil.Length; })
                .GroupBy((System.IO.FileInfo fil) => { return fil.Extension; });

            var res4 = filer
                .Where(fil => fil.Length < 1000).Select((System.IO.FileInfo f) => new { navn = f.FullName, l = f.Length });
            foreach (var item in res4)
            {
                Console.WriteLine(item.navn);
            }

            Console.WriteLine($"Der findes {res1.Count()} forskellige extensions i mappen");
            Console.WriteLine($"Der findes {res2.Count()} forskellige extensions i mappen");
        }
    }
}
