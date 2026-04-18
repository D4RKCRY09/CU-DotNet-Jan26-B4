using Xunit;
using FluentAssertions;
using NorthWindCatalog.Services.DTOs;

namespace NorthWindCatalog.Tests.UnitTests
{
    public class ProductTests
    {
        [Fact]
        public void InventoryValue_Should_Be_Correct()
        {
            var product = new ProductDto
            {
                UnitPrice = 20,
                UnitsInStock = 3
            };

            product.InventoryValue.Should().Be(60);
        }

        [Fact]
        public void InventoryValue_Should_Be_Zero_When_Stock_Is_Zero()
        {
            var product = new ProductDto
            {
                UnitPrice = 100,
                UnitsInStock = 0
            };

            product.InventoryValue.Should().Be(0);
        }
    }
}