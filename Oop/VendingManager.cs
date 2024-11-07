namespace Oop
{
    public class VendingManager
    {
        List<BaseControlSystem> controls = new List<BaseControlSystem>()
      {
            new ControlSystem(CoffeeOptions.GetBaseCoffeeRecieptList(),"кофе"),
            new ControlSystemForSoda(80,90,100,"сладкая вода"),
       };
        public void AddingAMachine()
        {
            Console.WriteLine("Введите какой тип автомата вы хотите добавить");
            string MachineType = Console.ReadLine();
            if (MachineType == "автомат с газировками")
            {
                Console.WriteLine("введите цену за колу");
                double CocaColaprice=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите цену за спрайт");
                double CocaSpriteprice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите цену за фанту");
                double CocaFantaprice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите название автомата");
                string AvtomatName = Console.ReadLine();
                controls.Add(new ControlSystemForSoda(CocaColaprice, CocaSpriteprice, CocaFantaprice, AvtomatName));
            }
            if (MachineType == "автомат с кофе")
            {
                Console.WriteLine("введите название автомата");
                string AvtomatName1 = Console.ReadLine();
                controls.Add(new ControlSystem(CoffeeOptions.GetBaseCoffeeRecieptList(), AvtomatName1));
            }


        }
        public void RemoveAMachine()
        {
            Console.WriteLine("Введите номер автомата который хотите удалить");
            int NumberMachine = Convert.ToInt32(Console.ReadLine());

            NumberMachine--;
            if (NumberMachine >= 0 && NumberMachine < controls.Count)
            {
                controls.RemoveAt(NumberMachine);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
        public void BuyingADrink()
        {
            Console.WriteLine("Введите в каком автомате хотите купить напиток");
            string drink = Console.ReadLine();
            if (drink == "кофе")
            {
                foreach (BaseControlSystem s in controls)
                {
                    if (s is ControlSystem)
                    {
                        ((ControlSystem)s).AcceptingCoins();
                    }
                }
            }
            if (drink == "сладкая вода")
            {
                foreach (BaseControlSystem s in controls)
                {
                    if (s is ControlSystemForSoda)
                    {
                        ((ControlSystemForSoda)s).AcceptingCoins();
                    }
                }
            }

        }
        public void Sum()
        {
            double sum=0;
            foreach (BaseControlSystem q in controls)
            {
                sum += q.SalesAmount;
            }
            Console.WriteLine(sum); 
            
        }
        public void MachineRepair()
        {
            foreach(BaseControlSystem w in controls)
            {
                w.TheMachineDies(2);
            }
        }



    }
}
