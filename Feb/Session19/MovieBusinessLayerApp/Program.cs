
using MovirBusinessLayerLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MovieBusinessLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {




            MovieStore store = new MovieStore();
            Console.WriteLine("1 Add\n2 Display\n3 Exit");

            while (true)
            {
                Console.WriteLine("Enter your choice:");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter movie name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter movie year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        store.Add(new Movie(name, year));
                        break;
                    case "2":
                        Console.WriteLine("Movies in store:");
                        Movie[] movies = store.GetMovies();
                        foreach (Movie movie in movies)
                        {
                            Console.WriteLine($"{movie.Name} ({movie.Year})");
                        }
                        break;
                    case "3":
                        // Serialize MovieStore object to a binary file
                        BinaryFormatter formatter = new BinaryFormatter();
                        FileStream stream = new FileStream("moviestore.dat", FileMode.Create);
                        formatter.Serialize(stream, store);
                        stream.Close();
                        Console.WriteLine("MovieStore saved to file.");
                        return;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
/*
MovieStore store = new MovieStore();


store.Add(new Movie("The Shawshank Redemption", 1994));
store.Add(new Movie("The Godfather", 1972));
store.Add(new Movie("The Dark Knight", 2008));
store.Add(new Movie("The Matrix", 1999));
store.Add(new Movie("Forrest Gump", 1994));
store.Add(new Movie("The Racw", 2912));
store.Add(new Movie("kING", 2012));

Console.WriteLine("Movies in store:");
Movie[] movies = store.GetMovies();
foreach (Movie movie in movies)
{
    if (movie != null)
    {
        Console.WriteLine($"{movie.Name} ({movie.Year})");
    }
}


BinaryFormatter formatter = new BinaryFormatter();
FileStream stream = new FileStream("moviestore1", FileMode.Create);
formatter.Serialize(stream, store);
stream.Close();
Console.WriteLine("MovieStore saved to file ");


stream = new FileStream("moviestore1", FileMode.Open);
MovieStore loadedStore = (MovieStore)formatter.Deserialize(stream);
stream.Close();


Console.WriteLine("Movies in loaded store:");
movies = loadedStore.GetMovies();
foreach (Movie movie in movies)
{
    if (movie != null)
    {
        Console.WriteLine($"{movie.Name} ({movie.Year})");
    }
}



}


}
}
*/

/*
MovieStore store = new MovieStore();
store.Add(new Movie("The Shawshank Redemption", 1994));
store.Add(new Movie("The Godfather", 1972));
store.Add(new Movie("The Dark Knight", 2008));

// Serialize the MovieStore to a file-poinbrefghjk
string filename = "moviestore.xml";
using (FileStream stream = new FileStream(filename, FileMode.Create))
{
    DataContractSerializer serializer = new DataContractSerializer(typeof(MovieStore));
    serializer.WriteObject(stream, store);
}
Console.WriteLine($"MovieStore serialized to file {filename}");

// Deserialize the MovieStore from the file
using (FileStream stream = new FileStream(filename, FileMode.Open))
{
    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas());
    DataContractSerializer serializer = new DataContractSerializer(typeof(MovieStore));
    MovieStore deserializedStore = (MovieStore)serializer.ReadObject(reader);
    Console.WriteLine($"MovieStore deserialized from file {filename}");
    Console.WriteLine("Movies in store:");
    foreach (Movie movie in deserializedStore.GetMovies())
    {
        if (movie != null)
        {
            Console.WriteLine($"{movie.Name} ({movie.Year})");
        }
    }
}
}
*/



