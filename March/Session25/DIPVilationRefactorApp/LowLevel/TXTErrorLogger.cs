using DIPVoilationRefactoredApp.HighLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVoilationRefactoredApp.LowLevel
{
    internal class TXTErrorLogger : IErrorLogger
    {
        public void Log(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Writing into Text File, Please Wait");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }
}
