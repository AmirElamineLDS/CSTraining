using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string yesNoVal = "";

            while (repeat) {
                operations();
                reRead:
                Console.WriteLine("Do you want to make another operation? 'yes/no'");
                yesNoVal = Console.ReadLine();
                if (yesNoVal.ToLower() == "no")
                {
                    repeat = false;
                }else if (yesNoVal.ToLower() == "yes")
                {
                    //nothing
                }
                else
                {
                    Console.WriteLine("You have to write 'yes' or 'no'");
                    goto reRead;
                }
            }
        }

        private static void operations()
        {
            string nbr1;
            string nbr2;
            char op;
            double nbr1D = 0;
            double nbr2D = 0;
            readNbr1:
            Console.WriteLine("Enter the first Integer :");
            nbr1 = Console.ReadLine();
            try
            {
                nbr1D = double.Parse(nbr1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(nbr1 + " is not a valid number.");
                goto readNbr1;
            }
            readNbr2:
            Console.WriteLine("Enter the second Integer :");
            nbr2 = Console.ReadLine();
            try
            {
                nbr2D = double.Parse(nbr2);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(nbr2 + " is not a valid number.");
                Console.WriteLine("Your first Integer is :" + nbr1);
                goto readNbr2;
            }
            Console.WriteLine("1-Addition.");
            Console.WriteLine("2-Substraction.");
            Console.WriteLine("3-Multiplication.");
            Console.WriteLine("4-Division.");
            Console.WriteLine("5-Exit.");
            op = Convert.ToChar(Console.Read());

            string calcResult= calculationFunction(nbr1D, nbr2D, op);
            Console.WriteLine(calcResult);
            if (calcResult == "Goodbye!")
                Environment.Exit(-1);
            
            Console.ReadLine();
            Console.ReadLine();
        }

        public static string calculationFunction(double nbr1, double nbr2, char op)
        {

            switch (op) {
                case '1': return "The Addition of " + nbr1 +" and "+ nbr2 + " is : " + (nbr1 + nbr2);
                case '2': return "The subtraction of " + nbr1 + " and " + nbr2 + " is : " + (nbr1 - nbr2);
                case '3': return "The multiplication of " + nbr1 + " and " + nbr2 + " is : " + (nbr1 * nbr2);
                case '4': return "The division of " + nbr1 + " and " + nbr2 + " is : " + (nbr1 / nbr2);
                case '5': { return "Goodbye!";
                        
                    }
                default: return "This is not a known operations";

            }
               

        }


    }
}
