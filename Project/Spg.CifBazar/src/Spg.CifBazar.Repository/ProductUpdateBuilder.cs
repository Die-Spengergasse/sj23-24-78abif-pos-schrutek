using Microsoft.EntityFrameworkCore;
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
    public class ProductUpdateBuilder : IProductUpdateBuilder
    {
        private readonly Product _productToChange;
        private readonly CifBazarContext _context;

        public ProductUpdateBuilder(Product productToChange, CifBazarContext context)
        {
            _productToChange = productToChange;
            _context = context;
        }

        public IProductUpdateBuilder ExpiryDate(DateOnly expirydate)
        {
            _productToChange.ExpiryDate = expirydate;
            return this;
        }

        public IProductUpdateBuilder UpdateDescription(string description)
        {
            _productToChange.Description = description;
            return this;
        }

        public IProductUpdateBuilder UpdateName(string name)
        {
            _productToChange.Name = name;
            return this;
        }

        public void Save()
        {
            _context.Products.Update(_productToChange);
            _context.SaveChanges();
        }
    }
}
