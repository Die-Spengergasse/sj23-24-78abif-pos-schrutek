using Spg.CifBazar.DomainModel.Interfaces;
using Spg.CifBazar.DomainModel.Model;

namespace Spg.CifBazar.Repository
{
    public class ProductRepositoryFilterBuilder : IProductRepositoryFilterBuilder
    {
        public IQueryable<Product> Products { get; set; }

        public ProductRepositoryFilterBuilder(IQueryable<Product> products)
        {
            Products = products;
        }

        public IProductRepositoryFilterBuilder ApplyExpiryDateLessThanFilter(DateOnly currentDate)
        {
            Products = Products.Where(p => p.ExpiryDate < currentDate);
            return this;
        }

        public IProductRepositoryFilterBuilder ApplyNameContainsFilter(string namePart)
        {
            Products = Products.Where(p => p.Name.ToLower().Contains(namePart.ToLower()));
            return this;
        }

        public IProductRepositoryFilterBuilder ApplyOrderByName()
        {
            Products = Products.OrderBy(p => p.Name);
            return this;
        }

        public IQueryable<Product> Build()
        {
            return Products;
        }
    }
}
