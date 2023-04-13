using GuitarInventoryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventoryApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Inventory inventory = new Inventory();

            
            inventory.AddGuitar("1", 1000, "Gibson", "Les Paul", "Electric"," Wood.Mahogany", "Wood.Maple");
            inventory.AddGuitar("2", 1200, "Fender", "Stratocaster", "Electric", "Wood.Alder", "Wood.Rosewood");
            inventory.AddGuitar("3", 800, "Martin", "D-28", "Acoustic", "Wood.Rosewood", "Wood.Sitka");




            Guitar searchSpec = inventory;
        
            searchSpec.Builder = "Gibson";
            searchSpec.Model = "Les Paul";
            List<Guitar> matchingGuitars = inventory.Search(searchSpec);
            Console.WriteLine("Matching guitars:");
            foreach (Guitar guitar in matchingGuitars)
            {
                Console.WriteLine("Serial number: " + guitar.SerialNumber);
                Console.WriteLine("Price: " + guitar.Price);
                Console.WriteLine("Builder: " + guitar.Builder);
                Console.WriteLine("Model: " + guitar.Model);
                Console.WriteLine("Type: " + guitar.Type);
                Console.WriteLine("Back wood: " + guitar.BackWood);
                Console.WriteLine("Top wood: " + guitar.TopWood);
                Console.WriteLine();
            }
        }


    }
    }



