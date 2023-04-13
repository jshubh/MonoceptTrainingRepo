using MovieBusinessLayerLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore store = new MovieStore();
            Console.WriteLine("1 Add\n2 Display\n3 Exit");
            while (true)
            {
                Console.WriteLine("enter your choise");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("enter movie name");
                        string mn = Console.ReadLine();
                        Console.Write("enter movie year");
                        int my = Convert.ToInt32(Console.ReadLine());

                        store.Add(new Movie(mn, my));
                        break;
                    case "2":
                        Movie[] movies = store.GetMovies();
                        printDetail(movies);
                        break;
                    case "3":
                        return;

                }
                
            }
            
        }

        private static void printDetail(Movie[] movies)
        {
            foreach(Movie movie in movies)
            {
                if(movie != null)
                {
                    Console.WriteLine(movie.Name);
                    Console.WriteLine(movie.Year);
                }
                
            }
        }
        private static void Serialization()
        {

            Movie e = new Movie("Race",2013);
            
            
            FileStream fs = new FileStream("Human1.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs, e);
            fs.Close();
            Console.WriteLine();
        }
        private static void Derialization()
        {
            FileStream fs = new FileStream("Human1.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            object obj = binaryFormatter.Deserialize(fs);
            Movie movie = obj as Movie;
            


            fs.Close();
        }
       
    }
}
