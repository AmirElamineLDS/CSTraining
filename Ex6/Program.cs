using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] tabInt = { 1, 4, 2, 8, 3, 5, 9 };
            //int[] tabInt = { 2, 2, 2 };
            int[] tabInt = { 3, 2, 2 };
            
            int nbr = 0;
            List<string> tabString=new List<string>();
            for (int i=0; i < tabInt.Length; i++)
            {
                for (int j = i+1; j < tabInt.Length; j++)
                {
                    
                    if(tabInt[i] == tabInt[j])
                    {
                        tabString.Add("("+i+","+j+") ");
                        nbr++;
                        
                    }
                }

            }
            if (tabString.Count != 0)
            {
            //    Console.Write(tabString.Count + " identical pairs of indices ");
            //foreach (string s in tabString)
            //    {

            //        Console.Write(s);

            //    }
                Console.Write(tabString.Count + " identical pairs of indices ");
                for (int i = 0; i < tabString.Count; i++)
                {
                    if (tabString.Count == 1)
                    {
                        Console.Write(tabString[i]);
                    }
                    else
                    if (i == tabString.Count - 1)
                    {
                        Console.Write("and "+ tabString[i]);
                    }
                    else
                    if (i < tabString.Count - 2)
                    {
                        Console.Write(tabString[i]+", ");
                    }else
                        Console.Write(tabString[i]);
                }
            }
            else
                Console.WriteLine("No identical pairs ");

            Console.ReadLine();
        }
    }
}
