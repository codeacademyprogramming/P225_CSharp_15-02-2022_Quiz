using System;
using System.Collections.Generic;
using System.Text;

namespace P225HomeWork1.Models
{
    abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Brand} {Color} {Millage}");
        }
        public abstract void Drive(double km);
    }
}
