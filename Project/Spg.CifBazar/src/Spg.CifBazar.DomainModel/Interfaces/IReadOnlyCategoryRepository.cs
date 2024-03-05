using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Interfaces
{
    public interface IReadOnlyCategoryRepository
    {
        Category? GetCategoryById(int id);
    }
}
