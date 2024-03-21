using Spg.CifBazar.Application.Services;
using Spg.CifBazar.Application.Services.Mock;
using Spg.CifBazar.Application.Test.Helpers;
using Spg.CifBazar.DomainModel.Dtos;
using Spg.CifBazar.DomainModel.Exceptions;
using Spg.CifBazar.Infrastructure;
using Spg.CifBazar.Repository;

namespace Spg.CifBazar.Application.Test;

public class ProductServiceTests
{
    [Fact]
    public void ShouldCreateProduct_WhenParametersAreValid()
    {
        using (CifBazarContext db = DatabaseCreationHelper.CreateMemoryDb())
        {
            // Arrange
            db.Shops.AddRange(DatabaseUtilities.GetSeedingShops());
            db.SaveChanges();

            CreateProductCommand command = new CreateProductCommand(
                "Testprodukt", 
                "Testbeschreibung", 
                new DateTime(2024, 03, 05), 
                5);

            // Act
            ProductDto actual = new ProductService(
                new CategoryRepository(db),
                new ProductRepository(db),
                new ProductRepository(db),
                new DateTimeServiceMock(),
                new ProductNumberServiceMock())
                .Create(command);

            // Assert
            Assert.Equal(16, db.Products.Count());
            Assert.Equal(new Guid("f575a460-8337-4e7b-a0ab-961b4621fdd8"), actual.ProductNumber);
        }
    }

    [Fact]
    public void ShouldThrowValidationException_WhenCategoryNOTFound()
    {
        using (CifBazarContext db = DatabaseCreationHelper.CreateMemoryDb())
        {
            // Arrange
            db.Shops.AddRange(DatabaseUtilities.GetSeedingShops());
            db.SaveChanges();

            CreateProductCommand command = new CreateProductCommand(
                "Testprodukt",
                "Testbeschreibung",
                new DateTime(2024, 03, 05),
                99999);

            // Act + Assert
            Assert.Throws<ProductCreateValidationException>(() => new ProductService(
                new CategoryRepository(db),
                new ProductRepository(db),
                new ProductRepository(db),
                new DateTimeServiceMock(),
                new ProductNumberServiceMock())
                .Create(command));
        }
    }

    [Fact]
    public void ShouldThrowValidationException_WhenExpiryDateNOT14DaysInFuture()
    {
        using (CifBazarContext db = DatabaseCreationHelper.CreateMemoryDb())
        {
            // Arrange
            db.Shops.AddRange(DatabaseUtilities.GetSeedingShops());
            db.SaveChanges();

            CreateProductCommand command = new CreateProductCommand(
                "Testprodukt",
                "Testbeschreibung",
                new DateTime(2024, 02, 07),
                5);

            // Act + Assert
            Assert.Throws<ProductCreateValidationException>(() => new ProductService(
                new CategoryRepository(db),
                new ProductRepository(db),
                new ProductRepository(db),
                new DateTimeServiceMock(),
                new ProductNumberServiceMock())
                .Create(command));
        }
    }
}