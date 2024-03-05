using Microsoft.EntityFrameworkCore;
using Spg.CifBazar.DomainModel.Exceptions;
using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Repository
{
    public abstract class RepositoryBase<TEntity> where TEntity : class
    {
        private readonly CifBazarContext _context;

        public RepositoryBase(CifBazarContext context)
        {
            _context = context;
        }

        public TEntity Create(TEntity newEntity)
        {
            _context.Add(newEntity);
            try
            {
                _context.SaveChanges();
                return newEntity;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ProductRepositoryWriteException.FromCreate(ex);
            }
            catch (DbUpdateException ex)
            {
                throw ProductRepositoryWriteException.FromCreate(ex);
            }
        }
    }
}
