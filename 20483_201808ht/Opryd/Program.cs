using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opryd
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            ////a.RydOp();
            //a.Dispose();
            //a = null;

            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            using (A a = new A())
            {
                

            }

            using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection())
            {
                cn.Open();
                using (System.Data.SqlClient.SqlCommand cm = new System.Data.SqlClient.SqlCommand("select *", cn))
                {
                    using (System.Data.SqlClient.SqlDataReader r = cm.ExecuteReader())
                    {
                        
                    }                    
                }
            }


                
            }// Dispose (Close, null, rydder)

            //System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection();
            //cn.Close();
            //cn = null;








        }
    }


    class A : IDisposable {

        public A()
        {
            Console.WriteLine("nu bliver jeg født");
        }

        ~A() {
            Console.WriteLine("nu dør jeg");
        }

        public void Dispose() {
            Console.WriteLine("nu rydder jeg op....");
        }
    }

class B : IDisposable {
    #region IDisposable Support
    private bool disposedValue = false; // To detect redundant calls

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            disposedValue = true;
        }
    }

    // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
    // ~B() {
    //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
    //   Dispose(false);
    // }

    // This code added to correctly implement the disposable pattern.
    public void Dispose()
    {
        // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        Dispose(true);
        // TODO: uncomment the following line if the finalizer is overridden above.
        // GC.SuppressFinalize(this);
    }
    #endregion
}

