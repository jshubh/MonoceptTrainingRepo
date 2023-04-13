using CalculatorEventApp.Model;

namespace CalculatorEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.AdditionCompleted += PrintResult;
            calc.SubtractionCompleted += PrintResult;
            calc.Add(10,20);
            calc.Subtract(30, 10);
        }
        static void PrintResult(int n1,int n2,string str)
        {
            Console.WriteLine(str);
        }
    }
}