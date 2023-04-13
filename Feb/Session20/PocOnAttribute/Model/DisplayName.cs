using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnAttribute.Model
{
   [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
  //  [AttributeUsage(AttributeTargets.Class)]
    public class DisplayNames : Attribute
    {
        public string DisplayName { get; }

        public DisplayNames(string displayName)
        {
            DisplayName = displayName;
        }
    }

}
