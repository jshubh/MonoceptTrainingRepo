using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoryInfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for directory
            // CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();

            //for file
            // CaseStudy6();
            //  CaseStudy7();
            // CaseStudy8();
            //  CaseStudy9();

        }
        private static void CaseStudy1()
        {
            //for creating directory
            string path = @"E:\Monocept\Mydirectory";
            DirectoryInfo d1 = new DirectoryInfo(path);
            d1.Create();
            Console.WriteLine("Directory is created");
        }
        private static void CaseStudy2()
        {
            //for creating sub directory
            string path = @"E:\Monocept\Mydirectory";
            DirectoryInfo d1 = new DirectoryInfo(path);
            d1.CreateSubdirectory("AnotherDirectory");
            Console.WriteLine("Directory is created");

        }
        private static void CaseStudy3()
        {
            //for transfer the data from directory one to another using move to
            string path = @"E:\Monocept\Mydirectory";
            string path2= @"E:\Monocept\Mydirectory2";
            DirectoryInfo d1 = new DirectoryInfo(path);
            d1.MoveTo(path2);

            Console.WriteLine("Directory is moved");
        }
        private static void CaseStudy4()
        {
            string path = @"E:\Monocept\Mydirectory";
            string path2 = @"E:\Monocept\Mydirectory2";
            DirectoryInfo d1 = new DirectoryInfo(path2);
         //   d1.Delete(); is not work because directory is not free
            d1.Delete(true);

        }
          private static void CaseStudy6()
          {
            //for creating file
            FileInfo f1 = new FileInfo("E:\\Monocept\\Mydirectory\\MyTestFile.txt");
            FileStream fs = f1.Create();
            Console.WriteLine("File has been created");
         }
        private static void CaseStudy7()
        {
            //for writing in  file
            FileInfo f1 = new FileInfo("E:\\Monocept\\Mydirectory\\MyTestFile.txt");
            StreamWriter fs = f1.CreateText();
            fs.WriteLine("Its first day of file handling");

            Console.WriteLine("file has been created with some information");
            fs.Close();
        }
        private static void CaseStudy8()
        {
            //for reading a file
            FileInfo f1 = new FileInfo("E:\\Monocept\\Mydirectory\\MyTestFile.txt");
            FileStream f2 = f1.Open(FileMode.Open);
            StreamReader fs = new StreamReader(f2);
            string content = fs.ReadToEnd();
            Console.WriteLine(content);
            fs.Close();



            Console.WriteLine("file has been created with some information");
          

        }
        private static void CaseStudy9()
        {
            //for deleting a file
            FileInfo f1 = new FileInfo("E:\\Monocept\\Mydirectory\\MyTestFile.txt");
            f1.Delete();
            Console.WriteLine("file is deleted");
        }
    }
}
