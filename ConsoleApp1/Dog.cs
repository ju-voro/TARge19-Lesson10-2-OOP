using System;

namespace ConsoleApp1
{
    //Inheritance
    class Dog : Animal
    {
        public int spotCount = 0;
        public int numbersOfBarks = 0;

        public void Bark()
        {
            Console.WriteLine("Wuf");
            numbersOfBarks++;
            levelOfHappiness += 0.1;
            //add 5 spots every time the dog barks
            int randomNumbOfSpots;
            Random rnd = new Random();
            randomNumbOfSpots = rnd.Next(0, 6);
            spotCount += randomNumbOfSpots;
        }

        public void ShowNumberOfDogSpots()
        {
            Console.WriteLine($"{name} has now {spotCount} number of spots.");
            //display the numbers of spots
        }

    }
}
