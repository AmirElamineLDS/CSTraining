using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Something");
            string StringVar = Console.ReadLine();
            string revStringVar="";
            for(int i= StringVar.Length-1; i >= 0; i--)
            {
                revStringVar += StringVar[i];
                Console.WriteLine(revStringVar);
            }
            Console.WriteLine("What you entered '"+ StringVar+ "' and its reverse is '" + revStringVar+"'");
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
