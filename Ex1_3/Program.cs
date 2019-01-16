using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////write ////

            string fileName = @"C:\Users\AELAMINE\source\repos\CSTraining\Ex1_3\example.txt";
            WriteInByteFile(fileName);

            ////read ////

            ReadFromByteFile(fileName);

            Console.ReadLine();

        }


        private static void WriteInByteFile(string fileName)
        {
            

            TextWriter tw = new StreamWriter(fileName);

            

            tw.WriteLine(DateTime.Now);
            tw.Close();
            

        }

        private static void ReadFromByteFile(string fileName)
        {
           

            TextReader tr = new StreamReader(fileName);
            Console.WriteLine(tr.ReadLine());
            tr.Close();

        }

    }
}
