using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //int number=568,x;

            //x = number % 10;
            //string number = "153";

            //char[] nbrs = SplitStr(number);
            //Console.Write((char)nbrs[0]);
            //Console.WriteLine((char)number[0]);


            Console.WriteLine("Armstrong numbers");
            Console.Write("Search will be from '0' to ");
            string number = Console.ReadLine();
            int theIntNumber = int.Parse(number);
            
            for (int i = 1; i <= theIntNumber; i++)
            {

               armstrng(i);
                
            }
            Console.Write("Search ended!");
            Console.ReadLine();
        }

        private static char[] SplitStr(string number)
        {
            List<char> tabChar = new List<char>();
            foreach(char oneChr in number)
            {
                tabChar.Add(oneChr);
            }
            return tabChar.ToArray();
        }
        private static void armstrng(int number)
        {
            int remainder, sum = 0;
            
            //number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;

            }
            if (sum == number)
            {
                Console.WriteLine(number+" _ is an Armstrong Number");
                
            }
            
            
        }
    }
}
