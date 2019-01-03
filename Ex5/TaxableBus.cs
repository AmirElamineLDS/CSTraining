using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class TaxableBus:Bus,ITaxable
    {
        public TaxableBus(int numberOfSeats, int regNumber, double maxVelocity, decimal bValue) :base( numberOfSeats, regNumber,  maxVelocity, bValue)
        {

        }

        public string TaxValue()
        {
            return "Tax for Bus = " + (Convert.ToDecimal(BValue / 100) * (Convert.ToDecimal(0.2) * NumberOfSeats));
        }


    }
}
