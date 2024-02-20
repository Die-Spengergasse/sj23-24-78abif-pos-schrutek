using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Spg.CifBazar.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Spg.CifBazar.Repository.Test.Helpers
{
    public class DatabaseCreationHelper
    {
        public static CifBazarContext CreateDb()
        {
            DbContextOptionsBuilder options = new DbContextOptionsBuilder();
            options.UseSqlite("Data Source=CifBaza.db");

            CifBazarContext db = new CifBazarContext(options.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        public static CifBazarContext CreateMemoryDb()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();

            DbContextOptionsBuilder options = new DbContextOptionsBuilder();
            options.UseSqlite(connection);

            CifBazarContext db = new CifBazarContext(options.Options);
            db.Database.EnsureCreated();
            return db;
        }

        private void ConfigureContext(DbContextOptionsBuilder options)
        {
            options.UseSqlite("");
        }
    }
}
