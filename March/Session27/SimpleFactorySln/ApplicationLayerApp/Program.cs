using AutoFactoryCoreLib.Factory;

namespace ApplicationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoMobileFactory factory= new AutoMobileFactory();
            IAutoMobile auto = factory.Make(AutoOptions.TESLA);
            auto.start();
            auto.stop();
            Console.WriteLine(auto.GetType());
        }
    }
}