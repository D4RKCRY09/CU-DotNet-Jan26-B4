namespace SafeDrivePolicy
{
    class Policy
    {
        public string HolderName { get; set; }
        public decimal Premium {  get; set; }

        public int RiskScore { get; set; }
        public DateTime RenewalDate { get; set; }
    }

    class PolicyTracker
    {
        Dictionary<string,Policy> dict = new Dictionary<string,Policy>();

        public bool AddPolicy(string Id,Policy policy)
        {
            if (dict.ContainsKey(Id)) return false;
            dict.Add(Id, policy);
            return true;
        }
        public void BulkAdjustment()
        {
            foreach (var item in dict.Values)
            {
                if (item.RiskScore > 75) item.Premium += (item.Premium * 0.05M);
            }
        }

        public void CleanUp()
        {
            foreach (var item in dict)
            {
                DateTime temp = item.Value.RenewalDate;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
