using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Needtorefactirthisattributeapp.Model
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false)]
    public class NeedToRefactorAttribute : Attribute
    {
        private string title;
        private string description;


        public NeedToRefactorAttribute(string t, string d)
        {
            title = t;
            description = d;
        }
        public string Display { get; }
        public string Title { get; }
        public string Description { get; }
        public NeedToRefactorAttribute(string description)
        {
            Display = description;
        }
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);


            MethodInfo[] methods = classType.GetMethods();



            for (int i = 0; i < methods.GetLength(0); i++)
            {


                object[] attributesArray = methods[i].GetCustomAttributes(true);


                foreach (Attribute item in attributesArray)
                {
                    if (item is NeedToRefactorAttribute)
                    {


                        NeedToRefactorAttribute attributeObject = (NeedToRefactorAttribute)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,
                         attributeObject.title, attributeObject.description);
                    }
                }
            }
        }
    }
}

