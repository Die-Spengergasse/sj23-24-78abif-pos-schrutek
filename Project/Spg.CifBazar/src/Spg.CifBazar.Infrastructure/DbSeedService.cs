using Bogus;
using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Infrastructure
{
    public class DbSeedService
    {
        private readonly CifBazarContext _db;

        public DbSeedService(CifBazarContext db) 
        {
            _db = db;
        }

        public void Seed()
        {
            var shops = new Faker<Shop>("de").CustomInstantiator(
                InstantiationFactory.GenerateShop)
                .Rules((f, s) =>
                {
                    string[] categories = f.Commerce.Categories(100);
                    s.AddCategories(new Faker<Category>("de").CustomInstantiator(
                        InstantiationFactory.GenerateCategory)
                    .Rules((f, c) =>
                    {

                    })
                    .Generate(12));
                })
                .Generate(50);

            _db.Shops.AddRange(shops);
            _db.SaveChanges();
        }
    }
}
