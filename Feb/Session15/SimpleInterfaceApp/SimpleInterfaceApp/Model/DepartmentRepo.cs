using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class DepartmentRepo:Icrudable
    {
        public void Create()
        {
            Console.WriteLine("Department records Instered");
        }

        public void Delete()
        {
            Console.WriteLine("Department records Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Department records Read");
        }

        public void Update()
        {
            Console.WriteLine("Department records Updated");
        }
    }
}
