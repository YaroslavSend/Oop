using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    public class CoffeeOptions
    {
        public const int MaxWaterAmount = 100;
        public const int MaxMilkAmount = 100;
        public const int MaxCoffeeAmount = 100;
        public const int MaxSugarAmount = 100;
        public static List<CoffeeReciept> GetBaseCoffeeRecieptList()
        {
            return new List<CoffeeReciept>()
            {
                new CoffeeReciept()
                {
                    Name="Капучино",
                    price=100,
                    Milk=3,
                    Coffee=6,
                    Water=1,
                },
                new CoffeeReciept()
                {
                    Name="Американо",
                    price=70,
                    Milk=2,
                    Coffee=3,
                    Water=4,
                },
                new CoffeeReciept()
                {
                    Name="Латте",
                    price=50,
                    Milk=5,
                    Coffee=4,
                    Water=2,
                }

            };
        }
    }
}

