using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace WealthTrackProtfolio.Models
{
    public class Investment
    {
        public int Id { get; set; }
        public string TickerSymbol { get; set; } // e.g., "SILVERBEES"
        [ValidateNever]
        public string AssetName { get; set; }
        [Precision(18, 2)]
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

}
