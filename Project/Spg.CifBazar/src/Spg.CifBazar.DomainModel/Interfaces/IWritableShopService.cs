using Spg.CifBazar.DomainModel.Dtos;
using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Interfaces
{
    public interface IWritableShopService
    {
        ShopDto Create(CreateShopCommand newShop);
        void Delete(int id);
    }
}
