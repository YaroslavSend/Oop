namespace Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlSystem controlSystem = new ControlSystem(CoffeeOptions.GetBaseCoffeeRecieptList(), "кофе");
            controlSystem.DrinkPrint();
            controlSystem.AcceptingCoins();
            controlSystem.ReportingProblems();
            controlSystem.sggsw();

        }
    }
}
