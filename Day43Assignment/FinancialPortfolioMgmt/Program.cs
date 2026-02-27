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
        public double Currency { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public double PurchasedPrice { get; set; }
        public double MarketPrice { get; set; }

        public abstract decimal CalculateCurrentValue();
        public virtual string GetInstrumentSummary()
        {
            return $"{InstrumentId} {Name} {Currency} {Quantity} {PurchasedPrice} {MarketPrice}";
        }
    }

    class Equity : FinancialInstrument
    {
        public override decimal CalculateCurrentValue()
        {
            throw new NotImplementedException();
        }
    }

    class Bond : FinancialInstrument
    {
        public override decimal CalculateCurrentValue()
        {
            throw new NotImplementedException();
        }
    }

    class FixedDeposit : FinancialInstrument
    {
        public override decimal CalculateCurrentValue()
        {
            throw new NotImplementedException();
        }
    }

    class MututalFund : FinancialInstrument
    {
        public override decimal CalculateCurrentValue()
        {
            throw new NotImplementedException();
        }
    }

    class Portfolio
    {
        List<FinancialInstrument> instruments 
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

        public double GetTotalPortfolioValue() => instruments.Sum(x => x.MarketPrice);

        public string GetInstrumentById(string id)
        {
            if (dict.ContainsKey(id)) return dict[id].GetInstrumentSummary();
            else return "Not Found";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            
        }
    }
}
