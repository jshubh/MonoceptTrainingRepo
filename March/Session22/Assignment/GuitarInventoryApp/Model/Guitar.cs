using GuitarInventoryApp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventoryApp.Model
{

  public  class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public string Builder { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string BackWood { get; set; }
        public string TopWood { get; set; }

        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            SerialNumber = serialNumber;
            Price = price;
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public static implicit operator Guitar(Inventory v)
        {
            throw new NotImplementedException();
        }
    }
}
       

  