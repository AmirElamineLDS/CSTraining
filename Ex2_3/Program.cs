using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_3
{
    class Program:I1,I2
    {
        static void Main(string[] args)
        {


            Console.WriteLine();


        }


            string I1.Display()
        {
            return "Display I1";
            //test if Git is working here..
        }
    
        

        string I2.Display()
        {
            return "Display I2";
        }
    }
}
