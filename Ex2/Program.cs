using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////write ////
            string fileName = @"C:\Users\AELAMINE\source\repos\CSTraining\Ex2\BinaryFile.bin";
            WriteInByteFile(fileName);


            ////read ////

            ReadFromByteFile(fileName);

            Console.ReadLine();




        }

        private static void ReadFromByteFile(string fileName)
        {
            FileStream fileStreamRead = new FileStream(fileName, FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fileStreamRead);
            string readline = binaryReader.ReadString() + binaryReader.ReadString() + binaryReader.ReadString();
            Console.WriteLine(readline);
        }

        private static void WriteInByteFile(string fileName)
        {
            string UserName;
            string userAge;
            string userYB;

            Console.WriteLine("Write your name");
            UserName = Console.ReadLine();

            Console.WriteLine("Write your age");
            userAge = Console.ReadLine();
            byte userAgeByte = byte.Parse(userAge);
            Console.WriteLine("you typed " + userAgeByte);
            Console.WriteLine("Write your year of birth");
            userYB = Console.ReadLine();
            int userTBByte = int.Parse(userYB);
            Console.WriteLine("you typed " + userTBByte);

            
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            BinaryWriter bwStream = new BinaryWriter(fileStream, ASCIIEncoding.ASCII);


            bwStream.Write("Your Name is: " + UserName);
            bwStream.Write(", Age :" + userAgeByte);
            bwStream.Write(" & Birth year :" + userTBByte);
            bwStream.Close();
            fileStream.Close();
            
        }
    }
}
