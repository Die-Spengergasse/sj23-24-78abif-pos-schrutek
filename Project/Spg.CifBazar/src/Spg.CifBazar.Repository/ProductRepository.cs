using Microsoft.EntityFrameworkCore;
using Spg.CifBazar.DomainModel.Exceptions;
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
    public class ProductRepository : RepositoryBase<Product>, IReadOnlyProductRepository, IWritableProductRepository
    {
        private readonly CifBazarContext _context;

        public IProductRepositoryFilterBuilder FilterBuilder { get; set; }

        public ProductRepository(CifBazarContext context) 
            : base(context)
        {
            _context = context;
            FilterBuilder = new ProductRepositoryFilterBuilder(_context.Products);
        }

        public IProductUpdateBuilder UpdateBuilder(Product productToChange)
        {
            return new ProductUpdateBuilder(productToChange, _context);
        }

        // TODO: Delete-Methode

        // TODO: GetSingle(id/key)

        // TODO: GetAll()
    }
}
