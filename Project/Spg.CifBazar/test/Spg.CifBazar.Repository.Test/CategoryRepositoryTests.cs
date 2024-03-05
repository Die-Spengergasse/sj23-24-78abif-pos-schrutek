using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Infrastructure;
using Spg.CifBazar.Repository.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Repository.Test
{
    public class CategoryRepositoryTests
    {
        [Fact]
        public void GetCategoryById_ShouldGet1CategoryFound()
        {
            using (CifBazarContext db = DatabaseCreationHelper.CreateMemoryDb())
            {
                // Arrange
                db.Shops.AddRange(DatabaseUtilities.GetSeedingShops());
                db.SaveChanges();

                // Act
                var actual = new CategoryRepository(db).GetCategoryById(5);

                //Assert
                Assert.Equal(5, actual!.Id);
                Assert.Equal("Getränke", actual!.Name);
            }
        }

        [Fact]
        public void GetCategoryById_ShouldRetunNULLCategoryNOTFound()
        {
            using (CifBazarContext db = DatabaseCreationHelper.CreateMemoryDb())
            {
                // Arrange
                db.Shops.AddRange(DatabaseUtilities.GetSeedingShops());
                db.SaveChanges();

                // Act
                var actual = new CategoryRepository(db).GetCategoryById(12456789);

                //Assert
                Assert.Null(actual);
            }
        }
    }
}
