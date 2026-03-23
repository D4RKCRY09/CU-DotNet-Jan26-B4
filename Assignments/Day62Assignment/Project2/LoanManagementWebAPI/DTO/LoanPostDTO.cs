namespace LoanManagementWebAPI.DTO
{
    public class LoanPostDTO
    {
        public string BorrowerName { get; set; }
        public decimal Amount { get; set; }
        public int LoanTermMonths { get; set; }
        public bool IsApproved { get; set; }
    }
}
