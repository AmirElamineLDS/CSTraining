using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex5
{
    public class Bus : Vehicle
    {
        int numberOfSeats;
        //int regNumber;
        //double maxVelocity;
        //decimal value;
        public Bus(int numberOfSeats, int regNumber, double maxVelocity, decimal bValue): base ( regNumber, maxVelocity, bValue)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
    }
}
