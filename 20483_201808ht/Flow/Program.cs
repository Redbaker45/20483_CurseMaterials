using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow
{
    class Program
    {
        static void Main(string[] args)
        {

            string g;
            

            DayOfWeek d = DayOfWeek.Monday;

            switch (d)
            {
                case DayOfWeek.Monday:
                  
                case DayOfWeek.Tuesday:
                  
                case DayOfWeek.Wednesday:
                  
                case DayOfWeek.Thursday:




                    break;
                case DayOfWeek.Friday:
                    break;

                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:


                    break;

                default:
                    break;
            }


            for (int i = 10; i>0; i=i-2)
            {
                Console.WriteLine(i);
            }


        }
    }
}
