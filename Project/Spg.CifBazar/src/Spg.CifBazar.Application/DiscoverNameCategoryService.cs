using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application
{
    public class DiscoverNameCategoryService
    {
        public string GetName(Category entity)
        {
            return entity.Name;
        }
    }
}
