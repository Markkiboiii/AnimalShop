using System;
using System.Collections.Generic;

namespace AnimalShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.
            You should use private when you want to restrict the accses to sensitive data/information which will make it
            hard for the one who uses the program to change something they are not suposed to see.

            While public is used to share all the information in the program and makes it easy for the user to change stuff.

            2.
            Multiple constructors can be usefull to have when you want diffrent constructors to do diffrent stuff but still keep the same name
            this is called overloading and can be used with other methods to.

            */
            var account = new Animal();
            
            Console.Write("Name: {0}\n",account.BuyerAcc);
            Console.WriteLine("Amount of money: {0}kr\n",account.BuyerMoney);
            Console.Write("Name: {0}\n", account.AnimalAcc);
            Console.WriteLine("Amount of money: {0}kr\n", account.AnimalMoney);
            

            AnimalShop.AnimalOffer();


            Console.ReadLine();
        }
    }
}
