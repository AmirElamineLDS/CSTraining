using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_2
{
    class Car : CarBaseClass, ICarColor
    {
        
        public Car(string carName, string engine, string tyre, string soundSystem) :base ( carName, engine, tyre, soundSystem) {
            
        }

        public void Color(string color)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Car Colour is : "+ color);
        }

        
    }
}
