using DIPVoilationApp.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVoilationApp.HighLevel
{
    internal class TaxCalculator
    {
        private ErrorLogOptions _errorLogOptions;
        public TaxCalculator(ErrorLogOptions errorLogOptions)
        {
            _errorLogOptions = errorLogOptions;
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
                if (_errorLogOptions == ErrorLogOptions.TXT)
                {
                    var txtLogger = new TXTErrorLogger();
                    txtLogger.Log(ex);
                }
                else
                {
                    var xmlLogger = new XMLErrorLogger();
                    xmlLogger.Log(ex);
                }
            }
            return result;
        }
    }
}
