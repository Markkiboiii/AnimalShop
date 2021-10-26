using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Animal
    {
        // Property for all the animals
        public string Sound { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }
        public string Swim { get; set; }
        public string Climb { get; set; }
        public string Drink { get; set; }
        public int Weight { get; set; }
        public string Happy { get; set; }
        public int Age { get; set; }
        public int Price { get; set; }

        // Buyer
        public string BuyerAcc { get; set; }
        public decimal BuyerMoney { get; set; }
        //Shop
        public string AnimalAcc { get; set; }
        public decimal AnimalMoney { get; set; }
        // My Constructor
        public Animal()
        {
            BuyerAcc = "AnimalBuyer";
            BuyerMoney = 10000;
            AnimalAcc = "AnimalShop";
            AnimalMoney = 25;
        }
        // Two method which is virtual so it can be changed with overriding
        public virtual void Eating()
        {
            Console.WriteLine(" ");
        }

        public virtual void AnimalSound()
        {
            Console.WriteLine(" ");
        }
    }
}
