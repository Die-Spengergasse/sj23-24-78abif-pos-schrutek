using Microsoft.EntityFrameworkCore;
using Spg.CifBazar.DomainModel.Exceptions;
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
    public class ShopRepository : IReadOnlyShopRepository
    {
        private readonly CifBazarContext _context;

        public ShopRepository(CifBazarContext context)
        {
            _context = context;
        }

        // TODO: Create-Methode

        // TODO: Delete-Methode

        public Shop GetSingle(int id)
        {
            return _context.Shops.Where(s => s.Id == id).SingleOrDefault() ??
                throw ShopRepositoryReadException.FromIdNotFound(id);
        }

        public IQueryable<Shop> GetAll()
        {
            return _context.Shops;
        }

        public void Create(Shop newShop)
        {
            _context.Add(newShop);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ShopRepositoryWriteException.FromCreate(ex);
            }
            catch (DbUpdateException ex)
            {
                throw ShopRepositoryWriteException.FromCreate(ex);
            }
        }
    }
}
