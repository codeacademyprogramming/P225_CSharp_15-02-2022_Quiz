using System;
using System.Collections.Generic;
using System.Text;

namespace P225HomeWork1.Models
{
    class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1km { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Brand} {Color} {Millage} {FuelCapacity} {FuelFor1km} {CurrentFuel}");
        }

        public override void Drive(double km)
        {
            if ((km * FuelFor1km) <= CurrentFuel)
            {
                CurrentFuel -= (km * FuelFor1km);
                Millage += km;
            }
            else
            {
                Console.WriteLine("Getmey Isdeyiniz Yere Qeder Benzin Catmir");
            }
        }
    }
}
