using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningSingeltonserviceinmultithread.Model
{
    
        internal class DataService
        {
            private static DataService _bucket;
            private static readonly object _lockObject = new object();

            private DataService()
            {
                Console.WriteLine("Data Service Created");
            }

            public void DoProcessing()
            {
                Console.WriteLine("Processing data by " + this.GetHashCode());
            }

            public static DataService GetInstance()
            {
                lock (_lockObject)
                {
                    if (_bucket == null)
                    {
                        _bucket = new DataService();
                    }
                    return _bucket;
                }
            }
        }

    }

