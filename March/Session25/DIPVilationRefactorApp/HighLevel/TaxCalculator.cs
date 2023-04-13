using DIPVoilationRefactoredApp.LowLevel;
using DIPVoilationRefactoredApp.HighLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVoilationRefactoredApp.HighLevel
{
    internal class TaxCalculator
    {
        private IErrorLogger _errorLogger;
        public TaxCalculator(IErrorLogger errorLogger)
        {
            _errorLogger = errorLogger;
        }
        public int CalculateTax(int income, int rate)
        {
            int result = -1;
            try
            {
                result = income / rate;
            }
            catch(Exception ex)
            {
                _errorLogger.Log(ex);
            }
            return result;
        }
    }
}
