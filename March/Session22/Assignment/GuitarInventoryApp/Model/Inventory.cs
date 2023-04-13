using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventoryApp.Model
{
    public class Inventory
    {
      
            public List<Guitar> guitars;

            public Inventory()
            {
                guitars = new List<Guitar>();
            }

            public void AddGuitar(string serialNumber, double price,
                                   string builder, string model,
                                   string type, string backWood, string topWood)
            {
                Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
                guitars.Add(guitar);
            }

            public Guitar GetGuitar(string serialNumber)
            {
                foreach (Guitar guitar in guitars)
                {
                    if (guitar.SerialNumber == serialNumber)
                    {
                        return guitar;
                    }
                }
                return null;
            }

            public List<Guitar> Search(Guitar searchSpec)
            {
                List<Guitar> matchingGuitars = new List<Guitar>();
                foreach (Guitar guitar in guitars)
                {
                    if (guitar.SerialNumber==searchSpec.SerialNumber)
                    {
                        matchingGuitars.Add(guitar);
                    }
                }
                return matchingGuitars;
            }
        }
    }





  
        
    

