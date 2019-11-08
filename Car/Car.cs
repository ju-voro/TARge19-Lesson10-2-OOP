using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        public string model;
        public string mark;
        public string color;
        public string regNumber;
        public int odo = 0;

        public void Drive()
        {
            odo += 100;
        }

        public void ShowOdo()
        {
            Console.WriteLine($"The car {model} {mark} {regNumber} has driven {odo} km.");
        }

    }
}
