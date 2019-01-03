using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class TaxableHouse : House, ITaxable
    {
        public TaxableHouse(double area, string location, bool inCity, decimal hValue) : base(area, location, inCity, hValue) { }

        public string TaxValue()
        {
            return "Tax for House = " + ((HValue * Convert.ToDecimal(0.28)) / (HValue * Convert.ToDecimal(0.18)));
        }

    }
}
