using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositCoreLib.Model
{
    public interface IRatePolicy
    {
        double CalcuateRate();
    }
}
