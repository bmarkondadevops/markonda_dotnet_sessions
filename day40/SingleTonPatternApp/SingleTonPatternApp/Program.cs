using SingleTonPatternApp.Services;

namespace SingleTonPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var s1 =  ConfigurationService.CreateInstance();
            s1.DoSomething();

            Console.WriteLine(s1.GetHashCode());


            var s2 =  ConfigurationService.CreateInstance();
            s2.DoSomething();
            Console.WriteLine(s2.GetHashCode());

        }
    }
}
