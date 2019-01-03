using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tabInt = { 1, 4 , 2, 8, 3,5 ,9 };
            string duplicata="";
            for (int i = 0; i<tabInt.Length; i++)
            {

                for (int j = 0; j < tabInt.Length; j++)
                {
                    if (j != i)
                    {
                        if(tabInt[i]== tabInt[j])
                        {
                            Console.WriteLine("we found a duplicata for this item => "+ tabInt[i] + " in position :"+ (j+1));
                            Console.ReadLine();
                            Environment.Exit(-1);
                        }
                        
                    }

                }
                    duplicata = duplicata +" | "+ tabInt[i];
            }
            Console.WriteLine("This is the given array : ");
            Console.WriteLine(duplicata);
            Console.WriteLine("No duplication Found for this array ");
            Console.ReadLine();

        }
    }
}
