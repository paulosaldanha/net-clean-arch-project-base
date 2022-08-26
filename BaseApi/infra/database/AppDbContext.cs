using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.infra.database.models;
using Microsoft.EntityFrameworkCore;

namespace BaseApi
{
    public class AppDbContext: DbContext
    {
        public DbSet<ItemDB> itemDBs {get; set;}
        public DbSet<OrderDB> OrderDBs {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}