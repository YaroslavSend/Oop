using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    public class ControlSystemForSoda : BaseControlSystem
    {
        private double _priceCola;
        private double _priceSprite;
        private double _priceFanta;
        private double _quantityCola;
        private double _quantitySprite;
        private double _quantityFanta;
        public ControlSystemForSoda(double priceCola, double priceSprite, double priceFanta, string machineName) : base(machineName)
        {
            _priceCola = priceCola;
            _priceSprite = priceSprite;
            _priceFanta = priceFanta;
            _quantityCola = SodaOptions.MaxColaQuantity;
            _quantitySprite = SodaOptions.MaxSpriteQuantity;
            _quantityFanta = SodaOptions.MaxFantaQuantity;
            Refiel();
        }
        public void Refiel()
        {
            if (_quantityCola == 0)
            {
                _quantityCola = 20;
            }

            if (_quantitySprite == 0)
            {
                _quantitySprite = 20;
            }
            if (_quantityFanta == 0)
            {
                _quantityFanta = 20;
            }

        }
        public override void DrinkPrint()
        {
            Console.WriteLine("Список газировок");
            Console.WriteLine("1 кола");
            Console.WriteLine("2 спрайт");
            Console.WriteLine("3 фанта");
        }
        public override void AcceptingCoins()
        {

            Console.WriteLine("Введите сумму которую хотите положить в автомат");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите какую газировку хотите купить");
            double number =Convert.ToDouble(Console.ReadLine());
            if(number == 1)
            {
                Balance += _priceCola;
                SalesAmount += _priceCola;
                sum-=_priceCola;
                _quantityCola -= 1;
                Console.WriteLine($"Вот ваша кола, ваша сдача{sum}");
            }
            if (number == 1)
            {
                Balance += _priceSprite;
                SalesAmount += _priceSprite;
                sum -= _priceSprite;
                _quantitySprite -= 1;
                Console.WriteLine($"Вот ваша кола, ваша сдача{sum}");
            }
            if (number == 3)
            {
                Balance += _priceFanta;
                SalesAmount += _priceFanta;
                sum -= _priceFanta;
                _quantityFanta -= 1;
                Console.WriteLine($"Вот ваша кола, ваша сдача{sum}");
            }
        }
        public override void ReportingProblems()
        {
            string problem = "кончились деньги";
            string problem1 = "кончились банки с колой";
            string problem2 = "кончились банки  со спрайтом";
            string problem3 = "кончились банки с фантой";
            if (_quantitySprite == 0)
            {
                Console.WriteLine(problem2);
            }
            if (Balance== 0)
            {
                Console.WriteLine(problem);
            }
            if (_quantityCola == 0)
            {
                Console.WriteLine(problem1);
            }
            if (_quantityFanta == 0)
            {
                Console.WriteLine(problem3);
            }

        }
        public override void TheMachineDies(int f)
        {
            if (Balance == 0)
            {
                f=0;
             
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

