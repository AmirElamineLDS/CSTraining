using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_2
{
    class Program
    {
        List<Double> fiboList=new List<double>();

        static void Main(string[] args)
        {



            Console.WriteLine("Number of iterations?");
            int etr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first number of the Fibonacci series");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second number of the Fibonacci series");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******************************");
            Console.WriteLine("************ start ***********");
            Fibo(first, second, etr);
            Console.WriteLine("");
            Console.WriteLine("************ end. ***********");
            Console.ReadLine();
            Console.ReadLine();


        }

        public static void Fibo(double first, double second, int itrtn)
        {

            if (itrtn == 0)
            {
                Console.Write(first);

            }
            else
            {
                Console.Write(first+" _ ");
                Fibo(second,second+first,itrtn-1);

            }


            
        }

    }
}
