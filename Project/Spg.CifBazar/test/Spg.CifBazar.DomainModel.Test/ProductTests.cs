using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.DomainModel.Test.Helpers;
using Spg.CifBazar.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Test
{
    public class ProductTests
    {
        [Fact]
        public void CreateProduct_ShouldCreateNew_WhenParametersAreValid()
        {
            using (CifBazarContext db = DatabaseCreationHelper.CreatMemoryDb())
            {
                // Arrange
                Product newProduct1 = DatabaseUtilities.GetSeedingProducts(DatabaseUtilities.GetSeedingCategories(DatabaseUtilities.GetSeedingShops())).First();
                Product newProduct2 = DatabaseUtilities.GetSeedingProducts(DatabaseUtilities.GetSeedingCategories(DatabaseUtilities.GetSeedingShops())).ElementAt(1);

                // Act
                db.Products.Add(newProduct1);
                db.Products.Add(newProduct2);
                int result = db.SaveChanges();

                // Assert
                Assert.Equal(2, db.Products.Count());
            }
        }
    }
}
