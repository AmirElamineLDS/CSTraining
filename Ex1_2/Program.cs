using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> carList = new List<Car>();
            Car OneCar;
            bool option = true;
            string reply = "";
            string carName, engine, tyre, soundSystem,color;
            Console.WriteLine("******* Operation Car *********");
            Console.WriteLine("*******************************");

            while (option)
            {
                Console.WriteLine("what's the name of the Car?");
                carName = Console.ReadLine();
                Console.WriteLine("Type of engine?");
                engine = Console.ReadLine();
                Console.WriteLine("Engine Tyre type?");
                tyre = Console.ReadLine();
                Console.WriteLine("what about the sound system?");
                soundSystem = Console.ReadLine();
                Console.WriteLine("finally..");
               // Console.WriteLine("what do you like as color?");
                //color = Console.ReadLine();
                OneCar = new Car(carName, engine, tyre, soundSystem);
                carList.Add(OneCar);
                //OneCar.Color(color);
                Console.WriteLine("that's what we need for now..");
                answer:
                Console.WriteLine("Do you want to add a new car to the list? (yes/no)");
                reply = Console.ReadLine();
                if (reply.ToLower() == "no")
                {
                    option = false;
                }else if (reply.ToLower() == "yes") { }
                else
                {
                    goto answer;
                }
            }

            foreach(Car oneFromList in carList)
            {
                Console.WriteLine("CarName " + oneFromList.CarName);
                Console.WriteLine("Engine " + oneFromList.Engine);
                Console.WriteLine("Tyre " + oneFromList.Tyre);
                Console.WriteLine("SoundSystem " + oneFromList.SoundSystem);
                //Console.WriteLine(oneFromList.Color());
                Console.WriteLine("***************************");


            }

            Console.Read();
            Console.ReadLine();

        }
    }
}
