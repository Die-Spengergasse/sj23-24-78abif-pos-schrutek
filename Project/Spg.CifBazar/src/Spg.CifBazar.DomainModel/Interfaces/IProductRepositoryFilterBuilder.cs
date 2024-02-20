using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Interfaces
{
    public interface IProductRepositoryFilterBuilder
    {
        IQueryable<Product> Products { get; set; }

        IProductRepositoryFilterBuilder ApplyNameContainsFilter(string namePart);

        IProductRepositoryFilterBuilder ApplyExpiryDateLessThanFilter(DateOnly ecurrentDate);

        IProductRepositoryFilterBuilder ApplyOrderByName();

        IQueryable<Product> Build();
    }
}
