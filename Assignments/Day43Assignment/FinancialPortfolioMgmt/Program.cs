using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace FinancialPortfolioMgmt
{
    interface IRiskAssessable
    {
        string GetRiskCategory();
    }

    interface IReportable
    {
        string GenerateReportLine();
    }

    abstract class FinancialInstrument
    {
        public string InstrumentId { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasedPrice { get; set; }
        public decimal MarketPrice { get; set; }

        public abstract decimal CalculateCurrentValue();
        public virtual string GetInstrumentSummary() 
            =>  $"{InstrumentId,-15} {Name,-25} {Currency,-10} {Quantity,-3} {this.CalculateCurrentValue().ToString("C"),-15}";

        public FinancialInstrument(
        string id,
        string name,
        string currency,
        DateOnly purchaseDate,
        int quantity,
        decimal purchasedPrice,
        decimal marketPrice)
        {
            InstrumentId = id;
            Name = name;
            Currency = currency;
            PurchaseDate = purchaseDate;
            Quantity = quantity;
            PurchasedPrice = purchasedPrice;
            MarketPrice = marketPrice;
        }
    }

    class Equity : FinancialInstrument,IRiskAssessable
        {
        public Equity(
    string id,
    string name,
    string currency,
    DateOnly purchaseDate,
    int quantity,
    decimal purchasedPrice,
    decimal marketPrice,
    string ticker) : base(id, name, currency, purchaseDate, quantity, purchasedPrice, marketPrice) {}

        public override decimal CalculateCurrentValue() => Quantity * (decimal)MarketPrice;

        public string GetRiskCategory() => "Low";
    }
    class Bond : FinancialInstrument,IRiskAssessable
    {
        public Bond(
    string id,
    string name,
    string currency,
    DateOnly purchaseDate,
    int quantity,
    decimal purchasedPrice,
    decimal marketPrice)
    : base(id, name, currency, purchaseDate, quantity, purchasedPrice, marketPrice)
        {

        }
        public override decimal CalculateCurrentValue() => Quantity * (decimal)MarketPrice;
        public string GetRiskCategory() => "High";

    }

    class FixedDeposit : FinancialInstrument
    {
        public FixedDeposit(
    string id,
    string name,
    string currency,
    DateOnly purchaseDate,
    int quantity,
    decimal purchasedPrice,
    decimal marketPrice
            )
    : base(id, name, currency, purchaseDate, quantity, purchasedPrice, marketPrice)
        {

        }
        public override decimal CalculateCurrentValue() => Quantity * (decimal)MarketPrice;
    }

    class MutualFund : FinancialInstrument, IRiskAssessable, IReportable
    {
        public MutualFund(
    string id,
    string name,
    string currency,
    DateOnly purchaseDate,
    int quantity,
    decimal purchasedPrice,
    decimal marketPrice
            )
    : base(id, name, currency, purchaseDate, quantity, purchasedPrice, marketPrice)
        {

        }
        public override decimal CalculateCurrentValue() => Quantity * (decimal)MarketPrice;

        public string GetRiskCategory() => "Medium";

        public string GenerateReportLine()
        {
            return "MutualFund | " + Name + " | " +
                   CalculateCurrentValue().ToString("C");
        }
    }

    class Portfolio
    {
        public List<FinancialInstrument> instruments 
            = new List<FinancialInstrument>();
        
        Dictionary<string,FinancialInstrument> dict 
            = new Dictionary<string,FinancialInstrument>();

        public bool AddInstrument(FinancialInstrument f)
        {
            if(!dict.ContainsKey(f.InstrumentId))
            {
                instruments.Add(f);
                dict.Add(f.InstrumentId, f);
                return true;
            }
            return false;
        }

        public bool RemoveInstrument(string id)
        {
            if(dict.ContainsKey(id))
            {
                var temp = dict[id];
                instruments.Remove(temp);
                dict.Remove(id);
                return true;
            }
            return false;
        }

        public decimal GetTotalPortfolioValue() 
            => instruments.Sum(x => x.MarketPrice);

        public string GetInstrumentById(string id)
        {
            if (dict.ContainsKey(id)) return dict[id].GetInstrumentSummary();
            else return "Not Found";
        }
        public string GetInstrumentsByRisk()
        {
            Dictionary<string,int> count = new Dictionary<string,int>();
            foreach(var instrument in instruments)
            {
                string temp = "";
                if (instrument is IRiskAssessable)
                {
                    var a = instrument as IRiskAssessable;
                    temp = a.GetRiskCategory();

                }
                else temp = "Low";
                if (!count.ContainsKey(temp)) count.Add(temp, 1);
                else count[temp]++;
            }

            var risk = count.Select(a => new string($"{a.Key} = {a.Value}"));
            return string.Join("\n", risk);
        }

        public string GroupByInstrumentType()
        {
            var group = instruments.GroupBy(x => x.GetType())
                        .Select(a => new 
                        {
                            a.Key,
                            Total = a.Sum(s => s.PurchasedPrice),
                            Current = a.Sum(s => s.MarketPrice)
                        }).ToList();

            string ans = string.Empty;
            foreach(var kvp in group)
            {
                string temp = $"{kvp.Key}".Substring(23);
                ans += $"Instrument Type: {temp}\n" +
                    $"Total Investment: {kvp.Total}\n" +
                    $"Current Value : {kvp.Current}\n" +
                    $"Profit/Loss : {Math.Abs(kvp.Current - kvp.Total)}\n\n";
            }

            return ans;
        }
    }

    class Transaction
    {
        public int TranscationId { get; set; }
        public int InstrumentId { get; set; }
        public string Type { get; set; }
        public int Units { get; set; }
        public DateOnly Date { get; set; }
    }

    class ReportGenerator
    {

        public string ConsoleReport(Portfolio p) => p.GroupByInstrumentType(); 

        public void GenerateFileReport(Portfolio p)
        {
            string filepath = $@"../../../PortfolioReport_{DateOnly.FromDateTime(DateTime.Now)}";

            using StreamWriter writer = new StreamWriter(new FileStream(filepath,FileMode.Create));

            writer.WriteLine($"{"InstrumentId",-15} {"Name",-25} {"Currency",-5} {"Quantity",-3} {"Total",-15}");

            foreach(var instrument in p.instruments)
            {
                writer.WriteLine(instrument.GetInstrumentSummary());
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Portfolio p = new Portfolio();

            // High-growth Tech
            Equity apple = new Equity("EQ-001", "Apple Inc.", "USD", new DateOnly(2023, 1, 15), 10, 150.00m, 189.42m, "AAPL");

            // Industrial Giant
            Equity caterpillar = new Equity("EQ-002", "Caterpillar Inc.", "USD", new DateOnly(2023, 5, 20), 5, 240.50m, 322.10m, "CAT");

            // Government Debt
            Bond treasury = new Bond("BND-01", "US 10Y Treasury", "USD", new DateOnly(2024, 1, 05), 100, 98.20m, 101.50m);

            // Corporate Debt
            Bond fordBond = new Bond("BND-02", "Ford Motor Co Bond", "USD", new DateOnly(2023, 11, 12), 50, 95.00m, 94.20m);

            // Long-term Savings
            FixedDeposit hdfcFD = new FixedDeposit("FD-101", "HDFC 3-Year FD", "INR", new DateOnly(2023, 08, 10), 1, 50000.00m, 54500.00m);

            // Short-term Liquidity
            FixedDeposit barclaysFD = new FixedDeposit("FD-102", "Barclays 6-Month", "GBP", new DateOnly(2024, 02, 01), 1, 10000.00m, 10250.00m);

            // Index Tracking
            MutualFund vtsax = new MutualFund("MF-500", "Vanguard Total Stock", "USD", new DateOnly(2022, 12, 15), 250, 85.30m, 112.15m);

            // Sector Specific (Healthcare)
            MutualFund fidelityHealth = new MutualFund("MF-501", "Fidelity Health Care", "USD", new DateOnly(2023, 04, 22), 120, 24.10m, 26.80m);


            // 1. Equities
            p.AddInstrument(apple);
            p.AddInstrument(caterpillar);

            // 2. Bonds
            p.AddInstrument(treasury);
            p.AddInstrument(fordBond);

            // 3. Fixed Deposits
            p.AddInstrument(hdfcFD);
            p.AddInstrument(barclaysFD);

            // 4. Mutual Funds
            p.AddInstrument(vtsax);
            p.AddInstrument(fidelityHealth);

            ReportGenerator generator = new ReportGenerator();

            Console.WriteLine(p.GetInstrumentById("MF-501"));
            Console.WriteLine(p.GetInstrumentById("MF-502")); ;


            Console.WriteLine(generator.ConsoleReport(p));

            Console.WriteLine($"Overall Portfolio Value : {p.GetTotalPortfolioValue()}");

            Console.WriteLine(p.GetInstrumentsByRisk());
            generator.GenerateFileReport(p);

        }
    }
}
