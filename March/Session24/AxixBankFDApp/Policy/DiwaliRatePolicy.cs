using FixedDepositCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxixBankFDApp.Policy
{
    internal class DiwaliRatePolicy:IRatePolicy
    {
        public double CalcuateRate()
        {
            return 0.5;
        }
    }
}
