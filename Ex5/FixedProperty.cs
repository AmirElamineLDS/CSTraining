using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class FixedProperty
    {
        string location;
        bool inCity;
        decimal hValue;

        public FixedProperty(decimal hValue)
        {
            this.HValue = hValue;
        }

        public FixedProperty(string location, bool inCity, decimal hValue)
        {
            this.Location = location;
            this.InCity = inCity;
            this.HValue = hValue;
        }

        public string Location { get => location; set => location = value; }
        public bool InCity { get => inCity; set => inCity = value; }
        public decimal HValue { get => hValue; set => hValue = value; }
    }
}
