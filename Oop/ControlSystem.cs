using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Oop
{
    public class 
       ControlSystem : BaseControlSystem
    {
        public string Name { get; set; }
        public double RemainingWater { get; set; }
        public double LeftoverCoffee { get; set; }
        public double RemainingMilk { get; set; }
        public double SugarResidue { get; set; }
        private List<CoffeeReciept> _сoffeeReciept;




        public ControlSystem(List<CoffeeReciept> coffeeReciepts, string machineName) : base(machineName)
        {
            RemainingWater = CoffeeOptions.MaxWaterAmount;
            LeftoverCoffee = CoffeeOptions.MaxCoffeeAmount;
            RemainingMilk = CoffeeOptions.MaxMilkAmount;
            SugarResidue = CoffeeOptions.MaxSugarAmount;
            _сoffeeReciept = coffeeReciepts;
            Refiel();
        }
        
        public void Refiel()
        {
            if (RemainingMilk == 0)
            {
                RemainingMilk = 100;
            }
            
            if (LeftoverCoffee == 0)
            {
                LeftoverCoffee = 100;
            }
            if (RemainingWater == 0)
            {
                RemainingWater = 100;
            }

            if (SugarResidue == 0)
            {
                SugarResidue = 100;
            }
        }
        public override void   DrinkPrint()
        {
            double count = 1;
            Console.WriteLine("Список кофе");
            foreach(CoffeeReciept coffee in _сoffeeReciept)
            {
                Console.WriteLine($"{count} {coffee.Name}");
                count++;
            }
        }
        public override void AcceptingCoins()
        {

            Console.WriteLine("Введите сумму которую хотите положить в автомат");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите что вы хотите купить");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы хоите кофе с сахаром?");
            string YesOrNo =Console.ReadLine();
            if (YesOrNo == "да") 
            {
                
            }
            else
            {
                SugarResidue -= 0;
            }
            number--;
            if (number >= 0 && number < _сoffeeReciept.Count)
            {
                CoffeeReciept count = _сoffeeReciept[number];
                if (sum >= count.price && CoffeeOptions.MaxWaterAmount >= count.Milk && CoffeeOptions.MaxCoffeeAmount >= count.Coffee && CoffeeOptions.MaxMilkAmount >= count.Milk)
                {
                    RemainingWater -= count.Water;
                    LeftoverCoffee -= count.Coffee;
                    RemainingMilk -= count.Milk;
                    Balance += count.price;
                    SalesAmount += count.price;
                    sum -= count.price;
                    Console.WriteLine($"Вот ваш {count.Name} Ваша сдача {sum}");
                }
            }
        }
        public override void ReportingProblems()
        {
            string problem = "кончились деньги";
            string problem1= "кончился кофе";
            string problem2= "кончилась вода";
            string problem3= "кончилось молоко";
            if (RemainingWater==0)
            {
                Console.WriteLine(problem2);
            }
            if (Balance == 0)
            {
                Console.WriteLine(problem);
            }
            if (LeftoverCoffee == 0)
            {
                Console.WriteLine(problem1);
            }
            if (RemainingMilk == 0)
            {
                Console.WriteLine(problem3);
            }
        }
        public void sggsw()
        {
            Console.WriteLine(Balance);
            Console.WriteLine(RemainingWater);
            Console.WriteLine(LeftoverCoffee);
            Console.WriteLine(RemainingMilk);
            Console.WriteLine(SugarResidue);
            Console.WriteLine(SalesAmount);
        }
        public override void TheMachineDies(int f)
        {
            if (Balance == 0)
            {
                f = 0;
                
            }
            else
            {
                f = 1;
            }
            if (f == 0)
            {
                RepairMachine();
            }
        }
        public override void RepairMachine()
        {
            Console.WriteLine($"автомат{MachineName} починился");
        }













    }



}

