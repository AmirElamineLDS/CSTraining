using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_2
{
    class CarBaseClass
    {

        string carName;
        string engine;
        string tyre;
        string soundSystem;

        public CarBaseClass(string carName, string engine, string tyre, string soundSystem)
        {
            this.CarName = carName;
            this.Engine = engine;
            this.Tyre = tyre;
            this.SoundSystem = soundSystem;
        }

        

        public string CarName { get => carName; set => carName = value; }
        public string Engine { get => engine; set => engine = value; }
        public string Tyre { get => tyre; set => tyre = value; }
        public string SoundSystem { get => soundSystem; set => soundSystem = value; }
    }
}
