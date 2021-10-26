using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Penguin : Animal
    {
        private string food = "krill";

        public Penguin(string aSound, string aSwim, int aWeight)
        {
            Sound = aSound;
            Swim = aSwim;
            Weight = aWeight;
            this.Price = 2500;

        }
        public override void Eating()
        {
            Console.WriteLine("The penguin eats {0}", food);
        }
        public void PenguinPayment()
        {
            Console.Write("Input payment: ");
            Console.WriteLine("You payed {0}kr",Price);
            BuyerMoney = BuyerMoney - Price;
            AnimalMoney = AnimalMoney + Price;

            Console.WriteLine("The animal shop has {0}kr now", AnimalMoney);
            Console.WriteLine("The animal buyer has {0}kr now", BuyerMoney);
            Console.WriteLine("Thank You!\n");

        }
    }
}
