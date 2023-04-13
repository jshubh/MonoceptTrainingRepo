using PocOnAttribute.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            DisplayNames displayNames = (DisplayNames)Attribute.GetCustomAttribute(personType, typeof(DisplayNames));
            Console.WriteLine($"Display name: {displayNames.DisplayName}");

            Person person = new Person { FirstName = "John", LastName = "Doe" };
            string fullName = person.GetFullName();
            Console.WriteLine($"Full name: {fullName}");
        }
    }
}
