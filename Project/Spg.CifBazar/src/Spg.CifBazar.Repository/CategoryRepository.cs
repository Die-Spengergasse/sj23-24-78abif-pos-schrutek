using Microsoft.EntityFrameworkCore;
using Spg.CifBazar.DomainModel.Interfaces;
using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Infrastructure;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Repository
{
    public class CategoryRepository : IReadOnlyCategoryRepository
    {
        private readonly CifBazarContext _context;

        public CategoryRepository(CifBazarContext context)
        {
            _context = context;
        }

        public Category? GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public Category? GetCategoryById_OLD(int id) 
        {
            return _context
                .Shops
                .Select(s => s.Categories.SingleOrDefault(c => c.Id == id))
                .Where(c => c != null)
                .SingleOrDefault();

            //foreach (Shop s in _context.Shops)
            //{
            //    Category? category = s.Categories.SingleOrDefault(c => c.Id == id);
            //    if (category is not null)
            //    {
            //        return category;
            //    }
            //}
            //return null; // TODO: throw Exception
        }
    }
}
