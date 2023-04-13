using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class ProductRepo:Icrudable
    {
        public void Create()
        {
            Console.WriteLine("Product records Instered");
        }

        public void Delete()
        {
            Console.WriteLine("Product records Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Product records Read);
        }

        public void Update()
        {
            Console.WriteLine("Product records Updated");
        }
    }
}
