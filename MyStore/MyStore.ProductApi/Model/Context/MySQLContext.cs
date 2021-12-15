﻿using Microsoft.EntityFrameworkCore;

namespace MyStore.ProductApi.Model.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}