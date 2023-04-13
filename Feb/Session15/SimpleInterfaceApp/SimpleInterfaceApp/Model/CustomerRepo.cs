using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class CustomerRepo:Icrudable
    {
        public void Create()
        {
            Console.WriteLine(" Customer records Instered");
        }

        public void Delete()
        {
            Console.WriteLine("Customer records Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Customer records Read");
        }

        public void Update()
        {
            Console.WriteLine("Customer records Updated");
        }
    }
}
