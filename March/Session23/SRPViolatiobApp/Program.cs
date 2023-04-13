using SRPViolatiobApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolatiobApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoic invoic = new Invoic(1, "Training Invoice", 100, .50);
            invoic.PrintInvoice();
        }
    }
}
