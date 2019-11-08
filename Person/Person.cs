using System;

namespace Person
{
    public class Person
    {
        //fileds
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}.");
        }

    }
}
