using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Model
{
    public class Category : IEntity
    {
        private Category()
        { }
        public Category(string name)
        {
            Name = name;
        }
        public Category(string name, Shop shopNavigation)
        {
            Name = name;
            ShopNavigation = shopNavigation;
        }

        public int Id { get; private set; }
        public string Name { get; set; } = string.Empty;

        public Shop ShopNavigation { get; set; } = default!;

        private List<Product> _products = new();
        public IReadOnlyList<Product> Products => _products;

        public Category AddProduct(Product newProduct)
        {
            if (newProduct is not null)
            {
                // TODO: Checks, Properties setzen, ...
                newProduct.CategoryNavigation = this;
                _products.Add(newProduct);
            }
            return this;
        }

        public Category AddProducts(IEnumerable<Product> categories)
        {
            var result = categories
                .Where(c => c is not null)
                .Distinct()
                .Select(c => new Product(c.Name, c.Description, c.ExpiryDate, this));
            _products.AddRange(result);
            return this;
        }
    }
}
