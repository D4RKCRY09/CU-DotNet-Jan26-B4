using System.Net.NetworkInformation;

namespace GlobalFreightTrackingSystem
{
    abstract class Shipment
    {
        public string TrackingID { get; set; }
        public double Weight { get; set; }
        public string Destination { get; set; }

        private bool isFragile;

        public bool IsFragile
        {
            get { return isFragile; }
            set
            {
                if (value == true) isFragile = true;
                else isFragile = false;
            }
        }

        private bool reinforced;

        public bool ReInforced
        {
            get { return reinforced; }
            set
            {
                if (value == true) reinforced = true;
                else reinforced = false;
            }
        }


        public abstract void ProcessShipment();
    }


    class ExpressShipment : Shipment
    {

        public override void ProcessShipment()
        {
            if (this.Weight > 1000) Console.WriteLine($"Requires Heavy Weight Permit for ID {this.TrackingID}");
            else Console.WriteLine($"Currently processing ExpressShipment ID {this.TrackingID}");
        }
    }

    class HeavyFreight : Shipment
    {
        public override void ProcessShipment()
        {
            Console.WriteLine($"Currently processing HeavyShipment ID {this.TrackingID}");

        }
    }

    class RestrictedDestinationException : Exception
    {
        public RestrictedDestinationException(string message) : base(message) { }
    }

    class InsecurePackagingException : Exception
    {
        public InsecurePackagingException(string message) : base(message) { }
    }

    public interface ILoggable
    {
        void SaveLog(string message);
    }

    public class LogManager : ILoggable
    {
        public void SaveLog(string message)
        {
            using StreamWriter sw = new StreamWriter(@"../../../shipment_audit.log", true);
            {
                sw.WriteLine($"{DateTime.Now} : {message}");
            }
        }
    }
    internal class GlobalFreightTrackingSystem
    {
        static void CheckShipment(Shipment s)
        {
            LogManager log = new LogManager();

            string[] restrictedLocations = { "North Pole", "unknown island" };
            string status = "Success";

            try
            {
                s.ProcessShipment();
                if (s.Weight <= 0) throw new ArgumentOutOfRangeException();
                else if (s is ExpressShipment && s.Weight > 1000)
                    status = "Excess Weight for Express";
                if (s.IsFragile && !s.ReInforced)
                    throw new InsecurePackagingException("Fragile Item not reinforced");
                else if (s.Destination == null || restrictedLocations.Contains(s.Destination))
                    throw new RestrictedDestinationException("Security Alert");

            }
            catch (InsecurePackagingException ex)
            {
                status = ex.Message;
            }
            catch (RestrictedDestinationException ex)
            {
                status = ex.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                status = "Data Entry Error";
            }
            finally
            {
                log.SaveLog($"{s.TrackingID,5} {s.Destination,15} {s.Weight,6} {status,30}");
            }
        }
        static void Main(string[] args)
        {
            List<Shipment> shipmentList = new List<Shipment>();
            shipmentList.Add(
                new ExpressShipment()
                {
                    TrackingID = "IND01",
                    Destination = "India",
                    Weight = 300,
                }
                );
            shipmentList.Add(
                new ExpressShipment()
                {
                    TrackingID = "USA01",
                    Destination = "USA",
                    Weight = 1200,
                }
                );
            shipmentList.Add(
                new HeavyFreight()
                {
                    TrackingID = "NP01",
                    Destination = "North Pole",
                    Weight = 500,
                }
                );
            shipmentList.Add(
                new ExpressShipment()
                {
                    TrackingID = "NZ01",
                    Destination = "New Zealand",
                    Weight = 400,
                    IsFragile = true,
                }
                );
            shipmentList.Add(
                new ExpressShipment()
                {
                    TrackingID = "UK01",
                    Destination = "United Kingdom",
                    Weight = 0,
                    IsFragile = true,
                    ReInforced = true,
                }
                );

            foreach (var s in shipmentList)
            {
                CheckShipment(s);
            }
        }
    }
}
