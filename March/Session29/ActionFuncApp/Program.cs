namespace ActionFuncApp
{
    internal class Program
    {
        delegate bool DEvenChecker(int n);
        delegate bool DNameChecker(string name);
        delegate void DAddOperation(int a, int b);
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            //DAddOperation addPtr = Add;
            Action<int, int> addPtr = Add;
            addPtr(10, 20);
        }

        private static void CaseStudy2()
        {
            //DNameChecker isLongNameptr = CheckIsALongName;
            //Predicate<string> isLongNamePtr = CheckIsALongName;
            Func<string, bool> isLongNameptr = CheckIsALongName;
            Console.WriteLine(CheckIsALongName("Manjunath"));
        }

        private static void CaseStudy1()
        {
            //DEvenChecker isEvenPtr = CheckIsEven;
            Predicate<int> isEvenPtr = CheckIsEven;
            Console.WriteLine(isEvenPtr(30));
        }

        static bool CheckIsEven(int n)
        {
            return n %2 == 0;
        }

        static bool CheckIsALongName(string name)
        {
            return name.Length >= 8;
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
    }
}