using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class Vehicle
    {
        int regNumber;
        double maxVelocity;
        decimal bValue;

        public Vehicle(int regNumber, double maxVelocity, decimal bValue)
        {
            this.RegNumber = regNumber;
            this.MaxVelocity = maxVelocity;
            this.BValue = bValue;

        }
        public Vehicle()
        {
         
        }
        public int RegNumber { get => regNumber; set => regNumber = value; }
        public double MaxVelocity { get => maxVelocity; set => maxVelocity = value; }
        public decimal BValue { get => bValue; set => bValue = value; }
    }
}
