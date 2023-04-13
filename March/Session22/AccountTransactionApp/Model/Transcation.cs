using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactionApp.Model
{
    internal class Transcation
    {

        public char Type
        {
            get; set;
        }
        public DateTime Time
        {
            get; set;
        }
        public double Amount
        {
            get; set;
        }
        public override string ToString()
        {
            return "Type : " + Type + " Time :" + Time + " Amount :" + Amount;
        }





    }
}
