using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application
{
    public class ProductService
    {
        public void UpdatePeroduct()
        {
            List<Product> filteredProducts = new ProductRepository(null!)
                .FilterBuilder
                .ApplyNameContainsFilter("a")
                .ApplyExpiryDateLessThanFilter(DateOnly.FromDateTime(DateTime.Now).AddDays(14))
                .ApplyOrderByName()
                .Build()
                .ToList();


            new ProductRepository(null!)
                .UpdateBuilder(null!)
                .UpdateDescription("asdasd")
                .UpdateName("asdasdasdasd")
                .UpdateDescription("asdasdasdasdasdasdasd")
                .Save();
        }
    }
}
