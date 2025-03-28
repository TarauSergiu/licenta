using licenta.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

    namespace licenta.Data
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options) { }

            public DbSet<Utilizator> Utilizatori { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=LicentaDb;Trusted_Connection=True;");
            }
        }
    }
}
