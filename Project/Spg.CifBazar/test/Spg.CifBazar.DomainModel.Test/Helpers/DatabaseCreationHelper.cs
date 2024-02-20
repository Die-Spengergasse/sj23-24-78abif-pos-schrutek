using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Spg.CifBazar.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Test.Helpers
{
    public class DatabaseCreationHelper
    {
        public static UnitTestContext CreateDb()
        {
            DbContextOptionsBuilder options = new DbContextOptionsBuilder();
            options.UseSqlite("Data Source=CifBaza.db");

            UnitTestContext db = new UnitTestContext(options.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        public static UnitTestContext CreatMemoryDb()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();

            DbContextOptionsBuilder options = new DbContextOptionsBuilder();
            options.UseSqlite(connection);

            UnitTestContext db = new UnitTestContext(options.Options);
            db.Database.EnsureCreated();
            return db;
        }
    }
}
