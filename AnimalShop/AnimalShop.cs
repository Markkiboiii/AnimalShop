using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class AnimalShop
    {
        public static void AnimalOffer()
        {
            var shop = new AnimalShop();
            var myCow = new Cow("Water", "Is Happy", 5);
            var myPenguin = new Penguin("NootNoot", "Can Swim", 25);
            var myPanda = new Panda("Bamboo", "Black and White", "Can Climb");

            Console.WriteLine("Buy your animal!\n");

            while (true)
            {
                Console.WriteLine("Do you want to buy a animal? Y/N");
                string yesNo = Console.ReadLine();

                if (yesNo.ToLower() == "yes" || yesNo.ToLower() == "y")
                {
                    Console.WriteLine("Pick your animal!");

                    Console.WriteLine("The Cow drinks {0} and {1} its age is {2}years \nThe Cow cost {3}kr\n",
                        myCow.Drink, myCow.Happy, myCow.Age, myCow.Price);
                    Console.WriteLine("The Penguin says {0} and {1} it has a weight of {2}kg \nThe Penguin cost {3}kr\n",
                        myPenguin.Sound, myPenguin.Swim, myPenguin.Weight, myPenguin.Price);
                    Console.WriteLine("The Panda eats {0} and its color is {1} it {2}\nThe Panda cost {3}kr\n",
                        myPanda.Food, myPanda.Color, myPanda.Climb, myPanda.Price);

                    Console.WriteLine("You pick the animal by typing it's name! -Cow- -Penguin- -Panda-");

                    shop.SellAnimal();

                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public string SellAnimal()
        {
            var myCow = new Cow("Water", "Is Happy", 5);
            var myPenguin = new Penguin("NootNoot", "Can Swim", 25);
            var myPanda = new Panda("Bamboo", "Black and White", "Can Climb");

            string yes = Console.ReadLine();
            if (yes.ToLower() == "cow")
            {
                Console.WriteLine("You have choosen {0} it costs {1}kr",yes, myCow.Price);
                myCow.Eating();
                myCow.CowPayment();
                return yes;
            }
            else if (yes.ToLower() == "penguin")
            {
                Console.WriteLine("You have choosen {0} it costs {1}kr", yes, myPenguin.Price);
                myPenguin.Eating();
                myPenguin.PenguinPayment();


                return yes;
            }
            else if (yes.ToLower() == "panda")
            {
                Console.WriteLine("You have choosen {0} it costs {1}kr", yes, myPanda.Price);
                myPanda.Eating();
                myPanda.PandaPayment();

                return yes;
            }
            else
            {
                return null;
            }
        }
    }
}
