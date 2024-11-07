using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    public abstract class BaseControlSystem
    {
        public string MachineName { get; set; } 
    
        public double Balance { get;  set; }
        public double SalesAmount { get;  set; }
        public BaseControlSystem(string machineName)
        {
            Balance = 0;
            SalesAmount = 0;
            MachineName = machineName;
        }




        public abstract void DrinkPrint();



        public abstract void AcceptingCoins();



        public abstract void ReportingProblems();



        public abstract void TheMachineDies(int f);


        public abstract void RepairMachine();
        

   
    }
}
