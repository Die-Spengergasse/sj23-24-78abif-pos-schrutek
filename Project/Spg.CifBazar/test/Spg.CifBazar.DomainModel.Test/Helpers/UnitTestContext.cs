using Microsoft.EntityFrameworkCore;
using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Test.Helpers
{
    public class UnitTestContext : CifBazarContext
    {
        public DbSet<Category> Categories => Set<Category>();

        public UnitTestContext(DbContextOptions options)
            : base(options)
        { }
    }
}
