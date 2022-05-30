using System;
using System.Collections.Generic;
using System.Text;

namespace Class_inheritence
{
    internal class Car : Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;
        public void AddFuel(int fuelLitr)
        {
            if (fuelLitr+CurrentFuel <= FuelCapacity)
            {
                CurrentFuel += fuelLitr;
                Console.WriteLine($"Hazirki Benzin {CurrentFuel} L");
            }
            else
            {
                Console.WriteLine($"{fuelLitr} L benzin elave edile bilmir !! Max kapasite gecilemez!!");
            }
        }
    }
}
