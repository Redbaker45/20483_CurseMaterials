using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher fs = new System.IO.FileSystemWatcher(@"c:\temp");
            fs.EnableRaisingEvents = true;
            fs.Created += (s, e) => {
                Console.WriteLine("oprettet " + e.FullPath);
            };
            fs.Deleted += Fs_Deleted;

            do
            {

            } while (true);

            return;

            Test t = new Test();
            //t.LogDelegate += Skriv;
            t.LogDelegate += (s, e) => { Console.WriteLine(e.Text);  };
            t.NuSkerNoget();
            
            
        }

        private static void Fs_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Slettet " + e.FullPath);
        }

        public static void Skriv(string rt) {
            Console.WriteLine(rt);
        }
    }

    class Test {

        //public event Action<string> LogDelegate;
        public event EventHandler<MineEventArgs> LogDelegate;

        public void NuSkerNoget() {
            if (LogDelegate != null)
                //LogDelegate("hallo");
                LogDelegate(this, new MineEventArgs() { Text = "Hallo" });
        }

    }

    class MineEventArgs : EventArgs {
        public string Text { get; set; }

    }
}
