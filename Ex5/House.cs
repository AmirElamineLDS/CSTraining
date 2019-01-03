using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class House : FixedProperty
    {
        double area;

        public House(double area, string location, bool inCity, decimal hValue) :base ( location,  inCity,  hValue)
        {
            this.Area = area;
        }

        public double Area { get => area; set => area = value; }
    }
}
