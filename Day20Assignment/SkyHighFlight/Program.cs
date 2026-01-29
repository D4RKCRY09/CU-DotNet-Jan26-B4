namespace SkyHighFlight
{
    class Flight :IComparable<Flight>
    {
        public string FlightNumber { get; set; }
        public decimal Price { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime DepartureTime { get; set; }

        public int CompareTo(Flight? flight)
        {
            return this.Price.CompareTo(flight.Price);
        }

        public override string ToString()
        {
            return $"{FlightNumber} {Price} {Duration} {DepartureTime}";
        }
    }
    class DurationComparer : IComparer<Flight>
    {
        public int Compare(Flight f1,Flight f2)
        {
            return f1.Duration.CompareTo(f2.Duration); 
        }
    }

    class DepartureComparer : IComparer<Flight>
    {
        public int Compare(Flight? f1, Flight? f2)
        {
            return f1.DepartureTime.CompareTo(f2.DepartureTime);
        }
    }
    internal class Program
    {
        static void PrintList(List<Flight> flights)
        {
            for (int i = 0; i < flights.Count; i++)
            {
                Console.WriteLine(flights[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<Flight> flights = new List<Flight>()
            {
                new Flight()
                {
                    FlightNumber = "1",
                    Price = 10000,
                    Duration = new TimeSpan(2,0,0),
                    DepartureTime = new DateTime(2026,01,28,12,00,00)
                },
                new Flight()
                {
                    FlightNumber = "2",
                    Price = 50000,
                    Duration = new TimeSpan(3,0,0),
                    DepartureTime = new DateTime(2026,01,28,3,00,00)
                },
                new Flight()
                {
                    FlightNumber = "3",
                    Price = 20000,
                    Duration = new TimeSpan(3,15,0),
                    DepartureTime = new DateTime(2026,01,28,5,00,00)
                }
            };

            flights.Sort();
            Console.WriteLine("Economy View :-");
            PrintList(flights);

            Console.WriteLine("Business Runner View :-");
            flights.Sort(new DurationComparer());
            PrintList(flights);

            Console.WriteLine("Early Bird View :-");
            flights.Sort(new DepartureComparer());
            PrintList(flights);
        }
    }
}
