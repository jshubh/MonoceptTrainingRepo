using CompositeDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder compositeRoot = new Folder("Movies");
          compositeRoot.AddChild(new File())
            compositeRoot.AddChild(new File("A.avi", 400));
            compositeRoot.AddChild(new File("B.avi", 400));
            compositeRoot.Display();

            Folder action = new Folder("Action");
            action.AddChild(new File("B.avi",700));

            compositeRoot.AddChild(action);

        }
    }
}
