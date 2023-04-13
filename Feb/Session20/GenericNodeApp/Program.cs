using GenericNodeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNodeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nodeA = new Node<int>();
            var nodeB= new Node<int>();
            var nodeC= new Node<int>();

            nodeA.Data = 10;
            nodeB.Data = 20;
            nodeC.Data = 30;
            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            

            PrintDetails<int>(nodeA);
        }
        private static void PrintDetails<T>(Node<T>node)
        {
            Console.WriteLine(node.Data);
            while (node != null)
            {
               
                node = node.Next;
                if (node!= null)
                    Console.WriteLine(node.Data);
            }
        }
    }
}
