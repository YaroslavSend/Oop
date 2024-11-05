namespace Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlSystem controlSystem = new ControlSystem(CoffeeOptions.GetBaseCoffeeRecieptList());
            controlSystem.CoffeePrint();
            controlSystem.AcceptingCoins();
            controlSystem.ReportingProblems();
            controlSystem.sggsw();

        }
    }
}
