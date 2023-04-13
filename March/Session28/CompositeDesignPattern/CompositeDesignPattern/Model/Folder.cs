using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Model
{
    internal class Folder:IStorageItem
    {
        private string _name;
        private List<IStorageItem>_children;
        public Folder(string name)
        {
            _name = name;
        }
        public void Display(int depth=0)
        {
            Console.WriteLine("{0}",_name);
            foreach(IStorageItem item in _children)
            {
                item.Display(++depth);
            }
        }
        public void AddChild(IStorageItem item)
        {
            _children.Add(item);
        }
    }
}
