using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Superb";
            myCar.mark = "Skoda";
            myCar.regNumber = "123ABC";
            myCar.odo = 400;

            for(int i = 0; i < 10; i++)
            {
                myCar.Drive();
            }

            myCar.ShowOdo();

            Console.ReadLine();
        }
    }
}
