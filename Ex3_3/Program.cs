using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Something");
            string StringVar = Console.ReadLine();
            string[] revStringVar=StringVar.Split(' ');
            string revVarCh;
            foreach(string varCh in revStringVar)
            {
                revVarCh = "";
                for (int i = varCh.Length - 1; i >= 0; i--)
                {
                    revVarCh = revVarCh + varCh[i];
                    
                }
                
                Console.Write(revVarCh+" ");
            }
            Console.ReadLine();

        }
    }
}
