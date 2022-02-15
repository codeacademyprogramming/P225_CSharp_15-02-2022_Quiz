using System;
using System.Collections.Generic;
using System.Text;

namespace P225HomeWork1.Models
{
    class Bycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
