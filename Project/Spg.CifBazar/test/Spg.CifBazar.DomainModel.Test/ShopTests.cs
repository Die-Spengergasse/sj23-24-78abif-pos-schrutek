using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.DomainModel.Test.Helpers;
using Spg.CifBazar.Infrastructure;
using System.Xml.Linq;

namespace Spg.CifBazar.DomainModel.Test;

public class ShopTests
{
    // Pattern Namen: Action__Should__When
    [Fact]
    public void CreateShop_ShouldCreateNew_WhenParametersAreValid()
    {
        using (CifBazarContext db = DatabaseCreationHelper.CreatMemoryDb())
        {
            // Arrange
            Shop newShop = DatabaseUtilities.GetSeedingShops().First();

            // Act
            db.Shops.Add(newShop);
            int result = db.SaveChanges();

            // Assert
            Assert.Equal(1, result);
            Assert.Equal(1, db.Shops.Count());
            Assert.Equal("Super Shop", db.Shops.First().Name);
        }
    }

    [Fact]
    public void CreateCategory_ShouldCreateNewCategoryForShop_WhenParametersAreValid()
    {
        using (CifBazarContext db = DatabaseCreationHelper.CreatMemoryDb())
        {
            // Arrange
            Shop newShop = DatabaseUtilities.GetSeedingShops().First()
                .AddCategories(DatabaseUtilities.GetSeedingCategories(DatabaseUtilities.GetSeedingShops()));

            // Act
            db.Shops.Add(newShop);
            int result = db.SaveChanges();

            // Assert
            Assert.Equal(10, result);
            Assert.Equal(9, db.Shops.First().Categories.Count());
        }
    }

    [Fact]
    public void CreateCategory_ShouldNotCreateNewCategoryForShop_WhencategoryIsNull()
    {
        using (CifBazarContext db = DatabaseCreationHelper.CreatMemoryDb())
        {
            // Arrange
            Shop newShop = DatabaseUtilities.GetSeedingShops().First().AddCategory(null!);

            // Act
            db.Shops.Add(newShop);
            int result = db.SaveChanges();

            // Assert
            Assert.Equal(1, result);
            Assert.Empty(db.Shops.First().Categories);
        }
    }
}