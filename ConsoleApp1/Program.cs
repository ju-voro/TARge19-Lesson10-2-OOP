using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            /*Animal nurr = new Animal();
            nurr.name = "Nurr";
            nurr.age = 15;
            nurr.levelOfHappiness = 0.1;
            nurr.PrintAnimalBaseInfo();*/

            Dog scooby = new Dog();
            scooby.name = "ScoobyDoo";
            scooby.age = 1;
            scooby.levelOfHappiness = 0.1;
            scooby.spotCount = 5;
            scooby.PrintAnimalBaseInfo();

            Cat miisu = new Cat();
            miisu.name = "Miisu";
            miisu.age = 2;
            miisu.levelOfHappiness = 0.5;
            miisu.levelOfCuteness = 1;
            //Cat Meows
            for(int i = 0; i < 10; i++)
            {
                miisu.Meow();
            }
            miisu.ShowLevelOfCuteness();

            //Dog Barks
            for(int i = 0; i < 20; i++)
            {
                scooby.Bark();
            }

            miisu.HearBarks(scooby.numbersOfBarks);
            if(miisu.levelOfHappiness < 0 )
            {
                Console.WriteLine($"{miisu.name} died of stress.");
                miisu = null;
            }


            scooby.ShowNumberOfDogSpots();
            scooby.ShowLevelOfHappiness();

            Console.ReadLine();

        }
    }
}
