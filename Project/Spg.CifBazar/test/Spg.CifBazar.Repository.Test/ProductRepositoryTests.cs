using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Infrastructure;
using Spg.CifBazar.Repository.Test.Helpers;

namespace Spg.CifBazar.Repository.Test;

public class ProductRepositoryTests
{
    [Fact]
    public void Filter_ShouldResult2Pruducts_WhenFilterByNameContains()
    {
        using (CifBazarContext db = DatabaseCreationHelper.CreateMemoryDb())
        {
            // Arrange
            db.Shops.AddRange(DatabaseUtilities.GetSeedingShops());
            db.SaveChanges();

            // Act
            List<Product> actual = new ProductRepository(db)
                .FilterBuilder
                .ApplyNameContainsFilter("l")
                .Build()
                .ToList();

            //Assert
            Assert.Equal(4, actual.Count);
        }
    }
}