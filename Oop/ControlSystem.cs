using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Oop
{
    public class ControlSystem
    {
        public string Name { get; set; }
        public double Balance { get; private set; }
        public double RemainingWater { get; set; }
        public double LeftoverCoffee { get; set; }
        public double RemainingMilk { get; set; }
        public double SugarResidue { get; set; }
        public double SalesAmount { get; private set; }
        private List<CoffeeReciept> _сoffeeReciept;
     

        

        public ControlSystem(List<CoffeeReciept> coffeeReciepts)
        {
            
            Balance = 0;
            RemainingWater = CoffeeOptions.MaxWaterAmount;
            LeftoverCoffee = CoffeeOptions.MaxCoffeeAmount;
            RemainingMilk = CoffeeOptions.MaxMilkAmount;
            SugarResidue = CoffeeOptions.MaxSugarAmount;
            SalesAmount = 0;
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
        public void CoffeePrint()
        {
            double count = 1;
            Console.WriteLine("Список кофе");
            foreach(CoffeeReciept coffee in _сoffeeReciept)
            {
                Console.WriteLine($"{count} {coffee.Name}");
                count++;
            }
        }
        public void AcceptingCoins()
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
        public void ReportingProblems()
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
       












    }



}

