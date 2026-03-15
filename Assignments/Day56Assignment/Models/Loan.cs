using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Day56Assignment.Models
{
    public class Loan
    {
        public int Id { get; set; }
        [DisplayName("Borrower Name")]
        public string BorrowerName { get; set; }
        public string LenderName { get; set; }
        [Range(1, 50000)]
        public double Amount { get; set; }
        public bool IsSettled { get; set; }

    }
}
