using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Week4
{
    class OlaDriver
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? VehicleNo { get; set; }

        public List<Ride>? Rides;

        public static int localid = 1;
        public OlaDriver(string? name, string? vehicleNo, List<Ride>? rides)
        {
            Id = localid;
            Name = name;
            VehicleNo = vehicleNo;
            Rides = rides;
            localid++;
        }
        public override string ToString()
        {
            string a = $"{Id} {Name} {VehicleNo} :-\n";
            decimal totalfare = 0;
            foreach (var i in Rides)
            {
                a += " ";
                a += i;
                a += "\n";
                totalfare += i.Fare;
            }
            return $"{a}\n Total Fare =  {totalfare}";
        }
    }

    class Ride
    {
        public int RideId { get; set; }

        public string? From { get; set; }
        public string? To { get; set; }
        public decimal Fare { get; set; }

        static int localID = 1;
        public Ride(int rideId, string? from, string? to, decimal fare)
        {
            RideId = OlaDriver.localid*100 + localID;
            From = from;
            To = to;
            Fare = fare;
            localID++;
        }
        public override string ToString()
        {
            return $"{RideId} {From} {To} {Fare}";
        }
    }

    class App
    {
        static void Main(string[] args)
        {
            List<OlaDriver> drivers = new List<OlaDriver>()
            {
                new OlaDriver("Aaroh","DL11793H",
                    new List<Ride>()
                    {
                        new Ride(101,"Mohali","Chandigarh",100),
                        new Ride(102,"Mohali","Chandigarh",100)
                    }
                ),
                new OlaDriver("Mayank","DL11793H",
                    new List<Ride>()
                    {
                        new Ride(101,"Mohali","Chandigarh",100),
                        new Ride(102,"Mohali","Kharar",150)
                    }
                )
            };
            foreach (OlaDriver driver in drivers)
            {
                Console.WriteLine(driver);
                Console.WriteLine();
            }
        }

    }
}
