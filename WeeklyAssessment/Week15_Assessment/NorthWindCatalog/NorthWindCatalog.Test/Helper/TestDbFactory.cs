using Microsoft.EntityFrameworkCore;
using NorthWindCatalog.Services.Data;

namespace NorthWindCatalog.Tests.Helpers
{
    public static class TestDbFactory
    {
        public static MyAppDbContext Create()
        {
            var options = new DbContextOptionsBuilder<MyAppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new MyAppDbContext(options);
        }
    }
}