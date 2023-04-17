
using RunningSingeltonserviceinmultithread.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningSingeltonserviceinmultithread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tasks = new Task[5];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => AccessDataService());
            }
            
           
            Task.WaitAll(tasks);
        }

        static void AccessDataService()
        {
           
            
            var service = DataService.GetInstance();

            
            service.DoProcessing();
        }
    }
    }
