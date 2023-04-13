using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Model
{
    internal class File
    {
        private string _name;
        private int _size;
        public File(string name)
        {
            _name = name;
        }
        public File(string name,int size)
        {
            _name = name;
            _size = size;
        }


            void Display(int depth=0)
          {
            Console.WriteLine("{0}-{1}Mb",_name,_size);
            for(int i=0;i<10;i++)
            {

            }
          
        }
        }
    }

