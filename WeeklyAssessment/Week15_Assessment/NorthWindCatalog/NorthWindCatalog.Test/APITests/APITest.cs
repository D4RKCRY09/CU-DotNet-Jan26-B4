using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NorthWindCatalog.Services.Contriollers;
using NorthWindCatalog.Services.DTOs;
using NorthWindCatalog.Services.Models;
using NorthWindCatalog.Services.Repository;
using Xunit;

namespace NorthWindCatalog.Tests.ApiTests
{
    public class CategoriesApiControllerTests
    {
        [Fact]
        public async Task Get_Should_Return_Ok()
        {
            var repo = new Mock<ICategoryRepository>();
            var mapper = new Mock<IMapper>();

            repo.Setup(r => r.GetAllAsync())
                .ReturnsAsync(new List<Category>());

            mapper.Setup(m => m.Map<IEnumerable<CategoryDto>>(It.IsAny<IEnumerable<Category>>()))
                .Returns(new List<CategoryDto>());

            var controller = new CategoriesApiController(repo.Object, mapper.Object);

            var result = await controller.Get();

            result.Should().BeOfType<OkObjectResult>();
        }
    }
}