using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemo
{
    class Program
    {

        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            log.Debug("Start");

            log.Debug("Kalder Test");
            try
            {
                Test(6);
            }
            catch (Exception ex)
            {
                // log
                log.Error(ex);
                Console.WriteLine("fejl!!!");
            }
            log.Debug("Retur fra Test");

            log.Debug("Slut");
        }

        static void Test(int t) {
            log.Debug("I test med " + t);

            // sql

            string sql = "select * from ,,,,";
            log.Trace(sql);

            string y = null;
            y.ToString();

            log.Debug("Retur");
        }
    }
}
