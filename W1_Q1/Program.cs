using System;

namespace W1_Q1
{
    class Vehicle

    {
        protected double ThreeHours = 0;
        protected double ExtraHour = 0;
        protected double MaxCharges; 
        
        public double PrintParkingCharges(double hours)
        {
            double Cost = 0;
                if (hours <= 3)
                {
                    Cost=ThreeHours;
                }
                else if (hours > 3)
                {
                    Cost = ThreeHours + (hours - 3) * ExtraHour;

                    if (Cost > MaxCharges)
                    {
                        Cost = MaxCharges;
                    }
                }
            return Cost;
            

        }
    }
    class Bikes : Vehicle
    {
        public Bikes()
        {
            ThreeHours = 2;
            ExtraHour = 0.5;
            MaxCharges = 10;
        }

    }

    class Cars : Vehicle
    {
        public Cars()
        {
            ThreeHours = 4;
            ExtraHour = 1;
            MaxCharges = 20;
        }

    }
    class Buses : Vehicle
    {
        public Buses()
        {
            ThreeHours = 6;
            ExtraHour = 1.5;
            MaxCharges = 30;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Bikes bike = new Bikes();
            Cars car = new Cars();
            Buses bus = new Buses();
            Console.WriteLine("What is your Ride \n" +
                "Press 1 for Bike\n" +
                "Press 2 for Car\n" +
                "Press 3 for Bus\n");
           double Num = Convert.ToDouble(Console.ReadLine());
            switch (Num)
            {
                case 1:
                    Console.WriteLine("\nFare Charges For Bike for Yesterday\n"+bike.PrintParkingCharges(24));
                    Console.WriteLine("\nFare Charges For Bike for 1 Hour\n" + bike.PrintParkingCharges(1));
                    Console.WriteLine("\nFare Charges For Bike for 5 Hours\n" + bike.PrintParkingCharges(5));
                    break;
                case 2:
                    Console.WriteLine("\nFare Charges For Car for Yesterday\n" + car.PrintParkingCharges(24));
                    Console.WriteLine("\nFare Charges For Car for 1 Hour\n" + car.PrintParkingCharges(1));
                    Console.WriteLine("\nFare Charges For Car for 5 Hours\n" + car.PrintParkingCharges(5));
                    break;
                case 3:
                    Console.WriteLine("\nFare Charges For Bus for Yesterday\n" + bus.PrintParkingCharges(24));
                    Console.WriteLine("\nFare Charges For Bus for 1 Hour\n" + bus.PrintParkingCharges(1));
                    Console.WriteLine("\nFare Charges For Bus for 5 Hours\n" + bus.PrintParkingCharges(5));
                    break;
                default:
                    Console.WriteLine("\nYou have entered the wrong Number\n");
                    break;
            }

        }
    }


}
