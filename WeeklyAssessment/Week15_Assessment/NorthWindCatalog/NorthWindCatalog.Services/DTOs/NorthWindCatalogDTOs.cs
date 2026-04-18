namespace NorthWindCatalog.Services.DTOs
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
    //ProductDto(Calculated Field)
    public class ProductDto
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public decimal InventoryValue => UnitPrice * UnitsInStock;
    }
    //CategorySummaryDto
    public class CategorySummaryDto
    {
        public string CategoryName { get; set; }
        public int ProductCount { get; set; }
        public decimal AvgPrice { get; set; }
        public string MostExpensiveProduct { get; set; }
    }

}
