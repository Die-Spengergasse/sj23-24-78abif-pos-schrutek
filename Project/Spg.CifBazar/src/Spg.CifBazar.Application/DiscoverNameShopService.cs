using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application
{
    public class DiscoverNameShopService
    {
        public string GetName(Shop entity)
        {
            return entity.Name;
        }
    }
}
