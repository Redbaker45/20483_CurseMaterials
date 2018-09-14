using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                App();
            }
            catch (Exception ex)
            {
                // log

                MinException e = 
                    new MinException("Kan ikke... fordi... ", ex);

                throw e;
            }
 
        
        }

        static void App() {

            string f = null;
            f.ToString();

        }

        class MinException : ApplicationException {
            public MinException(string m, Exception inn)
            {

            }
        }

    }
}
