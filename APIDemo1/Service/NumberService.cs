using APIDemo.Service.Models;
using APIDemo1.Interface;
using APIDemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIDemo1.Service
{
    public class NumberService : INumber
    {
        public int GetDetails(NumberEntity item)
        {
            int n = item.Number;
            int k = item.Divisor;

            for (int i = k, count = 0; count < n; i++)
            {
                if (checkdigit(i, k) || (i % k == 0))
                    count++;

                if (count == n)
                    return i;
            }
            return -1;
        }
        private bool checkdigit(int n, int k)
        {
            while (n != 0)
            {
                int rem = n % 10;
                if (rem == k)
                    return true;

                n = n / 10;
            }
            return false;
        }

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
        // ~NumberService()
        // {
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
}