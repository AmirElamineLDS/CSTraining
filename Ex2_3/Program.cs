using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Interface1_2 interface12 = new Interface1_2();
            
            Console.WriteLine(((I1)interface12).Display());

            Console.WriteLine(((I2)interface12).Display());

            Console.ReadLine();
        }


          
    }
}
