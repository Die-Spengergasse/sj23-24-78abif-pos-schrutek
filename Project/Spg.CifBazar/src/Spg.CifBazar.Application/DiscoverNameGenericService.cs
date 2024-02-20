using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application
{
    public class DiscoverNameGenericService 
    {
        public string GetName<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            return entity.Name;
        }
    }
}
