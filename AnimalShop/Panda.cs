using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Panda : Animal
    {
        private string food = "bamboo";

        public Panda(string aFood, string aColor, string aClimb)
        {
            Food = aFood;
            Color = aColor;
            Climb = aClimb;
            this.Price = 5000;
        }
        public override void Eating()
        {
            Console.WriteLine("The panda eats {0}",food);
        }
        public void PandaPayment()
        {
            Console.Write("Input payment: ");
            Console.WriteLine("You payed {0}kr", Price);
            BuyerMoney = BuyerMoney - Price;
            AnimalMoney = AnimalMoney + Price;
            Console.WriteLine("The animal shop has {0}kr now", AnimalMoney);
            Console.WriteLine("The animal buyer has {0}kr now", BuyerMoney);
            Console.WriteLine("Thank You!\n");
        }
    }
}
