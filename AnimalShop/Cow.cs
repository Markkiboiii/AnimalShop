using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Cow : Animal
    {
        private string food = "grass";

        public Cow(string aDrink, string aHappy, int aAge)
        {
            Drink = aDrink;
            Happy = aHappy;
            Age = aAge;
            this.Price = 1000;
        }
        public override void Eating()
        {
            Console.WriteLine("The cow eats {0}", food);
        }
        public void CowPayment()
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
