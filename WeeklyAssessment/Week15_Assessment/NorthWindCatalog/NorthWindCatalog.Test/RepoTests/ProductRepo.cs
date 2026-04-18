using FluentAssertions;
using NorthWindCatalog.Services.Data;
using NorthWindCatalog.Services.Models;
using NorthWindCatalog.Services.Repository;
using NorthWindCatalog.Tests.Helpers;
using Xunit;

namespace NorthWindCatalog.Tests.RepositoryTests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public async Task GetByCategoryIdAsync_Should_Return_Products()
        {
            var context = TestDbFactory.Create();

            context.Products.Add(new Product
            {
                ProductName = "Tea",
                CategoryId = 1,
                UnitPrice = 10,
                UnitsInStock = 5
            });

            context.SaveChanges();

            var repo = new ProductRepository(context);

            var result = await repo.GetByCategoryIdAsync(1);

            result.Should().HaveCount(1);
        }

        [Fact]
        public async Task GetByCategoryIdAsync_Should_Return_Empty_When_No_Data()
        {
            var context = TestDbFactory.Create();
            var repo = new ProductRepository(context);

            var result = await repo.GetByCategoryIdAsync(999);

            result.Should().BeEmpty();
        }
    }
}