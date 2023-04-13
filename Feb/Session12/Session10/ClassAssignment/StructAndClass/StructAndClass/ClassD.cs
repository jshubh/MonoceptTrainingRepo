using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndClass
{
    internal class ClassD
    {
        public string name;
        public string language;
        public int article_no;
        public int improv_no;

        // Method of class
        public void Details(string name, string language,
                            int article_no, int improv_no)
        {
            this.name = name;
            this.language = language;
            this.article_no = article_no;
            this.improv_no = improv_no;

            Console.WriteLine("The name of the author is :  " + name
                              + "\nThe name of language is : " + language
                              + "\nTotal number of article published  "
                              + article_no + "\nTotal number of Improvements:"
                              + " done by author is : " + improv_no);
        }

    }
}
