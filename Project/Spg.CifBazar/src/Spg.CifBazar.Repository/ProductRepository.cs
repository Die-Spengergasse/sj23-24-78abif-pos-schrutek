using Spg.CifBazar.DomainModel.Interfaces;
using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Repository
{
    public class ProductRepository : IProductRerpository
    {
        private readonly CifBazarContext _db;

        public IProductRepositoryFilterBuilder FilterBuilder { get; set; }

        public ProductRepository(CifBazarContext db) 
        {
            _db = db;
            FilterBuilder = new ProductRepositoryFilterBuilder(_db.Products);
        }

        public IProductUpdateBuilder UpdateBuilder(Product productToChange)
        {
            return new ProductUpdateBuilder(productToChange, _db);
        }

        // TODO: Create-Methode

        // TODO: Delete-Methode

        // TODO: GetSingle(id/key)

        // TODO: GetAll()
    }
}
