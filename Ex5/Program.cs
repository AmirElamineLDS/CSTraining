using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaxable [] taxable= { };
            string option = "";
            int i = 0;

            double area;
            string location;
            bool inCity=true;
            decimal valueHouse;

            int numberOfSeats;
            int regNumber;
            double maxVelocity;
            decimal valueBus;

            string addOp = "";

            Console.WriteLine("Do you want to taxes for a house or bus?");
            addHouseOrBus:
            Console.WriteLine("**Please write 'house' or 'bus'?");
            option = Console.ReadLine();
            if (option.ToLower() ==  "house")
            {
                areaVal:
                Console.WriteLine("Area Value :");
                
                try
                {
                    area = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Area value is not a valid number.");
                    goto areaVal;
                }
                locationVal:
                Console.WriteLine("Location Value :");
                location = Console.ReadLine();
                if (location=="")
                {
                    Console.WriteLine("You forgot to Write a Location value");
                    goto locationVal;
                }
                yesNO:
                Console.WriteLine("In city 'yes' or 'no' :");
                try
                {
                    string incityVal = Console.ReadLine();
                    if (incityVal.Trim().ToLower()=="yes")
                    inCity = true;
                    else
                        if (incityVal.Trim().ToLower() == "no")
                        inCity = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Write 'yes' or 'no'!");
                    goto yesNO;
                }
                houseVal:
                Console.WriteLine("House value :");
                try
                {
                    valueHouse = decimal.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("House value is not a valid number.");
                    goto houseVal;
                }

                taxable =new ITaxable[] { new TaxableHouse(area, location, inCity, valueHouse) };
                
                Console.WriteLine("Do you want to make another operation? 'yes/no'");
                addOp=Console.ReadLine();
                if (addOp == "yes")
                {
                    goto addHouseOrBus;
                }
                else if (addOp == "no")
                {
                    Console.WriteLine("Loading your data...");
                    goto showData;
                }
            }
            else if (option.ToLower() == "bus")
            {
                //nothing
                //int numberOfSeats;
                //int regNumber;
                //double maxVelocity;
                //decimal valueBus;

                numberOfSeatsVal:
                Console.WriteLine("Number of seats :");

                try
                {
                    numberOfSeats = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Number of seats value is not valid.");
                    goto numberOfSeatsVal;
                }
                regNumberVal:
                Console.WriteLine("Registration Number :");
                try
                {
                    regNumber = int.Parse(Console.ReadLine());
                }catch(Exception ex)
                {
                    Console.WriteLine("Registration Number is not valid.");
                    goto regNumberVal;
                }
                maxVelocityVal:
                Console.WriteLine("Velocity :");
                try
                {
                    maxVelocity = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Velocity value is not valid");
                    goto maxVelocityVal;
                }
                BusVal:
                Console.WriteLine("Bus value :");
                try
                {
                    valueBus = decimal.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bus value is not a valid number.");
                    goto BusVal;
                }

                taxable = new ITaxable[] { new TaxableBus(numberOfSeats, regNumber, maxVelocity, valueBus) };

                Console.WriteLine("Do you want to make another operation? 'yes/no'");
                addOp = Console.ReadLine();
                if (addOp == "yes")
                {
                    goto addHouseOrBus;
                }
                else if (addOp == "no")
                {
                    Console.WriteLine("Loading your data...");
                    goto showData;
                }
            }
            else
            {
                Console.WriteLine("Please check if wrot 'house' or 'bus'?");
                goto showData;
            }

            showData:
            foreach(ITaxable iTaxable in taxable)
            {
                Console.WriteLine("Line "+(i+1)+" : "+iTaxable.TaxValue());
                i++;
            }
            Console.ReadLine();
        }
    }

}
